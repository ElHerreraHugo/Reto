
        Console.WriteLine("Ingrese el día de su nacimiento:");
        int dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el mes de su nacimiento:");
        string mes = Console.ReadLine().ToLower(); 

       
        string zodiacSign = "";

        if (mes == "marzo")
        {
            if (dia >= 21)
            {
                zodiacSign = "Aries";
            }
            else
            {
                zodiacSign = "Piscis";
            }
        }
        else if (mes == "abril")
        {
            if (dia >= 20)
            {
                zodiacSign = "Tauro";
            }
            else
            {
                zodiacSign = "Aries";
            }
        }

        if (zodiacSign != "")
        {
            Console.WriteLine("\nSu signo zodiacal es: " + zodiacSign);
        }
        else
        {
            Console.WriteLine("Fecha de nacimiento inválida.");
        }
    
