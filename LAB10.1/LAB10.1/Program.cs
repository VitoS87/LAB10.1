using System.Runtime.CompilerServices;

Console.Write("Введите координату x: ");
double x = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату y: ");
double y = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число c: ");
double c = double.Parse(Console.ReadLine()!);
Area area = new Area(x, y, c);
area.Print();
class Perimetr
{
    private double X;
    private double Y;
    public Perimetr(double X, double Y)
    {
        this.X = X;
        this.Y = Y;
    }
    public double getX() { return X; }
    public double getY() { return Y; }
    public double getP()
    {
        return 2 * X + 2 * Y;
    }
    public void Print()
    {
        Console.WriteLine($"Периметр прямоугольника: {getP()}");
    }
}
class Area : Perimetr
{
    private double C;
    public Area(double _X,double _Y, double _C) : base (_X, _Y)
    {
        this.C = _C;
    }
    public double getS()
    {
        return (C + getX()) * (C + getY());
    }
    public new void Print()
    {
        Console.WriteLine($"Площадь прямоугольника: {getS()}");
    }
}
