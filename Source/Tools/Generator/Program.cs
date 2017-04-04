using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Generator
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

            public override string ToString() => $"{this.ReturnType} {this.Name}({string.Join(", ", this.Params)})";
        }

        class FunctionParamData
        {
            public bool IsConst { get; set; }

            public int PointerCount { get; set; }

            public string Type { get; set; }

            public string Name { get; set; }

            public override string ToString() => $"{this.Type}: {this.Name}";
        }

        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("glcorearb.h");
            var enums = new List<EnumData>();
            var functions = new List<FunctionData>();

            Parse(lines, enums, functions);

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
            string[] license = File.ReadAllLines("License.txt");

            StringBuilder sb = new StringBuilder(1024);

            foreach (var line in license)
            {
                sb.Append("// ");
                sb.AppendLine(line);
            }

            sb.AppendLine();

            sb.AppendLine("using System;");
            sb.AppendLine("using System.Runtime.InteropServices;");
            sb.AppendLine();
            sb.AppendLine("namespace GLDotNet");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic static class GL");
            sb.AppendLine("\t{");
            
            foreach (var @enum in enums)
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

            foreach (var function in functions)
            {
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x.Type, x.IsConst, x.PointerCount) + " " + GetParamName(x.Name)));

                string functionName = GetFunctionName(function.Name);
                sb.AppendLine($"\t\t\tpublic delegate {GetReturnType(function.ReturnType)} {functionName}({parameters});");
                sb.AppendLine();
            }

            sb.AppendLine("\t\t}");
            sb.AppendLine();

            foreach (var function in functions)
            {
                string parameters = string.Join(", ", function.Params.Select(x => GetParamType(x.Type, x.IsConst, x.PointerCount) + " " + GetParamName(x.Name)));

                string functionName = GetFunctionName(function.Name);
                sb.AppendLine($"\t\tpublic static Delegates.{functionName} {functionName};");
                sb.AppendLine();
            }

            sb.AppendLine("\t\tpublic static void Initialize(Func<string, IntPtr> getProcAddress, int versionMajor, int versionMinor)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tif (getProcAddress == null) throw new ArgumentNullException(nameof(getProcAddress));");
            sb.AppendLine();

            int versionMajor = -1;
            int versionMinor = -1;
            
            foreach (var function in functions)
            {
                string functionName = GetFunctionName(function.Name);

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

                sb.AppendLine($"\t\t\t\t{functionName} = (Delegates.{functionName})Marshal.GetDelegateForFunctionPointer(getProcAddress(\"{function.Name}\"), typeof(Delegates.{functionName}));");
            }

            sb.AppendLine("\t\t\t}");

            sb.AppendLine("\t\t}");

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            File.WriteAllText(@"..\..\..\..\Library\GLDotNet\GL.cs", sb.ToString());
        }

        private static object GetReturnType(string returnType)
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

        private static string GetParamType(string type, bool isConst, int pointerCount)
        {
            switch (type)
            {
                case "GLboolean":
                    type = "bool";
                    break;

                case "GLubyte":
                    type = "byte";
                    break;

                case "GLchar":
                    if (pointerCount == 1)
                    {
                        type = "string";
                    }
                    else if (pointerCount == 2)
                    {
                        type = "string[]";
                    }
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
                case "GLDEBUGPROC":
                    type = "IntPtr";
                    break;

                case "void":
                    if (pointerCount == 2)
                    {
                        type = "IntPtr[]";
                    }
                    else
                    {
                        type = "IntPtr";
                    }
                    break;

                case "GLint64":
                    type  = "long";
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
    }
}
