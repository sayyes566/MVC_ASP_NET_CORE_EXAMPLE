# MVC_ASP_NET_CORE_EXAMPLE
asp.net core 2.2 example with mongoDB

#### Install ASP.NET Core 2.2 on ubuntu


wget -q https://packages.microsoft.com/config/ubuntu/16.04/packages-microsoft-prod.deb
$ sudo dpkg -i packages-microsoft-prod.deb
$ sudo apt-get install apt-transport-https
$ sudo apt-get update
$ sudo apt-get install dotnet-sdk-2.2

#### Create a MVC or API
https://docs.microsoft.com/zh-tw/dotnet/core/tools/dotnet-new?tabs=netcore20
$ dotnet new mvc -o BookStore
dotnet new <TEMPLATE> [--force] [-i|--install] [-lang|--language] [-n|--name] [-o|--output] [-u|--uninstall] [Template options]
dotnet new <TEMPLATE> [-l|--list] [--type]
dotnet new [-h|--help]


####Install MongoDB and Driver
....
https://www.nuget.org/packages/mongodb.driver
dotnet add package MongoDB.Driver --version 2.8.0


##### ${Project}.csproj 


<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>netcoreapp2.2</TargetFramework>
    <AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel>
     <PublishWithAspNetCoreTargetManifest>false</PublishWithAspNetCoreTargetManifest>

  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.App" />
    <PackageReference Include="MongoDB.Driver" Version="2.8.0" />
  </ItemGroup>

</Project>



#####Release
$ dotnet publish -c release
$ cp -r  bin/release/netcoreapp2.2/publish/* /var/www/
