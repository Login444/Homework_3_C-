Console.WriteLine("Давайте найдем расстояние между точками A и B в трехмерном пространстве.");
        Console.WriteLine("Укажите значения координат точки A: ");
        Console.WriteLine("X: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Y: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Z: ");
        double z1 = Convert.ToDouble(Console.ReadLine());
    
        Console.WriteLine("Укажите значения координат точки B: ");
        Console.WriteLine("X: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Y: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Z: "); 
        double z2 = Convert.ToDouble(Console.ReadLine());
        double v = Math.Sqrt(Math.Pow((x2 - x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
        Console.WriteLine($"Расстояние между точками A и B равно: {v:f2}");