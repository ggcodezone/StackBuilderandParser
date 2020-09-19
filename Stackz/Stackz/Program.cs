using System;
using System.Collections;

namespace Stackz
{ //Name: Stack Builder and Parser
    //Author: Gwen Kalasky
    //Synopsis: Used to create a stack and populate it with random integers. Then you can search for instances of a specific number.
    //Date: 9/17/20

    class Program
    {
        static void Main(string[] args)
        {
            Stack theStack = new Stack();
            int Min = 1; //sets the minimum and maximum values for the generated numbers (they wont exceed max, wont be under min)
            int Max = 300;

            // this declares an integer array (you can set the number of elements you want in the brackets next to "new int"
            // initializes all of them to their default value which is zero
            int[] numbergen = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < numbergen.Length; i++)
            {
                numbergen[i] = randNum.Next(Min, Max); 
            }
            theStack.Push(randNum); // This is the part where I was trying to push all the contents of the array to the stack, but I tried various things and nothing worked so far.

            Console.WriteLine(theStack); // I want to test if the stack was populated with the numbers

            //after this, I want to do an if else, so when it's going down the stack, if a number is not the specified value, pop it 
            //if it *is* the specified number i'll peek it. So it will display only all the items that match the search 
            //I saw online someone use peek with a stack in C#. I'm thinking to try it out here to help me generate the report.

           if (theStack.Contains(""))
                {
                Console.WriteLine("We found an instance of your desired number.");
                    theStack.Pop();
                //code to execute if condition is true (console write "found an instance of ____" then pop.)
            }
           else
            {
                theStack.Pop();
                //code to execute if condition is false (pop item with theStack.Pop)
            }

            //how do you ensure it does every item in the index, do you loop it somehow?

       
        }
    }
}
