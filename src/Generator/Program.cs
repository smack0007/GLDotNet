using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GLGenerator
{
    class Program
    {
        class BaseData
        {
            public int VersionMajor { get; set; }

            public int VersionMinor { get; set; }

            public BaseData() { }

            public BaseData(BaseData other)
            {
                this.VersionMajor = other.VersionMajor;
                this.VersionMinor = other.VersionMinor;
            }
        }

        class EnumData : BaseData
        {
            public string Name { get; set; }

            public string Value { get; set; }

            public override string ToString() => $"{this.Name}: {this.Value}";
        }

        class FunctionData : BaseData
        {
            public string ReturnType { get; set; }

            public string Name { get; set; }

            public List<FunctionParamData> Params { get; } = new List<FunctionParamData>();

            public FunctionData() { }

            public FunctionData(FunctionData functionData)
                : base(functionData)
            {
                this.ReturnType = functionData.ReturnType;
                this.Name = functionData.Name;

                this.Params = new List<FunctionParamData>();
                foreach (var param in functionData.Params)
                {
                    this.Params.Add(new FunctionParamData(param));
                }
            }

            public override string ToString() => $"{this.ReturnType} {this.Name}({string.Join(", ", this.Params)})";
        }

        class FunctionParamData
        {
            public bool IsConst { get; set; }

            public int PointerCount { get; set; }

            public bool TypeOverridden { get; private set; } = false;

            public string TypePrefix { get; set; }

            public string Type { get; set; }

            public string Name { get; set; }

            public FunctionParamData() { }

            public FunctionParamData(FunctionParamData functionParamData)
            {
                this.IsConst = functionParamData.IsConst;
                this.PointerCount = functionParamData.PointerCount;
                this.TypeOverridden = functionParamData.TypeOverridden;
                this.TypePrefix = functionParamData.TypePrefix;
                this.Type = functionParamData.Type;
                this.Name = functionParamData.Name;
            }

            public override string ToString() => $"{this.Type}: {this.Name}";

            public void OverrideType(string type, string typePrefix = null)
            {
                this.TypePrefix = typePrefix;
                this.Type = type;
                this.TypeOverridden = true;
            }
        }

        static void Main(string[] args)
        {            
            var lines = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "glcorearb.h"));
            var xml = XDocument.Load(Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "gl.xml"));

            var enums = new List<EnumData>();
            var functions = new List<FunctionData>();

            Parse(lines, enums, functions);

            var glShaderSource = functions.Single(x => x.Name == "glShaderSource");
            glShaderSource.Params.Single(x => x.Name == "string").OverrideType("string", "ref");
            glShaderSource.Params.Single(x => x.Name == "length").OverrideType("int", "ref");

            var glGetProgramiv = functions.Single(x => x.Name == "glGetProgramiv");
            glGetProgramiv.Params.Single(x => x.Name == "params").OverrideType("int", "out");

            var glGetProgramInfoLog = functions.Single(x => x.Name == "glGetProgramInfoLog");
            glGetProgramInfoLog.Params.Single(x => x.Name == "length").OverrideType("int", "out");

            var glGetShaderiv = functions.Single(x => x.Name == "glGetShaderiv");
            glGetShaderiv.Params.Single(x => x.Name == "params").OverrideType("int", "out");

            var glGetShaderInfoLog = functions.Single(x => x.Name == "glGetShaderInfoLog");
            glGetShaderInfoLog.Params.Single(x => x.Name == "length").OverrideType("int", "out");

            var glUniformMatrix4fv = new FunctionData(functions.Single(x => x.Name == "glUniformMatrix4fv"));
            glUniformMatrix4fv.Params.Single(x => x.Name == "value").OverrideType("float", "ref");
            glUniformMatrix4fv.Name = glUniformMatrix4fv.Name + "ByRef";
            functions.Add(glUniformMatrix4fv);
            
            Write(enums, functions);
        }

        private static void Parse(string[] lines, List<EnumData> enums, List<FunctionData> functions)
        {
            int versionMajor = 0;
            int versionMinor = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("#ifndef GL_VERSION_"))
                {
                    var parts = lines[i].Substring("#ifndef GL_VERSION_".Length).Split('_');
                    versionMajor = int.Parse(parts[0]);
                    versionMinor = int.Parse(parts[1]);
                }
                else if (lines[i].StartsWith("#define GL_") && !lines[i].StartsWith("#define GL_VERSION_"))
                {
                    var parts = lines[i].Substring("#define ".Length).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    enums.Add(new EnumData()
                    {
                        VersionMajor = versionMajor,
                        VersionMinor = versionMinor,
                        Name = parts[0].Trim(),
                        Value = parts[1].Trim()
                    });
                }
                else if (lines[i].StartsWith("GLAPI ") && lines[i].Contains("APIENTRY"))
                {
                    var parts = lines[i].Substring("GLAPI ".Length)
                        .Replace("const GLubyte *APIENTRY", "IntPtr")
                        .Replace("APIENTRY", "")
                        .Replace("*const*", "**")
                        .Trim(';')
                        .Split(new char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    int j = 0;

                    var function = new FunctionData()
                    {
                        VersionMajor = versionMajor,
                        VersionMinor = versionMinor,
                    };

                    function.ReturnType = parts[j];
                    j++;

                    if (parts[j] == "*")
                    {
                        function.ReturnType += "*";
                        j++;
                    }

                    function.Name = parts[j];
                    j++;

                    if (parts[j] != "void")
                    {
                        for (; j < parts.Length; j += 2)
                        {
                            bool isConst = false;

                            if (parts[j] == "const")
                            {
                                isConst = true;
                                j++;
                            }

                            int pointerCount = 0;

                            while (parts[j + 1].StartsWith("*"))
                            {
                                pointerCount++;
                                parts[j + 1] = parts[j + 1].Substring("*".Length);
                            }

                            var functionParam = new FunctionParamData()
                            {
                                IsConst = isConst,
                                PointerCount = pointerCount,
                                Type = parts[j],
                                Name = parts[j + 1],
                            };

                            function.Params.Add(functionParam);
                        }
                    }

                    functions.Add(function);
                }

                if (lines[i].StartsWith("#endif /* GL_VERSION_4_5 */"))
                    break;
            }
        }

        private static void Write(List<EnumData> enums, List<FunctionData> functions)
        {
            StringBuilder sb = new StringBuilder(1024);

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine();
            sb.AppendLine("namespace GLDotNet");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static class GL");
            sb.AppendLine("\t{");

            foreach (var @enum in enums.OrderBy(x => x.Name))
            {
                string type = "uint";
                string name = @enum.Name;
                string value = @enum.Value;

                if (value == "0xFFFFFFFFFFFFFFFFull")
                    value = "0xFFFFFFFFFFFFFFFF";

                if (value.EndsWith("ull") || value == "0xFFFFFFFFFFFFFFFF")
                {
                    type = "ulong";
                }
                else if (value.EndsWith("u") || value == "0xFFFFFFFF")
                {
                    type = "uint";
                }

                sb.AppendLine($"\t\tpublic const {type} {name} = {value};");
            }

            sb.AppendLine();

            sb.AppendLine("\t\tpublic delegate void DebugProc(uint source, uint type, uint id, uint severity, int length, string message, IntPtr userParam);");
            sb.AppendLine();

            sb.AppendLine($"\t\tpublic static class Delegates");
            sb.AppendLine("\t\t{");

            var orderedFunctions = functions.OrderBy(x => x.Name);

            foreach (var function in orderedFunctions)
            {
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));

                sb.AppendLine($"\t\t\tpublic delegate {GetReturnType(function.ReturnType)} {function.Name}({parameters});");
                sb.AppendLine();
            }

            sb.AppendLine("\t\t}");
            sb.AppendLine();

            foreach (var function in orderedFunctions)
            {
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));

                sb.AppendLine($"\t\tprivate static Delegates.{function.Name} _{function.Name};");
                sb.AppendLine();
            }

            sb.AppendLine("\t\tpublic static void glInit(Func<string, IntPtr> getProcAddress, int versionMajor, int versionMinor)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tif (getProcAddress == null) throw new ArgumentNullException(nameof(getProcAddress));");
            sb.AppendLine();

            int versionMajor = -1;
            int versionMinor = -1;

            foreach (var function in functions)
            {
                if (versionMajor != function.VersionMajor || versionMinor != function.VersionMinor)
                {
                    if (versionMajor != -1)
                    {
                        sb.AppendLine("\t\t\t}");
                        sb.AppendLine();
                    }

                    versionMajor = function.VersionMajor;
                    versionMinor = function.VersionMinor;

                    sb.AppendLine($"\t\t\tif (versionMajor > {versionMajor} || (versionMajor == {versionMajor} && versionMinor >= {versionMinor}))");
                    sb.AppendLine("\t\t\t{");
                }

                // removes the appended reference name (if it exists) for the generated code pointing to the openGL functions
                string glFunctionName = function.Name;
                string appendedName = "ByRef";
                if (glFunctionName.Contains(appendedName))
                {
                    glFunctionName = glFunctionName.Remove(glFunctionName.Length - appendedName.Length);
                }

                sb.AppendLine($"\t\t\t\t_{function.Name} = (Delegates.{function.Name})Marshal.GetDelegateForFunctionPointer(getProcAddress(\"{glFunctionName}\"), typeof(Delegates.{function.Name}));");
            }

            sb.AppendLine("\t\t\t}");

            sb.AppendLine("\t\t}");
            sb.AppendLine();

            foreach (var function in orderedFunctions)
            {
                string returnType = GetReturnType(function.ReturnType);
                string parameters = null;
                string parameterNames = null;

                parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));
                parameterNames = string.Join(", ", function.Params.Select(x => GetParamInvoke(x.Name, x.TypePrefix)));

                sb.AppendLine($"\t\tpublic static {returnType} {function.Name}({parameters})");
                sb.AppendLine("\t\t{");

                if (returnType != "void")
                {
                    sb.AppendLine($"\t\t\treturn _{function.Name}({parameterNames});");
                }
                else
                {
                    sb.AppendLine($"\t\t\t_{function.Name}({parameterNames});");
                }

                sb.AppendLine("\t\t}");
                sb.AppendLine();

                if (function.Name.StartsWith("glDelete") &&
                    function.Name != "glDeleteProgram" &&
                    function.Name != "glDeleteShader" &&
                    function.Name != "glDeleteSync")
                {
                    sb.AppendLine($"\t\tpublic static void {function.Name.TrimEnd('s')}(uint handle)");
                    sb.AppendLine("\t\t{");
                    sb.AppendLine("\t\t\tvar temp = new uint[] { handle };");
                    sb.AppendLine($"\t\t\t{function.Name}(1, temp);");
                    sb.AppendLine("\t\t}");
                    sb.AppendLine();
                }
                else if (function.Name.StartsWith("glGen") &&
                         !function.Name.StartsWith("glGenerate"))
                {
                    sb.AppendLine($"\t\tpublic static uint {function.Name.TrimEnd('s')}()");
                    sb.AppendLine("\t\t{");
                    sb.AppendLine($"\t\t\tvar temp = new uint[1];");
                    sb.AppendLine($"\t\t\t{function.Name}(1, temp);");
                    sb.AppendLine($"\t\t\treturn temp[0];");
                    sb.AppendLine("\t\t}");
                    sb.AppendLine();
                }
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            string fullPath = Path.GetFullPath(@"..\..\..\..\src\GLDotNet\GL.Generated.cs");
            File.WriteAllText(fullPath, sb.ToString());
        }

        private static string GetReturnType(string returnType)
        {
            switch (returnType)
            {
                case "GLboolean":
                    returnType = "bool";
                    break;

                case "GLenum":
                    returnType = "uint";
                    break;

                case "GLint":
                    returnType = "int";
                    break;

                case "void*":
                case "GLsync":
                    returnType = "IntPtr";
                    break;

                case "GLuint":
                    returnType = "uint";
                    break;
            }

            return returnType;
        }

        private static string GetParamType(FunctionParamData param)
        {
            string type = param.Type;

            if (!param.TypeOverridden)
            {
                switch (param.Type)
                {
                    case "GLboolean":
                        type = "bool";
                        break;

                    case "GLubyte":
                        type = "byte";
                        break;

                    case "GLchar":
                        if (param.PointerCount == 1)
                        {
                            if (param.IsConst)
                            {
                                type = "string";
                            }
                            else
                            {
                                type = "StringBuilder";
                            }
                        }
                        else if (param.PointerCount == 2)
                        {
                            type = "string[]";
                        }
                        break;

                    case "GLDEBUGPROC":
                        type = "DebugProc";
                        break;

                    case "GLdouble":
                        type = "double";
                        break;

                    case "GLfloat":
                        type = "float";
                        break;

                    case "GLint":
                    case "GLsizei":
                    case "GLintptr":
                    case "GLsizeiptr":
                        type = "int";
                        break;

                    case "GLsync":
                        type = "IntPtr";
                        break;

                    case "void":
                        if (param.PointerCount == 2)
                        {
                            type = "IntPtr[]";
                        }
                        else
                        {
                            type = "IntPtr";
                        }
                        break;

                    case "GLint64":
                        type = "long";
                        break;

                    case "GLbyte":
                        type = "sbyte";
                        break;

                    case "GLshort":
                        type = "short";
                        break;

                    case "GLbitfield":
                    case "GLenum":
                    case "GLuint":
                        type = "uint";
                        break;

                    case "GLuint64":
                        type = "ulong";
                        break;

                    case "GLushort":
                        type = "ushort";
                        break;
                }

                if (!type.StartsWith("string") && !type.StartsWith("StringBuilder") && !type.StartsWith("IntPtr"))
                {
                    if (param.PointerCount > 0)
                    {
                        type += "[]";
                    }
                }
            }

            if (param.TypePrefix != null)
                type = param.TypePrefix + " " + type;

            return type;
        }

        private static string GetParamName(string name)
        {
            if (name == "params" ||
                name == "ref" ||
                name == "string")
            {
                name = "@" + name;
            }

            return name;
        }

        private static string GetParamInvoke(string name, string prefix, string cast = null)
        {
            name = GetParamName(name);

            if (prefix != null)
            {
                name = prefix + " " + name;
            }

            if (cast != null)
            {
                name = $"({cast}){name}";
            }

            return name;
        }

        private static string GetEnumName(string input)
        {
            string[] parts = input.Split('_');
            string[] temp = new string[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length > 0)
                {
                    int capitalizeLength = 1;

                    if (parts[i].Length > 1 && char.IsDigit(parts[i][0]))
                        capitalizeLength = 2;

                    temp[i] = parts[i].Substring(0, capitalizeLength).ToUpper() + parts[i].Substring(capitalizeLength).ToLower();
                }
            }

            string name = string.Join(string.Empty, temp);

            if (char.IsDigit(name[0]))
                name = "_" + name;

            return name;
        }
    }
}
