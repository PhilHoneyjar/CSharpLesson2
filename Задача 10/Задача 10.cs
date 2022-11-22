//  Ввести трёхзначное число и показать вторую цифру этого числа

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string i = Convert.ToString(a);
Console.Write($"Вторая цифра этого числа: "+ i[1]);