//Pide al usuario las dimensiones de un rectángulo (base y altura) y calcula su área y perímetro.

    
        Console.WriteLine("Ingrese la base del rectángulo:");
        double baseRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del rectángulo:");
        double alturaRectangulo = Convert.ToDouble(Console.ReadLine());

        double area = baseRectangulo * alturaRectangulo;
        double perimetro = 2 * (baseRectangulo + alturaRectangulo);

        Console.WriteLine("El área del rectángulo es: " + area);
        Console.WriteLine("El perímetro del rectángulo es: " + perimetro);
    