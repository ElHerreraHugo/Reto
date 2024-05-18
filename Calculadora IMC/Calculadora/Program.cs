
//Calculadora de IMC (Indice de masa corporal)


Console.WriteLine("Ingrese su  Peso [Kg]");
float Peso=float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su  Altura [m]");
float Altura = float.Parse(Console.ReadLine());


float imc = Peso / (Altura * Altura);
Console.WriteLine("su IMC es:" + imc);


if  (40 < Peso && Altura == 1.60)
{
    Console.WriteLine("Uste esta Bajo Peso");
}


else if (( Peso >= 18.5) && (Altura<= 24.9))
{
    Console.WriteLine("Uste tiene un peso Normal");
   
}

else if ((Peso <= 25) && (Altura <= 30))
{
    Console.WriteLine("Uste esta Sobre Peso");
   
}

else
Console.WriteLine("Uste tiene un peso de obesida");



