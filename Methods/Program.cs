internal class Program
{
    private static void Main(string[] args)
    {
        //Add();
        //Add();
        //Add();
        //Add();
        //var result= Add2();
        //int number1;
        //int number2 = 100;
        //var result2=Add3(out number1 ,number2);
        //Console.WriteLine(result);
        //Console.WriteLine(result2);
        //Console.WriteLine(number1);
        Console.WriteLine(Multiply(2,4));
        Console.WriteLine(Multiply(2,4,5));
        Console.WriteLine(Add4(1,2,3,4,5));
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

    // Ref Keyword İle Çalışmak
    static int Add3(out int num1 , int num2 )
    {
        num1 = 30;
        return num1+num2;
    }

    //Method Overloading

    static int Multiply (int num1, int num2)
    {
        return num1 * num2;
    }

    static int Multiply(int num1, int num2,int num3)
    {
        return num1 * num2* num3;
    }

    // Params Keyword İle Çalışmak

    static int Add4(params int[] numbers )
    {
        return numbers.Sum();
    }




}