using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Assessment_2
{
    public class Program
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} Name: {Name} Price: {Price} Author:{Author} Publisher:{Publisher}";
        }

    }
    public class Book : Program
    {
        List<Program> list = new List<Program>()
            {
                new Program{Id="B1",Name="fev",Price="400$",Author="MVN",Publisher="Ram"},
                new Program{Id="B2",Name="rgvef",Price="500$",Author="ABC",Publisher="Sita" },
                new Program{Id="B3",Name="rvtfvef",Price="40$",Author="ACD",Publisher="Laxmi"},
                new Program{Id="B4",Name="wrveb",Price="900$",Author="BVA",Publisher="Devi" },
                new Program{Id="B5",Name="ewrfet",Price="100$",Author="SSS",Publisher="Sita" },
            };
        /*void update()
        {
            var res = from c in list
                      where c.Id == "B2"  c.Price == "550$"
                      select c;
        }*/
        void display()
        {
            try
            {
                Console.WriteLine("Get book details from iD");
                string a = Console.ReadLine();
                var result = from m in list
                             where m.Id == a
                             select m;
                Console.WriteLine(result);
            }
            catch(Exception)
            {
                Console.WriteLine("ID not found in the list");
            }
            try
            {
                Console.WriteLine("Get book details from NAme");
                string b = Console.ReadLine();
                var result1 = from i in list
                              where i.Name == b
                              select i;
                Console.WriteLine(result1);
            }
            catch
            {
                Console.WriteLine("NAme not found in the list");
            }
            try
            {
                Console.WriteLine("Get book details from Author");
                string c = Console.ReadLine();
                var result2 = from j in list
                              where j.Author == c
                              select j;
                Console.WriteLine(result2);
            }
            catch
            {
                Console.WriteLine("Author not found in the list");
            }
            try
            {
                Console.WriteLine("Get book details from Author and Publisher");
                string d = Console.ReadLine();
                string e = Console.ReadLine();
                var result3 = from k in list
                              where k.Publisher == d && k.Author == e
                              select k;
                Console.WriteLine(result3);
            }
            catch
            {
                Console.WriteLine("Author or publisher not found in the list");
            }
            foreach (Program p in list)
            {
                Console.WriteLine(p.Id + " " + p.Name + " " + p.Price + " " + p.Author + " " + p.Publisher);
            }
        }
        static void Main()
        {
            Book ob = new Book();
            ob.display();
        }
    }
}



