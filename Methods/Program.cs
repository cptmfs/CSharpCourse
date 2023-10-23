internal class Program
{
    private static void Main(string[] args)
    {
        Add();
        Add();
        Add();
        Add();
       var result= Add2(20,30);
        Console.WriteLine(result);
        Console.ReadLine();
    }
    static void Add()
    {
        Console.WriteLine("Added!!!");
    }
    //Parametreli Metotlarla Çalışmak
    static int Add2(int num1, int num2)
    {
        var result =num1+ num2; 
        return result;
    }
}