// Console.WriteLine("Hello, what's your name?");

// Console.ReadLine();

// Console.WriteLine("My name is Duong.\nWhat is your favorite colour?");

// Console.ReadLine();

// Console.WriteLine("Cool!");


// Console.WriteLine("What is your name?");

// var userName = Console.ReadLine();

// Console.WriteLine("Hello " + userName + ", nice to meet you!");


// double num01;
// double num02;
// double num03;

// Console.Write("Input a number: ");

// num01 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input a second number: ");

// num02 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Input a third number: ");

// num03 = Convert.ToDouble(Console.ReadLine());

// double avg = (num01 + num02 + num03) / 3;

// Console.WriteLine("The average number is " + avg);


// Console.WriteLine("Welcome! Tickets are $5. Please insert cash.");

// int cash = Convert.ToInt32(Console.ReadLine());

// if (cash < 5)
// {
//     Console.WriteLine("That's not enough money.");
// }
// else if (cash == 5)
// {
//     Console.WriteLine("Here is your ticket.");
// }
// else
// {
//     int change = cash - 5;
//     Console.WriteLine("Here is your ticket and $" + change + " change.");
// }


// Console.WriteLine("How many powers of 2 do you want?: ");

// int count = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= count; i++)
// {
//     double result = Math.Pow(2, i);
//     Console.WriteLine(result);
// }


// Random numberGen = new Random();

// int roll = 0;
// int attempts = 0;

// Console.WriteLine("Press enter to roll the die.");

// while (roll != 6)
// {
//     Console.ReadKey();
//     roll = numberGen.Next(1, 7);
//     Console.WriteLine("You rolled: " + roll);
//     attempts++;
// }

// Console.WriteLine("You took " + attempts + " attempts to roll a 6!");


Random numberGen = new Random();

int roll1 = 0;
int roll2 = 1;
int attempts = 0;

Console.WriteLine("Press enter to roll two dice.");

while (roll1 != roll2)
{
    Console.ReadKey();
    roll1 = numberGen.Next(1, 7);
    roll2 = numberGen.Next(1, 7);
    Console.WriteLine("You rolled " + roll1 + " and " + roll2);
    attempts++;
}

Console.WriteLine("You took " + attempts + " attempts to roll two identical numbers!");