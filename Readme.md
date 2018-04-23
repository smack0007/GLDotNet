[![The MIT License](https://img.shields.io/badge/license-MIT-orange.svg?style=flat-square)](http://opensource.org/licenses/MIT)
![Build Status](https://smack0007.visualstudio.com/_apis/public/build/definitions/fe242154-6494-46a8-aecf-f6146774ff5b/4/badge)

# GLDotNet

[OpenGL](https://www.opengl.org/) bindings for .NET.

## Usage

Use one of the following options:

* Compile the GLDotNet assembly using Visual Studio or MSBuild.
* Include [GL.cs](https://github.com/smack0007/GLDotNet/blob/master/src/GLDotNet/GL.cs) directly
  in your project.
  
Once an OpenGL context has been created and made current call GL.Initialize().
  
To create an OpenGL context consider using something like [GLFWDotNet](https://github.com/smack0007/GLFWDotNet).
