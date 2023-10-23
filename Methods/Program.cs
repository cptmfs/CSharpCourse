internal class Program
{
    private static void Main(string[] args)
    {
        Add();
        Add();
        Add();
        Add();
       var result= Add2();
        Console.WriteLine(result);
        Console.ReadLine();
    }
    static void Add()
    {
        Console.WriteLine("Added!!!");
    }
    //Parametreli Metotlarla Çalışmak
    static int Add2(int num1=20, int num2 = 30)
    {
        var result =num1+ num2; 
        return result;
    }


}