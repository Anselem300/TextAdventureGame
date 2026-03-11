# Overview

This project is designed to help me strengthen my skills as a software engineer by practicing basic programming concepts in C#. The goal is to set up a working development environment, write a simple program, and document the process.  

The software is a simple C# program that runs in the console and demonstrates basic programming functionality. The program allows the user to interact with a text-based adventure game where they can choose actions such as exploring, fighting monsters, resting to regain health, and managing items in their inventory. This demonstrates understanding of programming syntax, execution, and basic input/output.  

The purpose of creating this software is to establish a foundation for developing more complex programs in future modules, to learn best practices for documentation and version control, and to practice sharing code publicly on GitHub.

# Project Structure

TextAdventureGame
│
├── Program.cs # Entry point of the program
├── Game.cs # Contains game loop and main logic
├── Player.cs # Player class with inventory and status management
├── Monster.cs # Monster class and attack logic
├── Item.cs # Item struct representing healing items
└── Character.cs # Abstract class for shared behavior between Player and Monster  

[Software Demo Video](PASTE_YOUR_VIDEO_LINK_HERE)


# Features Demonstrated

* Variables, Expressions, and Conditionals  
* Loops for game and combat management  
* Functions/methods for actions such as `Explore()`, `FightMonster()`, `Rest()`, and `UseItem()`  
* Classes and Inheritance (`Character` abstract class, `Player` and `Monster` classes)  
* Structs (`Item`)  
* File I/O for saving game progress (`savegame.txt`)  
* Collections (`List<Item>` inventory)  

# How to Run

1. Make sure you have the **.NET SDK** installed on your system. You can download it from [Microsoft .NET Download](https://dotnet.microsoft.com/en-us/download).  
2. Open a terminal and navigate to the project folder (`TextAdventureGame`).  
3. Compile and run the program using:

```bash
dotnet run

# Development Environment

I used **Visual Studio Code** as my code editor and **Git** for version control. The project was developed on a Windows 10 Pro laptop.  

The programming language used is **C#**, which runs using the **.NET SDK** installed on my system and is executed through the terminal. The program is compiled and run from the command-line interface using the `dotnet run` command.  

# Useful Websites

* [C# Official Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/) – Reference for C# syntax and functions  
* [Stack Overflow](https://stackoverflow.com/) – Used for troubleshooting errors and learning coding best practices  
* [GitHub Docs](https://docs.github.com/) – Guidance on creating repositories and pushing code  
* [YouTube C# Tutorials](https://www.youtube.com/results?search_query=c%23+beginner+tutorial) – Helpful for understanding C# basics and coding examples

{Make a list of websites that you found helpful in this project}
* [BYU I Learn Material](https://byui-cse.github.io/cse310-ww-course/week01/activity_portfolio.html)
* [Microsoft .NET Download](https://dotnet.microsoft.com/en-us/download)