# Generate Random List Web Application

This is an ASP.Net Core Web Application. <br/>
The program generates a list of 10,000 numbers in random order each time it is run. <br/>
Each number in the list is unique and is between 1 and 10,000 (inclusive).

## Build

- The App is built in Visual Studio 2015. <br/>
- NuGetPackage Manager is used to install .Net Core 1 package. <br/>    
- Bower Manager - to add font awsome dependency. <br/>
- Bootstrap toolkit - to design responsive system. <br/>

## Logic in short

The system creates an array containing numbers of the range and another array with dynamically created random double numbers.<br/>
Then the first array is sorted by the random values of the second.<br/>
The application visualizes the sorting results by rendering the numbers as colors on the web page.<br/>

The solution implements responsive design and mobile-first strategy.

## TDD Application

It is a TDD application using xUnit.<br/><br/>
The system should pass the following tests:<br/>
- All numbers must be unique;<br/>
- All numbers must be in the range of 1 - 10000 inclusive;<br/>
- Element color must be a valid RGBA string.
