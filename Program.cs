internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nhap chieu rong hinh chu nhat");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("nhap chieu cao hinh chu nhat");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine("chu vi hinh chu nhat la {0}", (width+height)*2);
        Console.WriteLine($"Dien thich hinh chu nhat la {width*height}");
    }
}