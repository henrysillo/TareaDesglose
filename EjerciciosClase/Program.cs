static void desgloseSwitch()
{
    int CAN, C200, C100, C50, C20, C10, C5, op, can, c50, c25, c10, c5;
    CAN = C200 = C100 = C50 = C20 = C10 = C5 = 0;
    can = c50 = c25 = c10 = c5 = op = 0;
    string linea1, linea2;
    Console.WriteLine("1. Desglose de billetes y monedas");
    Console.WriteLine("Ingresa una opcion");
    op=int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Console.WriteLine("Ingrese una cantidad entera");
            linea1 = Console.ReadLine();
            CAN = Convert.ToInt32(linea1);
            Console.WriteLine("Ingrese la parte decimal de la cantidad anterior");
            linea2 = Console.ReadLine();
            can = Convert.ToInt32(linea2);
            Console.WriteLine($"Cantidad sin desglose: {CAN} {"."} {can} ");
            if ((CAN >= 200))
            {
                C200 = (CAN / 200);
                CAN = CAN - (C200 * 200);
            }
            if ((CAN >= 100))
            {
                C100 = (CAN / 100);
                CAN = CAN - (C100 * 100);
            }
            if ((CAN >= 50))
            {
                C50 = (CAN / 50);
                CAN = CAN - (C50 * 50);
            }
            if ((CAN >= 20))
            {
                C20 = (CAN / 20);
                CAN = CAN - (C20 * 20);
            }
            if ((CAN >= 10))
            {
                C10 = (CAN / 10);
                CAN = CAN - (C10 * 10);
            }
            if ((CAN >= 5))
            {
                C5 = (CAN / 5);
                CAN = CAN - (C5 * 5);
            }
            if ((can >= 50))
            {
                c50 = (can / 50);
                can = can - (c50 * 50);
            }
            if ((can >= 25))
            {
                c25 =(can / 25);
                can = can - (c25 * 25);
            }
            if ((can >= 10))
            {
                c10 = (can / 10);
                can = can - (c10 * 10);
            }
            if ((can >= 5))
            {
                c5 = (can / 5);
                can = can - (c5 * 5);
            }
            break;
          default:
            Console.WriteLine("Esa no es una opción válida");
            break;
    }
    Console.WriteLine("");
    Console.WriteLine("*** Estos son tus billetes ***");
    Console.WriteLine($"Billetes de 200 = {C200}");
    Console.WriteLine($"Billetes de 100 = {C100}");
    Console.WriteLine($"Billetes de 50 = {C50}");
    Console.WriteLine($"Billetes de 20 = {C20}");
    Console.WriteLine($"Billetes de 10 = {C10}");
    Console.WriteLine($"Billetes de 5 = {C5}");
    Console.WriteLine($"Billetes de 1 = {CAN}");
    Console.WriteLine("");
    Console.WriteLine("*** Estas son tus Monedas ***");
    Console.WriteLine($"Monedas de 50c = {c50}");
    Console.WriteLine($"Monedas de 25c = {c25}");
    Console.WriteLine($"Monedas de 10c = {c10}");
    Console.WriteLine($"Monedas de 5c = {c5}");
    Console.WriteLine($"Monedas de 1c = {can}");
}
static void desglose2()
{
    int CAN, C200, C100, C50, C20, C10, can, C5, c50, c25, c10, c5;
    CAN = C200 = C100 = C50 = C20 = C10 = C5 = can = 0;
    c50 = c25 = c10 = c5 = 0;
    string linea;

    decimal cantMoneda;
    decimal Cambio = 7.71m;

    Console.WriteLine("Ingrese una cantidad en dolares");
    linea = Console.ReadLine();
    cantMoneda = Convert.ToDecimal(linea);

    cantMoneda = (cantMoneda * Cambio);
    
    Console.WriteLine($"Cantidad sin desglose: {linea} ");
    Console.WriteLine($"Cantidad en Quetzales. {cantMoneda}");

    CAN = Convert.ToInt32(Math.Truncate(cantMoneda));
    cantMoneda = (cantMoneda - CAN) * 100;
   
    //Billetes

    if ((CAN >= 200))
    {
        C200 = (CAN / 200);
        CAN = CAN - (C200 * 200);
    }
    if ((CAN >= 100))
    {
        C100 = (CAN / 100);
        CAN = CAN - (C100 * 100);
    }
    if ((CAN >= 50))
    {
        C50 = (CAN / 50);
        CAN = CAN - (C50 * 50);
    }
    if ((CAN >= 20))
    {
        C20 = (CAN / 20);
        CAN = CAN - (C20 * 20);
    }
    if ((CAN >= 10))
    {
        C10 = (CAN / 10);
        CAN = CAN - (C10 * 10);
    }
    if ((CAN >= 5))
    {
        C5 = (CAN / 5);
        CAN = CAN - (C5 * 5);
    }
    can = Convert.ToInt32(cantMoneda);

    //Monedas
    
    if ((can >= 50))
    {
        c50 = (can / 50);
        can = (can - (c50 * 50));
    }
    if ((can >= 25))
    {
        c25 = (int)(can / 25);
        can = (can - (c25 * 25));
    }
    if ((can >= 10))
    {
        c10 = (int)(can / 10);
        can = (can - (c10 * 10));
    }
    if ((can >= 5))
    {
        c5 = (int)(can / 5);
        can = (can - (c5 * 5));
    }
    Console.WriteLine("");
    Console.WriteLine("*** Estos son tus billetes ***");
    Console.WriteLine($"Billetes de 200 = {C200}");
    Console.WriteLine($"Billetes de 100 = {C100}");
    Console.WriteLine($"Billetes de 50 = {C50}");
    Console.WriteLine($"Billetes de 20 = {C20}");
    Console.WriteLine($"Billetes de 10 = {C10}");
    Console.WriteLine($"Billetes de 5 = {C5}");
    Console.WriteLine($"Billetes de 1 = {CAN}");
    Console.WriteLine("");
    Console.WriteLine($"*** Estas son tus Monedas ***");
    Console.WriteLine($"Monedas de 50c = {c50}");
    Console.WriteLine($"Monedas de 25c = {c25}");
    Console.WriteLine($"Monedas de 10c = {c10}");
    Console.WriteLine($"Monedas de 5c = {c5}");
    Console.WriteLine($"Monedas de 1c = {can}");
}
desglose2();