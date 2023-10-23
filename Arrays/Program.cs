internal class Program
{
    private static void Main(string[] args)
    {
        //string[] students = new string[3] { "Ferit", "Seyma", "Sevval" };
        //string[] students2 = { "Ferit", "Seyma", "Sevval" };
        //// students2[3] = "Ali";

        //foreach (var student in students2)
        //{
        //    Console.WriteLine(student);
        //}
        //Console.WriteLine();

        // Çok Boyutlu Diziler

        string[,] regions = new string[5, 3]
        {
            {"Istanbul", "Izmit", "Balikesir" },
            { "Ankara", "Konya", "Kirikkale" },
            { "Antalya", "Adana", "Mersin" },
            {"Rize", "Trabzon", "Samsun" },
            {"Izmir", "Mugla", "Manisa" }
            
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i, j]);
            }
            Console.WriteLine("**********");
        }

            Console.ReadLine();
    }
}