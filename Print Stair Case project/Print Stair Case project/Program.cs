using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    /* To complete this challenge I will need to figure out how to print
    n as a number of steps of a staircase. There are x elements involved
    1. The number of steps (n)
    2. The number of white space or (spaces)
    3. The number of (#) involved in eachstep, each step having a different amou
    4. Printing either (spaces} or (#)
    5.I need a storage value to put all the (#) and spaces, so that
    I can print the correct string to Console
    
    I'm guessing step 2 - 4 can be done with using a for loop
    Perhaps a for loop for both the blank space and pound symbol*/

    static void staircase(int nSteps)
    {
        //Storage value for our Console string
        string stringContent = "";
        int currentStep = 0;

        for (int steps = 0; steps < nSteps; steps++)
        {
            for(int spaces = nSteps -1; spaces > currentStep; spaces--)
            {
                stringContent += " ";
            }

            //Print the correct amount of (#)
            for (int content = 0; content <= currentStep; content++)
            {
                stringContent += "#";
            }
            Console.WriteLine(stringContent);
            stringContent = "";
            currentStep++;
        }
    }

            //Print the spaces needed for each step
            //Start at the number of spaces needed by taking the
            //nSteps int, we than print that number of spaces into
            //our string, finally decrement the spaces loc var
           /* for (int spaces = nSteps - 1; spaces > 0; spaces--)
            {
                stringContent += " ";
            }*/

static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
