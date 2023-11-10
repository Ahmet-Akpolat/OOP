namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names1 = new MyList<string>();
            names1.Add("Ahmet");
            Console.WriteLine(names1.Lenght);
            names1.Add("İbrahim");
            Console.WriteLine(names1.Lenght);

            foreach (var name in names1.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}