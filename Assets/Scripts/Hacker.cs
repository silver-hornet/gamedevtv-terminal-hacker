using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game state
    int level;
    enum Screen {  MainMenu, Password, Win };
    Screen currentScreen;

    void Start()
    {
        ShowMainMenu(); // This is calling a method with no parameters
    }

    void ShowMainMenu() // This is an example of encapsulation. We're encapsulating all these statements into one method.
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?" + "\n");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA" + "\n");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    // According to the C# naming convention, the On prefix indicates that something is part of an event meaning it gets called automatically when an event happens.
    // Unsurprisingly, our message is named OnUserInput indicating that it is part of an event. The event is: The user typed something.
    {
        print("The user typed " + input);

        if (input == "menu") // we can always go direct to main menu
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1") // The 1-3 options could problably be handled within a for loop
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }

        else if (input == "dance party")
        {
            Terminal.WriteLine("!!@@##$$%%^^&&**(())");
        }
        else
        {
            Terminal.WriteLine("Please choose a valid option");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen " + level);
        Terminal.WriteLine("Please enter your password: ");
    }
}
