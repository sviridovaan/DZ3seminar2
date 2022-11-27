//напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли это день выходным
Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 6 | number == 7)
{
    Console.WriteLine("Данный день недели является выходным");
}
else 
{
    if (number >=1 & number <=5)
    {
        Console.WriteLine("Данный день недели не является выходным");
    }
    else
    {
        Console.WriteLine("Вы ввели несуществующий день недели. Введите число от 1 до 7");
    }
    
}