static int suma(int v1, int v2)
{
    int calc = v1 + v2;
    return calc;
}

static int resta(int v1, int v2)
{
    int calc = v1 - v2;
    return calc;
}
static int multiplicacion(int v1, int v2)
{
    int calc = v1 * v2;
    return calc;
}

static int division(int v1, int v2)
{
    int calc = v1 / v2;
    return calc;
}

static void calculadora(int select, int a, int b)
{
    switch (select)
    {
        case 1:
            Console.WriteLine("Resultado: " + suma(a, b));
            break;
        case 2:
            Console.WriteLine("Resultado: " + resta(a, b));
            break;
        case 3:
            Console.WriteLine("Resultado: " + multiplicacion(a, b));
            break;
        case 4:
            Console.WriteLine("Resultado: " + division(a, b));
            break;
    }
}

static void menu()
{
    Console.Write("Que tipo de calculo desea realizar?\n\nSuma: ingresar 1\nResta: ingresar 2\nMultiplicacion: ingresar 3\nDivision: ingresar 4\n\n");
    int usr_select = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el 1er numero: ");
    int usr_a = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el 2do numero: ");
    int usr_b = int.Parse(Console.ReadLine());

    calculadora(usr_select, usr_a, usr_b);
}










menu();