[![NuGet Badge](https://buildstats.info/nuget/WebAPI.FSharp.Template)](https://www.nuget.org/packages/WebAPI.FSharp.Template)
[![Build Status](https://travis-ci.org/MNie/FSharpNetCoreWebApiTemplate.svg?branch=master)](https://travis-ci.org/MNie/FSharpNetCoreWebApiTemplate)

# F# ASP.NET Core Web Api Template
# How to use it?
* fork and download repository
* install template as a .net core template from nuget
* install template as a .net core template locally

# How to install it as a template from nuget?
* run `dotnet new -i WebAPI.FSharp.Template::*`
* create new project executing `dotnet new webapi -lang F# -n PROJECT_NAME -o FOLDER_NAME`

# How to install it as a template locally?
* download repository
* run command `dotnet new -i PATH*`, where *PATH* is a path to a folder where project is located
* create new project executing `dotnet new webapi -lang F# -n PROJECT_NAME -o FOLDER_NAME`
* `dotnet restore`
* `dotnet run` or `dotnet watch run`

# How it works?
* `dotnet run`
![dotnet run](http://i.imgur.com/NoMYhLh.gif)
* `dotnet watch run`
![dotnet watch run](http://i.imgur.com/TyOM0WR.gif)

If you want to extend this template, or create more complex one based on this, don't hold back :)
