using TP6;

Console.WriteLine("Indique un valor con el cual trabajar: ");
double oper = Convert.ToDouble(Console.ReadLine());
Calculadora numero = new Calculadora(oper);
string lpr = "S";

while (lpr == "S")
{
    Console.WriteLine("\nIndique la operacion deseada: \n1.Suma\n2.Resta\n3.Multiplicacion\n4.Division");
    int eleccion = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("\nIndique el valor por el que desea operar: ");
    double term = Calculadora.Solicitar();
    switch (eleccion)
    {
        case 1: numero.Sumar(term); break;
        case 2: numero.Restar(term); break;
        case 3: numero.Muktiplicar(term); break;
        case 4: numero.Dividir(term); break;
        default: Console.WriteLine("Error"); break;
    }
    numero.Mostrar();
    
    Console.WriteLine("Desea realizar otra operacion? S/N");
    lpr = Console.ReadLine();
    if(lpr != "N")
    {
        lpr = "S";
    }
}