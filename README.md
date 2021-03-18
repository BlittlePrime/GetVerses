# GetVerses

This application is designed for Windows to run in Visual Studio 2019

Installation Instructions

Setup the Database (recommended)

copy the versefavorites.db to your c: directory

OR from Visual Studio 2019

Open EFGetVerses.sln in the EfGetVerses folder in Visual Studio 2019
Go to Tools->NuGet Package Manager->Package Manager Console
At the PM> prompt enter these three commands

Install-Package Microsoft.EntityFrameworkCore.Tools
Add-Migration InitialCreate
Update-Database

This will create a SQLLite database file by the name of versefavorites.db on your root C drive which you will need for the application

Run the Web Application

From the command line (recommended)

From the GetVerses/GetVerses folder where the GetVerses.csproj file resides simply type "dotnet run"
Using Chrome go to localhost:5001

From Visual Studio directly

Open the GetVerses.sln in the GetVerses folder into Visual Studio 2019

Hit F5 or the IIS Express button to run the application


