System.Console.WriteLine("Введите радиус круга: ");
double radius = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * Math.Pow(radius, 2);
System.Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);