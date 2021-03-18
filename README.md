# GetVerses

This application is designed for Windows to run in Visual Studio 2019

Installation Instructions

Setup the Database

Open EFGetVerses.sln in the EfGetVerses folder in Visual Studio 2019
Go to Tools->NuGet Package Manager->Package Manager Console
At the PM> prompt enter these three commands

Install-Package Microsoft.EntityFrameworkCore.Tools
Add-Migration InitialCreate
Update-Database

This will create a SQLLite database file by the name of versefavorites.db on your root C drive which you will need for the application

Run the Web Application

From Visual Studio directly

Open the GetVerses.sln in the GetVerses folder into Visual Studio 2019
Hit F5 or the IIS Express button to run the application

From the command line

// currently in progress


From IIS

//currently in progress

install the ASP.Net Core 5.0 from here if you haven't already done so

https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-aspnetcore-5.0.4-windows-hosting-bundle-installer

