// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using Internal;

static void Main(string[] args)
{
    FizzBuzz(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });
    
}

static void FizzBuzz(int[] array)

{

    for (int i = 0; i < array.Length; i++)
    {

        //'fizz' for numbers divisible by 3 and 5

        if (array[i] % 3 == 0 && array[i] % 5 == 0)
        {
            Console.WriteLine("fizzbuzz");
        }
        //'buzz' for numbers divisible by 5

        else if (array[i] % 5 == 0)
        {
            Console.WriteLine("buzz");
        }
        //'fizzbuzz' for numbers divisible by 3 

        else if (array[i] % 3 == 0)
        {
            Console.WriteLine("fizz");
        }
        else
        {
            Console.WriteLine($"{array[i]}");
        }

    }
    
}