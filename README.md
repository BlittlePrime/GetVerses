# GetVerses

This application is designed for Windows

Installation Instructions

simple version

download this project as a zip from the Code button and extract it or clone it

copy the versefavorites.db from the folder to your c: directory
open the command line and navigate to where you extracted the folder
type "getverses" and enter to run the getverses.bat file.  This will load the web server.

(note: if you get the message "It was not possible to find any installed .NET Core SDKs" then you will need to install it from here
 https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-3.1.407-windows-x64-installer)

Using Chrome go to https://localhost:5001



---
Long Version

Setup the Database 

	(recommended method)
	
		copy the versefavorites.db to your c:\ directory

	OR 
	
	from Visual Studio 2019

		Open EFGetVerses.sln in the EfGetVerses folder in Visual Studio 2019
		Go to Tools->NuGet Package Manager->Package Manager Console
		At the PM> prompt enter these three commands

		Install-Package Microsoft.EntityFrameworkCore.Tools

		Add-Migration InitialCreate

		Update-Database

		This will create a SQLLite database file by the name of versefavorites.db on your root C drive which you will need for the application


Run the Web Application


	(recommended method)

		From the command line 
		
			(recommended method)

				open the command line 
				right click on the command line icon on the taskbar, go to Command Prompt and right click on that and click on Run as an Administrator
				In the new, elevated command line navigate to where you extracted the folder
						
				type "getverses" and enter to run the getverses.bat file.

			OR

				From the GetVerses/GetVerses folder where the GetVerses.csproj file resides simply type "dotnet run"
				
				This will load the web server

				(note: if you get the message "It was not possible to find any installed .NET Core SDKs" then you will need to install it from here
				 https://dotnet.microsoft.com/download  either 5.0 or 3.1 should work)

			Using Chrome, go to https://localhost:5001

	OR
		From Visual Studio directly

			Open the GetVerses.sln in the GetVerses folder into Visual Studio 2019

			Hit F5 or the IIS Express button to run the application


