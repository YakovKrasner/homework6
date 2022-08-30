Console.WriteLine("Прямая 1 задается уравнением y = k1*x + b1");
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble (Console.ReadLine ());

Console.WriteLine("Прямая 2 задается уравнением y = k2*x + b2");
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble (Console.ReadLine ());

Console.WriteLine ($"Координаты пересечения прямых следующие: [{(b2 - b1)/(k1 - k2)},{k1*((b2 - b1)/(k1 - k2))+b1}]"); // данная формула является математическим решением системы уравнений, задающих прямые 1 и 2
