//ax^2 + bx + c = 0
//x1 x2 delta

zadanie2();
void zadanie1()
{
    double a = DoubleInput();
    double b = DoubleInput();//ctrl + D
    double c = DoubleInput();
    double delta, x1, x2;
    if (a != 0)
    {
        delta = (Math.Pow(b, 2) - (4 * a * c));
        if (delta > 0)
        {
            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Dwa rozwiązania: x1 = {x1:F3}\tx2 = {x2:F3}");
        }
        else if (delta == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine($"Jedno rozwiązanie x1 = {x1:F3}");
        }
        else Console.WriteLine("Brak rozwiązania w zbiorze liczb rzeczywistych");
    }
    else Console.WriteLine("To nie jest równanie kwadratowe!");
}

double DoubleInput()
{
    Console.WriteLine("Podaj liczbe :");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

void zadanie2()
{
    bool activity = true;
    while (activity == true)
    {
        Console.WriteLine("====== KALKULATOR ======\n");
        Console.WriteLine("1. Suma\n2.Różnica\n3. Iloraz\n4. Iloczyn\n" +
            "5. Potęgowanie\n6. Pierwiastek z liczby\n7. Wartości funkcji trygonometrycznych\n8. Wyjście" +
            "\n========================");
        Console.WriteLine("Wybierz f--kcję: ");
        int menu_pick = Convert.ToInt32(Console.ReadLine());
        switch (menu_pick)
        {
            case 1: suma(); break;
            case 2: różnica(); break;
            case 3: iloraz(); break;
            case 4: Iloczyn(); break;
            case 5: Potęgowanie(); break;
            case 6: Pierwiastek(); break;
            case 7: trygonometria(); break;
            case 8: exit(); break;
            default:
                Console.WriteLine("Błądne dane, idioto. Spróbuj jeszcze raz. Idioto.");
                break;
        }
    }
}

void exit()
{
    Console.WriteLine("Koniec Linii.");
    System.Environment.Exit(0);
}

void trygonometria()
{
    double a = DoubleInput();
    Console.WriteLine("1. Sinus\n2. Cosinus\n3. Tangens\n4. Cotangens");
=-  int trig_pick = Convert.ToInt32(Console.ReadLine());
    switch (trig_pick)
    {
        case 1: Console.WriteLine($"Sinus {a} wynosi {Math.Sin(a)}."); break;
        case 2: Console.WriteLine($"Cosinus {a} wynosi {Math.Cos(a)}."); break;
        case 3: Console.WriteLine($"Tangens {a} wynosi {Math.Tan(a)}."); break;
        case 4: Console.WriteLine($"Cotangens {a} wynosi {Math.(a)}."); break; \\znaleźć f--kcję na cotangensa
    }
}

void Pierwiastek()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"pierwiastek z {a} o podstawie {b} wynosi {Math.Pow(a, (1 / b))}.");
}

void Potęgowanie()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"{a} do {b}-tej potęgi wynosi {Math.Pow(a, b)}.");
}

void Iloczyn()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Iloczyn {a} i {b} wynosi {a / b}.");
}

void iloraz()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Iloraz {a} i {b} wynosi {a * b}.");
}

void różnica()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Różnica {a} i {b} wynosi {a - b}.");
}

void suma()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Suma {a} i {b} wynosi {a + b}.");
}