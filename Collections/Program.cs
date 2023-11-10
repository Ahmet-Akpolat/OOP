using System.Threading.Channels;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Ahmet",
                "İbrahim",
                "Serap",
                "Büşra"
            };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            names = new string[5]; // Bu hareket newlediğimiz için names isminde farklı bir adres oluşturacaktır. Yani ilk oluşturduğumuz 4 elemanlı names string dizisine artık erişemeyeceğiz.
            names[4] = "Taha";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);

            List<string> namesList = new List<string>
            {
                "Ahmet",
                "İbrahim",
                "Serap",
                "Büşra"
            };
            Console.WriteLine(namesList[0]);
            Console.WriteLine(namesList[1]);
            Console.WriteLine(namesList[2]);
            Console.WriteLine(namesList[3]);
            namesList.Add("Taha");
            Console.WriteLine(namesList[4]);
            namesList.Add("Engin");
            Console.WriteLine(namesList[5]);
            Console.WriteLine(namesList[0]);
        }
    }
}