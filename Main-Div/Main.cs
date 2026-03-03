using System;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace BeginnerFriendly{
public interface CHash{    //Creates an interface
    string ProgramName { get;}
    void Execute();
}
    //Creates two variables that are compulsory for a class to have in order to be accessible by the interface
class MainMachine{ //class that has the main function
static void Main()
    {
        var Programs = new Dictionary<int, CHash> //following dictionary contains list of all classes for each program 
        {
            { 1, new EvenorOdd()},
            {2, new OddRange()},
            {3, new IdentifyNum()},
            {4, new LargerNum()},
            {5, new SwapNum()},
            {6, new DivbyTwo()},
            {7, new AddMul()},
            {8, new Seventeen()}
        };
        while (true) //code reruns in a loop
        {
            Console.Clear();
            Console.WriteLine("-------------------C# Program Menu-------------------");
            foreach (var item in Programs)
            {
                Console.WriteLine($"{item.Key}. {item.Value.ProgramName}");  //$ allows us to write variables into strings enclosed between parenthesis
            }
            Console.WriteLine("0. Exit");
            Console.Write("Select Option: ");
            if(!int.TryParse(Console.ReadLine(), out int choice))continue;
            if (choice==0) //if user selects 0, it exits and returns to main menu
            break;
            if(Programs.TryGetValue(choice, out CHash selectedProgram)) //if user selects a number, it responds with its corresponding program
            {
                Console.Clear();
                selectedProgram.Execute();
            }
            else
            {
                Console.WriteLine("Invalid choice!"); //to prevent string values leading to errors
            }
            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine(); //user returns to main menu
        }
    }
}
}