# BlazoredLocalisation
A library to provide localisation in client-side Blazor applications

[![NuGet](https://img.shields.io/nuget/v/BlazoredLocalisation.svg?style=flat-square)](https://www.nuget.org/packages/BlazoredLocalisation/)

### Installing

You can install from Nuget using the following command:

`Install-Package BlazoredLocalisation`

Or via the Visual Studio package manger.

### Setup

You just need to add `app.UseBrowserLocalisation();` in your _startup.cs_ file as per the example below.

```c#
public void Configure(IBlazorApplicationBuilder app)
{
    app.UseBrowserLocalisation();
    app.AddComponent<App>("app");
}
``` 

This will set the `CultureInfo.CurrentCulture` and `CultureInfo.CurrentUICulture` for your Blazor application based on the language settings of the clients browser.