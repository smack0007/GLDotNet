# GLDotNet

[OpenGL](https://www.opengl.org/) bindings for .NET.

## Usage

Use one of the following options:

* Compile the GLDotNet assembly using Visual Studio or MSBuild.
* Include [GL.cs](https://github.com/smack0007/GLDotNet/blob/master/Source/Library/GLDotNet/GL.cs) directly
  in your project.
  
Once an OpenGL context has been created and made current call GL.Initialize().
  
To create an OpenGL context consider using something like [GLFWDotNet](https://github.com/smack0007/GLFWDotNet).