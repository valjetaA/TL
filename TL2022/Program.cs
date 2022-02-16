using TL2022;

class Program
{
    public static void Main(string[] args)
    {
        Point centerpoint = new Point
        {
            X = 10,
            Y = 10
        };

        try
        {
            Ellipse ellipse = new Ellipse(centerpoint, 3, 6);
            Console.WriteLine($"Площадь эллипса: {ellipse.GetSquare()}") ;
            Console.WriteLine($"Длина эллипса: {ellipse.GetLength()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}