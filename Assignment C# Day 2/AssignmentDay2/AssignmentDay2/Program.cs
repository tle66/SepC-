// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Main();
static void Main() {
    int length = 10;
    int[] numbers = GenerateNumbers(length);
    PrintNumbers(numbers);

    Reverse(numbers);
    Console.WriteLine("Reverse");
    PrintNumbers(numbers); 
}
static int [] GenerateNumbers(int length)
{
    int[] numArray = new int [length];
    Random randNum = new Random();
    for (int i = 0; i < 10; i++)
    {
        numArray[i] = randNum.Next();
    }
    return numArray;
}
static void Reverse(int [] numbers)
{
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        int tmp = numbers[i];
        numbers[i] = numbers[numbers.Length - i - 1];
        numbers[numbers.Length - i - 1] = tmp;
    }
}
static void PrintNumbers(int [] numbers)
{
    for(int i =0;i< numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}
