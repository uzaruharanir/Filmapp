using System;

namespace FilmappApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new FilmappContext())
            {
                Console.WriteLine("Enter Movie title");
                string title = Console.ReadLine();
                Console.WriteLine("Enter Movie category");
                string category = Console.ReadLine();
                Console.WriteLine("Enter Movie release year");
                string year = Console.ReadLine();
                db.Filmapps.Add(new Filmapptbl { title = title });
                db.Filmapps.Add(new Filmapptbl { year = year });
                db.Filmapps.Add(new Filmapptbl { category_name = category });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All Movies in database:");
                foreach (var Filmapptbl in db.Filmapps)
                {
                    Console.WriteLine("{0}{1}{2}", Filmapptbl.title, Filmapptbl.year, Filmapptbl.category_name);
                }
            }
        }
    }
}