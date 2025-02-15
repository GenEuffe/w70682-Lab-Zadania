
// Polimorfizm
/*
Zwierze zwierze = new Zwierze();

zwierze.Glos();

Kot kot = new Kot();
kot.Glos();
*/
/*
Figura figura = new Kolo(5);
Console.WriteLine("Pole Koła: " + figura.Pole());
Console.WriteLine("Obwód Koła: " + figura.Obwod());
*/
/*
Kwadrat kwadrat = new Kwadrat();
double bok = kwadrat.inputDouble();
kwadrat.View();

class Zwierze
{
    public virtual void Glos()
    {
        Console.WriteLine("Zwierze daje głos");
    }
}

class Kot(): Zwierze
{
    public override void Glos()
    {
        Console.WriteLine("Kot miauczy");
    }
}

// Klasy abstrakcyjne

abstract class Figura()
{
    public abstract double Pole();
    public abstract double Obwod();
    public void view()
    {
        Console.WriteLine("Figura: ");
    }
}

class Kolo : Figura
{
    double Promien { get; set; }

    public Kolo(double promien)
    {
        Promien = promien;
    }
        
    public override double Pole()
    {
        return Math.PI * Math.Pow(Promien, 2);
    }
    public override double Obwod()
    {
        return 2 * Math.PI * Promien;
    }
}

public interface IFigura
{
    void View();
    double inputDouble();
}

class Kwadrat: IFigura
{
    double bok;
    public double inputDouble()
    {
        Console.WriteLine("Podaj długość boku:");
        double bok = double.Parse(Console.ReadLine());
        return bok;
    }
    public void View()
    {
        Console.WriteLine("Kwadrat o boku: " + bok);
    }
}
*/

using ConsoleApp1;

Shape shape = new Circle();
shape.Draw();