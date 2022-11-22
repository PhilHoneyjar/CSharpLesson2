// Ввести номер дня недели и проверить является ли он выходным

Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

    if (a == 6 || a == 7)
    {
        Console.WriteLine("Это выходной день");
    }
    else if (a >= 1 && a <= 5)
    {
        Console.WriteLine("Это будний день");
    }
    else
    {
        Console.WriteLine("Введен некорректный номер");
    }