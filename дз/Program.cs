try
{
    Console.WriteLine("Введите переменную a:");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите переменную y:");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите переменную x:");
    double x = double.Parse(Console.ReadLine());
    double J = Math.Pow(1 / Math.Tan(Math.Pow(a, 3)), 3) + Math.Pow(Math.Atan(a), 2 ) / Math.Pow(Math.Tan(x), 1);
    Console.WriteLine("J =" + J);
}      
catch
{
    Console.WriteLine("Не правильно вел данные");
}

