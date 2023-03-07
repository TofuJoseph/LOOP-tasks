int en = 8, uzunluq = 12;
Console.WriteLine("Fiqurun uzunluğunu qeyd edin :");
uzunluq = int.Parse(Console.ReadLine());
Console.WriteLine("Fiqurun enin qeyd edin :");
en = int.Parse(Console.ReadLine());
for (int I = 1; I <= uzunluq; I++)

{
    Console.WriteLine();
    for (int j = 1; j <= uzunluq; j++)
    {
        Console.Write(".");

    }
}
