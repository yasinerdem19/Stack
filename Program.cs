


using System.Collections.Generic;
StackExample();
StackExample2();
StackExample3();

static void StackExample()
{
    //definition
    var karakterYigini = new Stack<char>();
    //https://theasciicode.com.ar/
    //add
    karakterYigini.Push('A');
    Console.WriteLine(karakterYigini.Peek());
    karakterYigini.Push('B');
    Console.WriteLine(karakterYigini.Peek());
    karakterYigini.Push('C');
    Console.WriteLine(karakterYigini.Peek());

    //REMOVE
    Console.WriteLine($"\n{karakterYigini.Pop()} REMOVED");
    Console.WriteLine($"{karakterYigini.Pop()} REMOVED");
    Console.WriteLine($"{karakterYigini.Pop()} REMOVED\n");
}

static void StackExample2()
{
    var karakterYigini = new Stack<char>();
    for (int i = 65; i <= 90; i++)
    {
        karakterYigini.Push((char)i);
    }
    foreach (var item in karakterYigini)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine($"\n{karakterYigini.Count} char exist");


    Console.WriteLine("Press any button to remove");
    Console.ReadKey();



    while (karakterYigini.Count > 0)
        Console.WriteLine($"{karakterYigini.Pop()} removed");

    Console.WriteLine($"\n{karakterYigini.Count} char exist");
}

static void StackExample3()
{
    Console.WriteLine("Enter a number: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    var sayiYigini = new Stack<int>();

    while (number1 > 0)
    {
        int k = number1 % 10;
        sayiYigini.Push(k);
        number1 /= 10;
    }

    int i = 0;
    int n = sayiYigini.Count - 1;


    foreach (var item in sayiYigini)
    {
        Console.WriteLine($"{item} x {Math.Pow(10, n - i),10} = {item * Math.Pow(10, n - i),10}");
        i++;
    }
}