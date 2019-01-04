[![The MIT License](https://img.shields.io/badge/license-MIT-orange.svg?style=flat-square)](http://opensource.org/licenses/MIT)
[![Build Status](https://dev.azure.com/smack0007/Github/_apis/build/status/smack0007.GLDotNet?branchName=master)](https://dev.azure.com/smack0007/Github/_build/latest?definitionId=11?branchName=master)
[![BotBuilder Badge](https://buildstats.info/nuget/GLDotNet)](https://www.nuget.org/packages/GLDotNet/)  

# GLDotNet

[OpenGL](https://www.opengl.org/) bindings for .NET. Currently only tested / works on Windows but should be
fairly easy to make it work on other platforms. Pull requests are welcome.

## Usage

Use one of the following options:

* Use the [NuGet](https://www.nuget.org/packages/GLDotNet/) package.
* Include [GL.cs](https://github.com/smack0007/GLDotNet/blob/master/src/GLDotNet/GL.cs) directly
  in your project.
  
Once an OpenGL context has been created and made current call glInit().
  
To create an OpenGL context consider using something like [GLFWDotNet](https://github.com/smack0007/GLFWDotNet).
