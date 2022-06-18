class Calculator
{
    static void Main()
    {
        bool nonStop = true; //Set a boolean to run the program nonstop until
        while (nonStop) //user quits out of program
        {
            Console.Clear();
            Console.WriteLine("Press Ctrl + C to quit at any time"); //Useful info for user
            Console.WriteLine(); //Separate first two lines of printed output
            Console.WriteLine("Enter first value");
            int x = Int32.Parse(Console.ReadLine()); //Reads first value & converted to int
            Console.WriteLine("Please enter maths operator e.g. + or - or * or % or ^ or %");
            char calc = ' '; //Setting calc to 'white space' to help program run
            bool flag = true;
            char[] values = { '+', '-', '*', '/', '^', '%' }; //Array of acceptable values
            while (flag) //While boolean is true
            {
                calc = char.Parse(Console.ReadLine()); //Converting char
                for (int i = 0; i < values.Length; i++) //Loops through checking value of char
                {
                    if (calc == values[i])
                    {
                        flag = false;
                    }
                }
            }
            Console.WriteLine("Enter second value");
            int y = Int32.Parse(Console.ReadLine()); //Reads second value & converted to int
            double z = 0; //Declaring variable integer
            switch (calc) //Switch for all six operators
            {
                case '+':
                    z = x + y;
                    Console.ForegroundColor = ConsoleColor.Blue; //Setting foreground colour
                    Console.BackgroundColor = ConsoleColor.Gray; //Setting background colour
                    Console.Write("The answer is ");
                    break;
                case '-':
                    z = x - y;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("The answer is ");
                    break;
                case '*':
                    z = x * y;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write("The answer is ");
                    break;
                case '/':
                    z = x / y;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Write("The answer is ");
                    break;
                case '^':
                    z = Math.Pow(x, y);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write("The answer is ");
                    break;
                case '%':
                    z = x % y;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("The answer is ");
                    break;
            }
            Console.WriteLine(z); //Couldn't determine why Console.WriteLine("The answer is ", z);
            //wouldn't work. So split the answer to Console.Write("The answer is ");
            //to make it on the same line by adding Console.WriteLine(z).
            Console.WriteLine("Press any key to continue"); //This puts a break in the code else
            Console.ReadLine(); //line 8 clears console before you can read ther answer
        }
    }
}