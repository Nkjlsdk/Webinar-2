// Программа  принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int number = new Random().Next(1,7);
if (number <=5)
{
    Console.WriteLine($"{number} - нет");
    }
else
{
    Console.WriteLine($"{number} - да");
}

