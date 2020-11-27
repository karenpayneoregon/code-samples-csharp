# About Format package listing

Execute in Package manager console: **Get-Package | ft -AutoSize** then run this project to get a formatted GitHub markdown table suitable for a readme.md file.

- Currently list packages for VB.NET or C#
- Export part is still under development as the format has not been decided e.g. should it be HTML, CSV, Markdown table or options for all by selection say in a ComboBox.

> This version does not fully work with VS2019, In VS2019, those .net core projects or .net standard projects use [PackageReference](https://docs.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files) 
> instead of [packages.config](https://docs.microsoft.com/en-us/nuget/reference/packages-config) format to manage nuget packages.

### Supported project types

![screen0](../assets/NuGetPackagehelperLanguages.png)

> Test with conventional .NET and .NET 5/.NET Core

### Current screenshot



This was done against the following VS2019 solution using .NET 5 and EF Core 5

![screenshot](../assets/NuGetPackagehelper.png)

This was done against the following VS2017 solution using .NET 4.7.2, EF Core 3.x

![screen1](../assets/NuGetPackagehelper2017.png)

### Download 
Create a batch file with the following and process.

```batch
mkdir code
cd code
git init
git remote add -f origin https://github.com/karenpayneoregon/code-samples-csharp
git sparse-checkout init --cone
git sparse-checkout add NuGetPackageHelpers
git pull origin master
:clean-up
del .gitattributes
del .gitignore
del .yml
del .editorconfig
del *.md
del *.sln
```