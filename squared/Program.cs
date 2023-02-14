Console.WriteLine("Возведение числа в квадрат");
Console.WriteLine("Пожалуйста, введите число и мы возведем его в квадрат");

int number = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введено число " + number);

int result = (int) Math.Pow(number, 2);
Console.WriteLine("Квадрат числа " + number + " есть число " + result);