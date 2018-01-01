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
        }

        class EnumGroupData
        {
            public string Name { get; set; }

            public string Type { get; set; }

            public List<string> EnumNames { get; } = new List<string>();

            public bool IsInUse { get; set; }

            public bool HasFlagsAttribtue { get; set; }

            public override string ToString() => this.Name;
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

            public bool DisableEnumGroupOverload { get; set; } = false;

            public FunctionData() { }

            public FunctionData(FunctionData functionData)
            {
                this.ReturnType = functionData.ReturnType;
                this.Name = functionData.Name;

                this.Params = new List<FunctionParamData>();
                foreach (var param in functionData.Params)
                {
                    this.Params.Add(new FunctionParamData(param));
                }

                this.OutputPublicMethod = functionData.OutputPublicMethod;
                this.DisableEnumGroupOverload = functionData.DisableEnumGroupOverload;
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

            public EnumGroupData EnumGroup { get; set; }

            public FunctionParamData() { }

            public FunctionParamData(FunctionParamData functionParamData)
            {
                this.IsConst = functionParamData.IsConst;
                this.PointerCount = functionParamData.PointerCount;
                this.TypeOverridden = functionParamData.TypeOverridden;
                this.TypePrefix = functionParamData.TypePrefix;
                this.Type = functionParamData.Type;
                this.Name = functionParamData.Name;
                this.EnumGroup = functionParamData.EnumGroup;
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

            var enumGroups = new List<EnumGroupData>();
            var enums = new List<EnumData>();
            var functions = new List<FunctionData>();

            ParseHeaderFile(lines, enums, functions);
            ParseXmlFile(xml, enumGroups, enums, functions);
                        
            functions.Single(x => x.Name == "glGetError").OutputPublicMethod = false;
            functions.Single(x => x.Name == "glGetString").OutputPublicMethod = false;

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

            var glUniformMatrix4fv = new FunctionData(functions.Single(x => x.Name == "glUniformMatrix4fv"));
            glUniformMatrix4fv.Params.Single(x => x.Name == "value").OverrideType("float", "ref");
            glUniformMatrix4fv.Name = glUniformMatrix4fv.Name + "ByRef";
            functions.Add(glUniformMatrix4fv);

            // The following overrides can be reenabled once out parameters are properly implemented.
            functions.Single(x => x.Name == "glGetActiveAttrib").DisableEnumGroupOverload = true;
            functions.Single(x => x.Name == "glGetActiveUniform").DisableEnumGroupOverload = true;
            functions.Single(x => x.Name == "glGetDebugMessageLog").DisableEnumGroupOverload = true;
            functions.Single(x => x.Name == "glInvalidateNamedFramebufferData").DisableEnumGroupOverload = true;
            functions.Single(x => x.Name == "glInvalidateNamedFramebufferSubData").DisableEnumGroupOverload = true;
            functions.Single(x => x.Name == "glInvalidateSubFramebuffer").DisableEnumGroupOverload = true;
            functions.Single(x => x.Name == "glNamedFramebufferDrawBuffers").DisableEnumGroupOverload = true;
            
            WriteEnumGroups(enumGroups, enums);
            Write(enumGroups, enums, functions);
        }

        private static void ParseXmlFile(XDocument xml, List<EnumGroupData> enumGroups, List<EnumData> enums, List<FunctionData> functions)
        {
            foreach (var groupNode in xml.Descendants("group"))
            {
                if (groupNode.Attribute("name").Value == "Boolean")
                    continue;

                var enumGroup = new EnumGroupData()
                {
                    Name = groupNode.Attribute("name").Value,
                    Type = "uint"
                };

                foreach (var enumNode in groupNode.Elements())
                {
                    //if (removedEnums.Contains(enumNode.Attribute("name").Value))
                    //    continue;

                    var @enum = enums.SingleOrDefault(x => "GL_" + x.Name == enumNode.Attribute("name").Value);

                    if (@enum != null && !enumGroup.EnumNames.Contains(enumNode.Attribute("name").Value))
                    {
                        enumGroup.EnumNames.Add(enumNode.Attribute("name").Value);
                    }
                }

                if (enumGroup.EnumNames.Any())
                    enumGroups.Add(enumGroup);
            }

            foreach (var commandNode in xml.Descendants("command"))
            {
                var functionName = commandNode.Element("proto")?.Element("name")?.Value;

                if (functionName == null)
                    continue;

                var function = functions.SingleOrDefault(x => x.Name == functionName);

                if (function == null)
                    continue;

                foreach (var paramNode in commandNode.Elements("param").Where(x => x.Attribute("group") != null))
                {
                    var enumGroup = enumGroups.SingleOrDefault(x => x.Name == paramNode.Attribute("group").Value);

                    if (enumGroup == null)
                        continue;

                    var functionParam = function.Params.SingleOrDefault(x => x.Name == paramNode.Element("name").Value);

                    if (functionParam == null)
                        continue;

                    functionParam.EnumGroup = enumGroup;
                    enumGroup.IsInUse = true;

                    if (functionParam.Type != "GLenum")
                    {
                        if (functionParam.Type == "GLbitfield")
                        {
                            enumGroup.HasFlagsAttribtue = true;
                        }
                        else if (functionParam.Type == "GLint")
                        {
                            enumGroup.Type = "int";
                        }
                    }
                }
            }

            foreach (var enumGroup in enumGroups.Where(x => !x.IsInUse).ToArray())
            {
                Console.WriteLine($"Removing EnumGroup: {enumGroup.Name}.");
                enumGroups.Remove(enumGroup);
            }
        }

        private static void ParseHeaderFile(string[] lines, List<EnumData> enums, List<FunctionData> functions)
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

        private static void WriteEnumGroups(List<EnumGroupData> enumGroups, List<EnumData> enums)
        {
            StringBuilder sb = new StringBuilder(1024);

            sb.AppendLine("namespace GLDotNet");
            sb.AppendLine("{");

            foreach (var enumGroup in enumGroups.OrderBy(x => x.Name))
            {                                
                sb.AppendLine($"\t\tpublic enum {GetEnumGroupName(enumGroup)} : {enumGroup.Type}");
                sb.AppendLine("\t\t{");

                foreach (var enumName in enumGroup.EnumNames)
                {
                    var @enum = enums.SingleOrDefault(x => "GL_" + x.Name == enumName);

                    string name = GetEnumName(@enum.Name);
                    string value = @enum.Value;
                                                
                    sb.AppendLine($"\t\t\t{name} = {value},");
                }

                sb.AppendLine("\t\t}");
                sb.AppendLine();
            }

            sb.AppendLine("}");

            File.WriteAllText(@"..\..\Library\GLDotNet\GLEnums.Generated.cs", sb.ToString());
        }

        private static void Write(List<EnumGroupData> enumGroups, List<EnumData> enums, List<FunctionData> functions)
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

            var orderedFunctions = functions.OrderBy(x => x.Name);

            foreach (var function in orderedFunctions)
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

            foreach (var function in orderedFunctions)
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

                // removes the appended reference name (if it exists) for the generated code pointing to the openGL functions
                string glFunctionName = function.Name;
                string appendedName = "ByRef";
                if (glFunctionName.Contains(appendedName))
                {
                    glFunctionName = glFunctionName.Remove(glFunctionName.Length - appendedName.Length);
                }

                sb.AppendLine($"\t\t\t\tthis._{functionName} = (Delegates.{functionName})Marshal.GetDelegateForFunctionPointer(this.platformContext.GetProcAddress(\"{glFunctionName}\"), typeof(Delegates.{functionName}));");
            }

            sb.AppendLine("\t\t\t}");

            sb.AppendLine();
            sb.AppendLine("\t\t\tthis.Initialize();");

            sb.AppendLine("\t\t}");
            sb.AppendLine();

            foreach (var function in orderedFunctions.Where(x => x.OutputPublicMethod))
            {
                string returnType = GetReturnType(function.ReturnType);
                string functionName = GetFunctionName(function.Name);
                string parameters = null;
                string parameterNames = null;

                if (function.Params.Any(x => x.EnumGroup != null) && !function.DisableEnumGroupOverload)
                {
                    parameters = string.Join(", ", function.Params.Select(x => GetParamType(x, true) + " " + GetParamName(x.Name)));
                    parameterNames = string.Join(", ", function.Params.Select(x => GetParamInvoke(x.Name, x.TypePrefix, x.EnumGroup != null ? GetParamType(x) : null)));

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
                }

                parameters = string.Join(", ", function.Params.Select(x => GetParamType(x) + " " + GetParamName(x.Name)));
                parameterNames = string.Join(", ", function.Params.Select(x => GetParamInvoke(x.Name, x.TypePrefix)));

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

            File.WriteAllText(@"..\..\Library\GLDotNet\GL.Generated.cs", sb.ToString());
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

        private static string GetParamType(FunctionParamData param, bool useEnumGroup = false)
        {
            if (useEnumGroup && param.EnumGroup != null)
            {
                return GetEnumGroupName(param.EnumGroup, param.PointerCount > 0);
            }

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

        private static string GetEnumGroupName(EnumGroupData enumGroup, bool asArray = false)
        {
            string name = enumGroup.Name;

            if (name.EndsWith("ARB"))
                name = name.Substring(0, name.Length - "ARB".Length);

            if (asArray)
                name += "[]";

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
