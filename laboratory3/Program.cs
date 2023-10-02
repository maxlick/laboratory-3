using laboratory3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть довжину сторони 1 прямокутника: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Введiть довжину сторони 2 прямокутника: ");
        double side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

        Console.WriteLine();

        Point p1 = new Point(0, 0, "A");
        Point p2 = new Point(3, 0, "B");
        Point p3 = new Point(3, 4, "C");

        Figure triangle = new Figure(p1, p2, p3);
        triangle.CalculatePerimeter();

        Console.ReadLine();
    }
}