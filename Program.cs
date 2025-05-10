internal class Program
{
    private static void Main(string[] args)
    {
        //int height = 6;
        //int width = 4;
        Console.Write("Nhập chiều dài: ");
        int height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập chiều rộng: ");
        int width = Convert.ToInt32(Console.ReadLine());

        int areaOfRectangle = height*width;
        Console.WriteLine("Diện tích hình chữ nhật là " + areaOfRectangle);
    }
}