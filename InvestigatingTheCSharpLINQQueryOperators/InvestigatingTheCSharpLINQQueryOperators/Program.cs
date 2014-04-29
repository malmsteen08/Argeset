using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvestigatingTheCSharpLINQQueryOperators
{
    class Program
    {

        static void SelectEverything(ProductInfo[] products)
        { 
            //get everything
            Console.WriteLine("All product details : ");
            var allProducts = from p in products select p;

            foreach (var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
        }

        static void ListProductNames(ProductInfo[] products)
        {
            Console.WriteLine("Only Product Names:");
            var names = from p in products select p.Name;

            foreach (var n in names)
            {
                Console.WriteLine("Name : {0}", n);
            }
        }

        static void GetOverstock(ProductInfo[] products)
        {
            Console.WriteLine("The Overstock items!");

            //25 ten buyuk olan itemleri al
            var overstock = from p in products
                            where p.NumberInStock > 25
                            select p;
            foreach (ProductInfo c in overstock)
            {
                Console.WriteLine(c.ToString());
            }
        }

        static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("NAmes and Descriptions: ");
            var nameDesc = from p in products select new { p.Name, p.Description };

            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new { p.Name, p.Description };
            return nameDesc.ToArray();
        }
        static void GetCountFromQuery()
        {
            string[] currentVideoGames = { "Moroowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            //get count from query
            var numb = (from g in currentVideoGames where g.Length > 6 select g).Count();

            Console.WriteLine("{0} items honor the LINQ query.", numb);
        }

        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Product in reverse");
            var allProducts = from p in products select p;
            foreach (var prod in allProducts.Reverse())
            {
                Console.WriteLine(prod.ToString());
            }
        }

        static void AlphabetizeProductNames(ProductInfo[] products)
        {
            var subset = from p in products orderby p.Name select p;

            Console.WriteLine("Ordered by Name: ");
            foreach(var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }

        static void DisplayDiff()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carDiff = (from c in myCars select c)
                .Except(from c2 in yourCars select c2);

            Console.WriteLine("Here is what you dont have, but i do:");
            foreach (string s in carDiff)
            {
                Console.WriteLine(s);
            }
        }

        static void DisplayIntersection()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carIntersect = (from c in myCars select c)
                .Intersect(from c2 in yourCars select c2);

            Console.WriteLine("Here is what we have in common:");
            foreach (string s in carIntersect)
                Console.WriteLine(s);
        }

        static void DisplayUnion()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carUnion = (from c in myCars select c)
                .Union(from c2 in yourCars select c2);

            Console.WriteLine("Here is everything: ");
            foreach (string s in carUnion)
                Console.WriteLine(s);
        }

        static void DisplayConcat()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carConcat = (from c in myCars select c)
                .Concat(from c2 in yourCars select c2);

            //Yugo Aztec BMW BMW Saab Aztec
            foreach (var s in carConcat)
                Console.WriteLine(s);
        }

        static void DisplayConcatNoDups()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carConcat = (from c in myCars select c)
                .Concat(from c2 in yourCars select c2);
            
            //Yugo Aztec BMW Saab Aztec
            foreach (var s in carConcat)
                Console.WriteLine(s);
        }

        static void AggregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };

            Console.WriteLine("Max Temp: {0}", (from t in winterTemps select t).Max());
            Console.WriteLine("Min Temp : {0}", (from t in winterTemps select t).Min());
            Console.WriteLine("Avarage Temp : {0}", (from t in winterTemps select t).Average());
            Console.WriteLine("Sum of all temps: {0}", (from t in winterTemps select t).Sum());
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("** Fun With Query Expressions **\n");
            
            //örnekte kullanılacak temel diziyi tanımlıyoruz
            ProductInfo[] itemsInStock = new[] {
              new ProductInfo{ Name = "Mac's Coffee",Description = "Coffee with Teeth",NumberInStock = 24 },
              new ProductInfo{ Name = "Milk Maid Milk", Description = "Milk Cow's love", NumberInStock = 100},
              new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as possible", NumberInStock = 120 },
              new ProductInfo{ Name = "Cruchy Pops", Description = "Chezzy, peppery goodness", NumberInStock = 2},
              new ProductInfo{ Name = "RipOff Water" ,Description = "From the top to your wallet", NumberInStock = 100},
              new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves Pizza", NumberInStock = 73 }
            };

            Array objs = GetProjectedSubset(itemsInStock);
            foreach (object o in objs)
            {
                Console.WriteLine(o);//anonymous object ten ToString Fonks. çağırıyoruz
            }
            Console.ReadLine();
        }

    }
}
