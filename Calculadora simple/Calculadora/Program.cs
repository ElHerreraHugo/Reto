//Pide al usuario dos números 

        Console.WriteLine("Ingrese el primer numero:");
        double firstNumber = double.Parse(Console.ReadLine());

       
        Console.WriteLine("Ingrese el segundo numero:");
        double secondNumber = double.Parse(Console.ReadLine());

       // muestra el resultado
        Console.WriteLine("\n  El Resultados es:");

    //sumar, restar, multiplicar y dividir

        Console.WriteLine("en Suma  es: = {2}", firstNumber, secondNumber, firstNumber + secondNumber);

        Console.WriteLine("en  Resta es = {2}", firstNumber, secondNumber, firstNumber - secondNumber);

        Console.WriteLine("en Multiplicacion es = {2}", firstNumber, secondNumber, firstNumber * secondNumber);

        Console.WriteLine("en Divicion es = {2:0.00}", firstNumber, secondNumber, firstNumber / secondNumber); 
   