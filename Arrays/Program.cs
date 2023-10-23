internal class Program
{
    private static void Main(string[] args)
    {
        string[] students = new string[3] { "Ferit", "Seyma", "Sevval" };
        string[] students2 = { "Ferit", "Seyma", "Sevval" };
        // students2[3] = "Ali";
        
        foreach (var student in students2)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}