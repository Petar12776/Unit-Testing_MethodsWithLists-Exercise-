# Unit-Testing_MethodsWithLists-Exercise
This repository contains a collection of Automated Unit Tests verifying the functionality and behaviour of methods with lists using NUnit. 

How To Run the Unit-Tests You can run all tests either from Visual Studio or the .NET CLI.

Option 1 - Using Visual Studio

   1. Open the solution or folder in Visual Studio.
   2. Build the solution to restore all dependencies.
   3. Open Test Explorer (Test > Windows > Test Explorer).
   4. Click Run All Tests or run specific tests as needed.

All test results will appear in the Test Explorer window.

Option 2 - Using the Command line If you have the .NET SDK installed, open a terminal in the project root and run the command: dotnet test

This will: Restore dependencies

Build both the main project and the test project

Execute all NUnit tests

Display results directly in the console

Framework and Tools - .NET 8.0, NUnit 3, NUnit3TestAdapter, Microsoft.NET.Test.Sdk, coverlet.collector (for code coverage),
