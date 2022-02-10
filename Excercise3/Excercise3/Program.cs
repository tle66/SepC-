// See https://aka.ms/new-console-template for more information

//sfsdfsdfsdfsdfsd
using static System.Console;
WriteLine("Hello, World!");
LowHigh();
 static void fizzBuzz()
{
    for (int i = 1; i <= 100; i++)
    {
        if (i % 15 == 0)
        {
            Write("FizzBuzz\n");
        }
        else if (i % 5 == 0)
        {
            Write("Buzz\n");
        }
        else if (i % 3 == 0)
        {
            Write("Fizz\n");
        }
        else
        {
            Write(i + "\n");
        }

        if (i % 100 == 0) WriteLine();
    }
    WriteLine();
}


static void TestCode()
{
  
    
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            WriteLine(i);
        }
    
   
    
}

static void LowHigh() {
    Random r = new Random();
    int puzzle = r.Next(1, 4);
    WriteLine("Enter guess");
    int input = Convert.ToInt32(ReadLine());
    if (input>0 && input < 4)
    {
        if(input > puzzle)
        {
            WriteLine("High");
            return;
        }
        else if (input < puzzle)
        {
            WriteLine("Low");
            return;
        }
        else
        {
            WriteLine("Correct");
            return;
        }
    }
    else
    {
        WriteLine("Out of range");
        return;
    }

}
