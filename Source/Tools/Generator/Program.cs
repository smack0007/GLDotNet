using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GLGenerator
{
    class Program
    {
        class BaseData
        {
            public int VersionMajor { get; set; }

            public int VersionMinor { get; set; }
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

            public bool OutputPublicMethod { get; set; } = true;

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
            var lines = File.ReadAllLines("glcorearb.h");
            var enums = new List<EnumData>();
            var functions = new List<FunctionData>();

            Parse(lines, enums, functions);

            functions.Single(x => x.Name == "glGetError").OutputPublicMethod = false;
            functions.Single(x => x.Name == "glGetString").OutputPublicMethod = false;
            functions.Single(x => x.Name == "glLinkProgram").OutputPublicMethod = false;

            var glShaderSource = functions.Single(x => x.Name == "glShaderSource");
            glShaderSource.Params.Single(x => x.Name == "string").OverrideType("ref string");
            glShaderSource.Params.Single(x => x.Name == "length").OverrideType("ref int");
            glShaderSource.OutputPublicMethod = false;

            var glGetProgramiv = functions.Single(x => x.Name == "glGetProgramiv");
            glGetProgramiv.Params.Single(x => x.Name == "params").OverrideType("out int");
            glGetProgramiv.OutputPublicMethod = false;

            var glGetProgramInfoLog = functions.Single(x => x.Name == "glGetProgramInfoLog");
            glGetProgramInfoLog.Params.Single(x => x.Name == "length").OverrideType("out int");
            glGetProgramInfoLog.OutputPublicMethod = false;

            var glGetShaderiv = functions.Single(x => x.Name == "glGetShaderiv");
            glGetShaderiv.Params.Single(x => x.Name == "params").OverrideType("out int");
            glGetShaderiv.OutputPublicMethod = false;

            var glGetShaderInfoLog = functions.Single(x => x.Name == "glGetShaderInfoLog");
            glGetShaderInfoLog.Params.Single(x => x.Name == "length").OverrideType("out int");
            glGetShaderInfoLog.OutputPublicMethod = false;

            var glUniformMatrix4fv = functions.Single(x => x.Name == "glUniformMatrix4fv");
            glUniformMatrix4fv.Params.Single(x => x.Name == "value").OverrideType("float", "ref");

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
                    var parts = lines[i].Substring("#define GL_".Length).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

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
            sb.AppendLine("\tpublic sealed partial class GL");
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

            sb.AppendLine($"\t\tpublic static class Delegates");
            sb.AppendLine("\t\t{");

            var filteredFunctions = functions.OrderBy(x => x.Name);

            foreach (var function in filteredFunctions)
            {
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));

                string functionName = GetFunctionName(function.Name);
                sb.AppendLine($"\t\t\tpublic delegate {GetReturnType(function.ReturnType)} {functionName}({parameters});");
                sb.AppendLine();
            }

            sb.AppendLine("\t\t}");
            sb.AppendLine();

            sb.AppendLine("\t\tprivate readonly IGLPlatformContext platformContext;");
            sb.AppendLine();

            foreach (var function in filteredFunctions)
            {
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));

                string functionName = GetFunctionName(function.Name);
                sb.AppendLine($"\t\tprivate Delegates.{functionName} _{functionName};");
                sb.AppendLine();
            }

            sb.AppendLine("\t\tpublic GL(IGLPlatformContext platformContext)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tthis.platformContext = platformContext ?? throw new ArgumentNullException(nameof(platformContext));");
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

                    sb.AppendLine($"\t\t\tif (this.platformContext.VersionMajor > {versionMajor} || (this.platformContext.VersionMajor == {versionMajor} && this.platformContext.VersionMinor >= {versionMinor}))");
                    sb.AppendLine("\t\t\t{");
                }

                string functionName = GetFunctionName(function.Name);
                sb.AppendLine($"\t\t\t\tthis._{functionName} = (Delegates.{functionName})Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress(\"{function.Name}\"), typeof(Delegates.{functionName}));");
            }

            sb.AppendLine("\t\t\t}");

            sb.AppendLine();
            sb.AppendLine("\t\t\tthis.Initialize();");

            sb.AppendLine("\t\t}");
            sb.AppendLine();

            foreach (var function in filteredFunctions.Where(x => x.OutputPublicMethod))
            {
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));
                string parameterNames = string.Join(", ", function.Params.Select(x => GetParamInvoke(x.Name, x.TypePrefix)));
                string returnType = GetReturnType(function.ReturnType);

                string functionName = GetFunctionName(function.Name);
                sb.AppendLine($"\t\tpublic {returnType} {functionName}({parameters})");
                sb.AppendLine("\t\t{");

                if (returnType != "void")
                {
                    sb.AppendLine($"\t\t\tvar result = this._{functionName}({parameterNames});");
                }
                else
                {
                    sb.AppendLine($"\t\t\tthis._{functionName}({parameterNames});");
                }

                sb.AppendLine($"#if DEBUG");
                sb.AppendLine($"\t\t\tthis.CheckErrors(\"{functionName}\");");
                sb.AppendLine("#endif");

                if (returnType != "void")
                {
                    sb.AppendLine($"\t\t\treturn result;");
                }

                sb.AppendLine("\t\t}");
                sb.AppendLine();

                if (function.Name.StartsWith("glDelete") &&
                    function.Name != "glDeleteProgram" &&
                    function.Name != "glDeleteShader" &&
                    function.Name != "glDeleteSync")
                {
                    sb.AppendLine($"\t\tpublic void {functionName.TrimEnd('s')}(uint handle)");
                    sb.AppendLine("\t\t{");
                    sb.AppendLine($"\t\t\tUintBuffer[0] = handle;");
                    sb.AppendLine($"\t\t\t{functionName}(1, UintBuffer);");
                    sb.AppendLine("\t\t}");
                    sb.AppendLine();
                }
                else if (function.Name.StartsWith("glGen") &&
                         !function.Name.StartsWith("glGenerate"))
                {
                    sb.AppendLine($"\t\tpublic uint {functionName.TrimEnd('s')}()");
                    sb.AppendLine("\t\t{");
                    sb.AppendLine($"\t\t\t{functionName}(1, UintBuffer);");
                    sb.AppendLine($"\t\t\treturn UintBuffer[0];");
                    sb.AppendLine("\t\t}");
                    sb.AppendLine();
                }
            }

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            File.WriteAllText(@"..\..\..\..\Library\GLDotNet\GL.Generated.cs", sb.ToString());
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

        private static string GetFunctionName(string name)
        {
            name = name.Substring("gl".Length);

            return name;
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

        private static string GetParamInvoke(string name, string prefix)
        {
            name = GetParamName(name);

            if (prefix != null)
            {
                name = prefix + " " + name;
            }

            return name;
        }
    }
}
