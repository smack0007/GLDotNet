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
                VersionMajor = other.VersionMajor;
                VersionMinor = other.VersionMinor;
            }
        }

        class EnumData : BaseData
        {
            public string Name { get; set; }

            public string Value { get; set; }

            public override string ToString() => $"{Name}: {Value}";
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
                ReturnType = functionData.ReturnType;
                Name = functionData.Name;

                Params = new List<FunctionParamData>();
                foreach (var param in functionData.Params)
                {
                    Params.Add(new FunctionParamData(param));
                }
            }

            public override string ToString() => $"{ReturnType} {Name}({string.Join(", ", Params)})";
        }

        class FunctionParamData
        {
            public bool IsConst { get; set; }

            public int PointerCount { get; set; }

            public bool TypeOverridden { get; private set; } = false;

            public string TypePrefix { get; set; }

            public string Type { get; set; }

            public string Name { get; set; }

            public bool UseForVoidPointerOverload { get; set; }

            public bool UseForByRefOverload { get; set; }

            public FunctionParamData() { }

            public FunctionParamData(FunctionParamData functionParamData)
            {
                IsConst = functionParamData.IsConst;
                PointerCount = functionParamData.PointerCount;
                TypeOverridden = functionParamData.TypeOverridden;
                TypePrefix = functionParamData.TypePrefix;
                Type = functionParamData.Type;
                Name = functionParamData.Name;
            }

            public override string ToString() => $"{Type}: {Name}";

            public void OverrideType(string type, string typePrefix = null)
            {
                TypePrefix = typePrefix;
                Type = type;
                TypeOverridden = true;
            }
        }

        static void Main(string[] args)
        {            
            var lines = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "glcorearb.h"));

            var enums = new List<EnumData>();
            var functions = new List<FunctionData>();

            Parse(lines, enums, functions);

            var glBufferData = functions.Single(x => x.Name == "glBufferData");
            glBufferData.Params.Single(x => x.Name == "data").UseForVoidPointerOverload = true;

            var glBufferSubData = functions.Single(x => x.Name == "glBufferSubData");
            glBufferSubData.Params.Single(x => x.Name == "data").UseForVoidPointerOverload = true;

            //var glGetProgramInfoLog = functions.Single(x => x.Name == "glGetProgramInfoLog");
            //glGetProgramInfoLog.Params.Single(x => x.Name == "length").OverrideType("int*", "out");

            //var glGetProgramiv = functions.Single(x => x.Name == "glGetProgramiv");
            //glGetProgramiv.Params.Single(x => x.Name == "params").OverrideType("int*", "out");

            //var glGetShaderInfoLog = functions.Single(x => x.Name == "glGetShaderInfoLog");
            //glGetShaderInfoLog.Params.Single(x => x.Name == "length").OverrideType("int*", "out");

            //var glGetShaderiv = functions.Single(x => x.Name == "glGetShaderiv");
            //glGetShaderiv.Params.Single(x => x.Name == "params").OverrideType("int*", "out");

            //var glShaderSource = functions.Single(x => x.Name == "glShaderSource");
            //glShaderSource.Params.Single(x => x.Name == "string").OverrideType("string", "ref");
            //glShaderSource.Params.Single(x => x.Name == "length").OverrideType("int", "ref");

            var glTexImage1D = functions.Single(x => x.Name == "glTexImage1D");
            glTexImage1D.Params.Single(x => x.Name == "pixels").UseForVoidPointerOverload = true;

            var glTexImage2D = functions.Single(x => x.Name == "glTexImage2D");
            glTexImage2D.Params.Single(x => x.Name == "pixels").UseForVoidPointerOverload = true;

            var glTexImage3D = functions.Single(x => x.Name == "glTexImage3D");
            glTexImage3D.Params.Single(x => x.Name == "pixels").UseForVoidPointerOverload = true;

            foreach (var function in functions.Where(x =>
                x.Name.StartsWith("glGet") &&
                x.Name.EndsWith("v") &&
                x.Params.Any(y => y.Name == "data")))
            {
                function.Params.Single(x => x.Name == "data").UseForByRefOverload = true;
            }

            foreach (var function in functions.Where(x =>
                (x.Name.StartsWith("glUniform") || x.Name.StartsWith("glProgramUniform")) &&
                x.Name.EndsWith("v") &&
                x.Params.Any(y => y.Name == "value")))
            {
                function.Params.Single(x => x.Name == "value").UseForByRefOverload = true;
            }

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
                                parts[j] += "*";
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

                if (lines[i].StartsWith("#endif /* GL_VERSION_4_6 */"))
                    break;
            }
        }

        private static void Write(List<EnumData> enums, List<FunctionData> functions)
        {
            string[] license = File.ReadAllLines(Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "License.txt"));

            StringBuilder sb = new StringBuilder(1024);

            foreach (var line in license)
            {
                sb.Append("// ");
                sb.AppendLine(line);
            }

            sb.AppendLine();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine();
            sb.AppendLine("namespace GLDotNet");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static unsafe partial class GL");
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
                string parameters = string.Join(", ", function.Params.Select(x => GetParamTypeForDelegate(x) + " " + GetParamName(x.Name)));

                sb.AppendLine($"\t\t\tpublic delegate {GetReturnType(function.ReturnType)} {function.Name}({parameters});");
                sb.AppendLine();
            }

            sb.AppendLine("\t\t}");
            sb.AppendLine();

            foreach (var function in orderedFunctions)
            {
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));

                sb.AppendLine($"\t\tpublic static Delegates.{function.Name} {function.Name} {{ get; set; }}");
                sb.AppendLine();
            }

            sb.AppendLine("#if !GLDOTNET_EXCLUDE_GLINIT");
            sb.AppendLine("\t\tpublic static void glInit(Func<string, IntPtr> getProcAddress, int versionMajor, int versionMinor)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tif (getProcAddress == null) throw new ArgumentNullException(nameof(getProcAddress));");
            sb.AppendLine();
            sb.AppendLine("\t\t\tT getProc<T>(string name) => Marshal.GetDelegateForFunctionPointer<T>(getProcAddress(name));");
            sb.AppendLine();

            void AppendLoadDelegate(string indent, FunctionData function)
            {
                sb.AppendLine($"{indent}{function.Name} = getProc<Delegates.{function.Name}>(\"{function.Name}\");");
            }

            int versionMajor = -1;
            int versionMinor = -1;

            foreach (var function in functions.OrderBy(x => x.VersionMajor).ThenBy(x => x.VersionMinor).ThenBy(x => x.Name))
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

                AppendLoadDelegate("\t\t\t\t", function);
            }

            sb.AppendLine("\t\t\t}");
            sb.AppendLine("\t\t}");
            sb.AppendLine("#endif");
            //sb.AppendLine();

            //foreach (var function in orderedFunctions)
            //{
            //    string returnType = GetReturnType(function.ReturnType);
            //    string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));
            //    string parameterNames = string.Join(", ", function.Params.Select(x => GetParamInvoke(x)));

            //    bool isUnsafe = function.Params.Any(x => x.PointerCount > 0);

            //    sb.AppendLine($"\t\tpublic static {(isUnsafe ? "unsafe " : "")}{returnType} {function.Name}({parameters})");
            //    sb.AppendLine("\t\t{");

            //    bool hasPointers = function.Params.Any(x => ShouldUsePointerForInvoke(x));

            //    if (hasPointers)
            //    {
            //        foreach (var param in function.Params.Where(x => x.PointerCount > 0))
            //            sb.AppendLine($"\t\t\tfixed ({GetParamTypeForDelegate(param)} {GetParamName(param.Name)}Ptr = {GetParamName(param.Name)})");

            //        sb.AppendLine("\t\t\t{");
            //        sb.Append("\t");
            //    }

            //    if (returnType != "void")
            //    {
            //        sb.AppendLine($"\t\t\treturn _{function.Name}({parameterNames});");
            //    }
            //    else
            //    {
            //        sb.AppendLine($"\t\t\t_{function.Name}({parameterNames});");
            //    }

            //    if (hasPointers)
            //    {
            //        sb.AppendLine("\t\t\t}");
            //    }

            //    sb.AppendLine("\t\t}");
            //    sb.AppendLine();

            //    if (function.Name.StartsWith("glDelete") &&
            //        function.Name != "glDeleteProgram" &&
            //        function.Name != "glDeleteShader" &&
            //        function.Name != "glDeleteSync")
            //    {
            //        sb.AppendLine($"\t\tpublic static void {function.Name.TrimEnd('s')}(uint handle)");
            //        sb.AppendLine("\t\t{");
            //        sb.AppendLine("\t\t\tvar temp = new uint[] { handle };");
            //        sb.AppendLine($"\t\t\t{function.Name}(1, temp);");
            //        sb.AppendLine("\t\t}");
            //        sb.AppendLine();
            //    }
            //    else if (function.Name.StartsWith("glGen") &&
            //             !function.Name.StartsWith("glGenerate"))
            //    {
            //        sb.AppendLine($"\t\tpublic static uint {function.Name.TrimEnd('s')}()");
            //        sb.AppendLine("\t\t{");
            //        sb.AppendLine($"\t\t\tvar temp = new uint[1];");
            //        sb.AppendLine($"\t\t\t{function.Name}(1, temp);");
            //        sb.AppendLine($"\t\t\treturn temp[0];");
            //        sb.AppendLine("\t\t}");
            //        sb.AppendLine();
            //    }
            //}

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            string fullPath = Path.GetFullPath(@"..\..\..\..\src\GLDotNet\GL.cs");
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

        private static string GetParamTypeForDelegate(FunctionParamData param, bool refOverload = false)
        {
            string type = param.Type;

            if (!param.TypeOverridden)
            {
                switch (param.Type)
                {
                    case "GLboolean":
                        type = "bool";
                        break;

                    case "GLboolean*":
                        type = "bool*";
                        break;

                    case "GLubyte":
                        type = "byte";
                        break;

                    case "GLubyte*":
                        type = "byte*";
                        break;

                    case "GLchar*":
                        if (param.IsConst)
                        {
                            type = "string";
                        }
                        else
                        {
                            type = "StringBuilder";
                        }
                        break;

                    case "GLchar**":
                        type = "string[]";
                        break;

                    case "GLDEBUGPROC":
                        type = "DebugProc";
                        break;

                    case "GLdouble":
                        type = "double";
                        break;

                    case "GLdouble*":
                        type = "double*";
                        break;

                    case "GLfloat":
                        type = "float";
                        break;

                    case "GLfloat*":
                        type = "float*";
                        break;

                    case "GLint":
                    case "GLsizei":
                    case "GLintptr":
                    case "GLsizeiptr":
                        type = "int";
                        break;

                    case "GLint*":
                    case "GLsizei*":
                    case "GLintptr*":
                    case "GLsizeiptr*":
                        type = "int*";
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

                    case "GLint64*":
                        type = "long*";
                        break;

                    case "GLbyte":
                        type = "sbyte";
                        break;

                    case "GLbyte*":
                        type = "sbyte*";
                        break;

                    case "GLshort":
                        type = "short";
                        break;

                    case "GLshort*":
                        type = "short*";
                        break;

                    case "GLbitfield":
                    case "GLenum":
                    case "GLuint":
                        type = "uint";
                        break;

                    case "GLuint*":
                    case "GLenum*":
                        type = "uint*";
                        break;

                    case "GLuint64":
                        type = "ulong";
                        break;

                    case "GLuint64*":
                        type = "ulong*";
                        break;

                    case "GLushort":
                        type = "ushort";
                        break;

                    case "GLushort*":
                        type = "ushort*";
                        break;
                }

                //if (!type.StartsWith("string") && !type.StartsWith("StringBuilder") && !type.StartsWith("IntPtr"))
                //{
                //    if (param.PointerCount > 0)
                //    {
                //        type += "[]";
                //    }
                //}
            }

            //if (param.TypePrefix != null)
            //    type = param.TypePrefix + " " + type;

            //if (refOverload && param.UseForByRefOverload)
            //{
            //    if (type.EndsWith("[]"))
            //        type = type.Substring(0, type.Length - 2);

            //    type = "ref " + type;
            //}

            return type;
        }

        private static string GetParamType(FunctionParamData param, bool refOverload = false)
        {
            string type = param.Type;

            if (!param.TypeOverridden)
            {
                switch (param.Type)
                {
                    case "GLboolean":
                        type = "bool";
                        break;

                    case "GLboolean*":
                        type = "bool";
                        break;

                    case "GLubyte":
                        type = "byte";
                        break;

                    case "GLubyte*":
                        type = "byte";
                        break;

                    case "GLchar*":
                        if (param.IsConst)
                        {
                            type = "string";
                        }
                        else
                        {
                            type = "StringBuilder";
                        }
                        break;

                    case "GLchar**":
                        type = "string[]";
                        break;

                    case "GLDEBUGPROC":
                        type = "DebugProc";
                        break;

                    case "GLdouble":
                        type = "double";
                        break;

                    case "GLdouble*":
                        type = "double";
                        break;

                    case "GLfloat":
                        type = "float";
                        break;

                    case "GLfloat*":
                        type = "float";
                        break;

                    case "GLint":
                    case "GLsizei":
                    case "GLintptr":
                    case "GLsizeiptr":
                        type = "int";
                        break;

                    case "GLint*":
                    case "GLsizei*":
                    case "GLintptr*":
                    case "GLsizeiptr*":
                        type = "int";
                        break;

                    case "GLsync":
                        type = "IntPtr";
                        break;

                    case "void*":
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

                    case "GLint64*":
                        type = "long";
                        break;

                    case "GLbyte":
                        type = "sbyte";
                        break;

                    case "GLbyte*":
                        type = "sbyte";
                        break;

                    case "GLshort":
                        type = "short";
                        break;

                    case "GLshort*":
                        type = "short";
                        break;

                    case "GLbitfield":
                    case "GLenum":
                    case "GLuint":
                        type = "uint";
                        break;

                    case "GLuint*":
                    case "GLenum*":
                        type = "uint";
                        break;

                    case "GLuint64":
                        type = "ulong";
                        break;

                    case "GLuint64*":
                        type = "ulong";
                        break;

                    case "GLushort":
                        type = "ushort";
                        break;

                    case "GLushort*":
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

            //if (param.TypePrefix != null)
            //    type = param.TypePrefix + " " + type;

            //if (refOverload && param.UseForByRefOverload)
            //{
            //    if (type.EndsWith("[]"))
            //        type = type.Substring(0, type.Length - 2);

            //    type = "ref " + type;
            //}

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

        private static bool ShouldUsePointerForInvoke(FunctionParamData param)
        {
            if (param.PointerCount > 0)
            {
                var paramType = GetParamType(param);

                if (paramType != "string" &&
                    paramType != "StringBuilder" &&
                    paramType != "IntPtr")
                {
                    return true;
                }
            }

            return false;
        }

        private static string GetParamInvoke(FunctionParamData param, string cast = null)
        {
            string name = GetParamName(param.Name);

            if (param.TypePrefix != null)
            {
                name = param.TypePrefix + " " + name;
            }

            if (cast != null)
            {
                name = $"({cast}){name}";
            }

            if (ShouldUsePointerForInvoke(param))
            {
                name += "Ptr";
            }

            if (GetParamType(param) == "IntPtr")
            {
                name += ".ToPointer()";
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
