// Ввести число и показать его третью цифру, либо сообщить что третьей цифры нет.

Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
string i = Convert.ToString(a);

    if (i.Length > 2)
    {
        Console.Write("Третья цифра этого числа: "+ i[2]);
    }
    else 
    {
        Console.Write("Третья цифра отсутствует");
    }