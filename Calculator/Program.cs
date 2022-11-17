// See https://aka.ms/new-console-template for more information

using System.Net.NetworkInformation;

using System.Windows;



//if statements -when to use, syntax in c# (i.e. show Sam Console output after doing 4 IF statements)

/*

 

// Type your username and press enter

Console.WriteLine("Would you like to Add, Subtract, Multiply or Divide?:");

Console.WriteLine("Enter Add, Subtract, Multiply, or Divide?:");

 

// Create a string variable and get user input from the keyboard and store it in the variable

string answer = Console.ReadLine().ToString(); // A or S

 

// Print the value of the variable (userName), which will display the input value

Console.WriteLine("You Chose: " + answer);

 

if (answer == "A")

{

    Console.WriteLine("Input Letter Chose is A - Addition");

}

else if (answer.ToUpper() == "S")

{

    Console.WriteLine("Input Letter Chose is S - Subtract");

}

else if (answer == "M")

{

    Console.WriteLine("Input Letter Chose is M - Multiply");

}

else if (answer == "D")

{

    Console.WriteLine("Input Letter Chose is D - Divide");

}*/



class Calc

{



    //Hello Francis
    static void Main()

    {

        // Type your username and press enter

        Console.WriteLine("Would you like to Add, Subtract, Multiply or Divide?:");

        Console.WriteLine("Enter Add, Subtract, Multiply, or Divide?:");



        // Create a string variable and get user input from the keyboard and store it in the variable

        string answer = Console.ReadLine().ToString(); // A or S



        // Print the value of the variable (userName), which will display the input value

        Console.WriteLine("You Chose: " + answer);





        Console.WriteLine("Enter Input1?:");

        int input1 = Convert.ToInt32(Console.ReadLine());







        Console.WriteLine("Enter Input2?:");

        int input2 = Convert.ToInt32(Console.ReadLine());





        Calc myCalc = new Calc();

        int haha = Convert.ToInt32(myCalc.Execute(input1, input2, answer.ToUpper()));



        Console.WriteLine("Ta freakin da:" + haha.ToString());

    }



    private int Execute(int input1, int input2, string action)



    {

        int ansMyVar = 0;



        if (action == "A")

            ansMyVar = input1 + input2;

        else if (action == "S")

            ansMyVar = input1 - input2;

        else if (action == "M")

            ansMyVar = input1 * input2;

        else if (action == "D")

            ansMyVar = input1 / input2;





        return ansMyVar;

    }

}



class GGMU

{



}

