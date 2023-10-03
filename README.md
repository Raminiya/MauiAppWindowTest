# MauiAppWindowTest
A simple test project to see why closing secondary windows creates unhandled Exceptions

While developing an application I faced the following Issue:
After Openeing a second Window if the window is closed using the close button on the title bar, specially when the window is not in the forground,
an unhandled exception is raised.

This project is the most simple form of code that can reproduce the same issue.

It is a standard new .net maui Visual Studio App.
A Simple csharp test page named TestPage that only has one lable has been added to the project.
A window Property named MyWin has been added to the MainPage Class.
This Window property is initialized in the MainPage Constructor to show the TestPage.
Each time the button on the MainPage is pressed the program will Open the new Window if it's not oppened and close it if it's oppened.

Thats all.

It will still cause the same issue.
