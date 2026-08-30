using Advanced03Assimant.Task01;
using System.Net.Http.Headers;

namespace Advanced03Assimant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            //List < Product > catalog = ProductCatalog.GetCatalog();
            //Console.WriteLine("-------Electronics Products-----------");
            //List<Product> electronics = ProductSearcher.SearchProducts(catalog, p => p.Category == "Electronics");
            //foreach (Product p in electronics) 
            //{ 
            //       Console.WriteLine($"{p.Name} -${p.Price} (Stock:{p.Stock})");   
            //}
            //      Console.WriteLine();


            //Console.WriteLine("--------Under$50------------");
            //List<Product> under50 = ProductSearcher.SearchProducts(catalog, p => p.Price < 50);
            //foreach (Product p in under50)
            //{   
            //    Console.WriteLine($"{p.Name}- ${p.Price}- (Stock:{p.Stock})");

            //} 
            //Console.WriteLine() ;
            //Console.WriteLine("---------InStock------------");

            //    List<Product> instock = ProductSearcher.SearchProducts(catalog, p => p.Stock > 0);
            //    foreach (Product p in instock)
            //    {  
            //    Console.WriteLine($"{p.Name}- ${p.Price} -(Stock:{p.Stock})");
            //     }
            //        Console.WriteLine();

            //        Console.WriteLine("----------ClothingUnder$100-----------");

            //        List<Product> uder100 = ProductSearcher.SearchProducts(catalog, p => p.Price < 100);
            //foreach (Product p in uder100)
            //{
            //    Console.WriteLine($"{p.Name}- ${p.Price} -(Stock:{p.Stock})");
            //}



            #endregion

            #region Task03(1.3)
            //List<Product> catalog = ProductCatalog.GetCatalog();
            //Console.WriteLine("-------------Short Report-----------");
            //ProductSearcher.PrintReports(catalog, R => Console.WriteLine($"{R.Name} - ${R.Price}"));
            //Console.WriteLine();
            //Console.WriteLine("--------Detailed Report----------");
            //ProductSearcher.PrintReports(catalog, R => Console.WriteLine($"[{R.Category}] {R.Name} | Price: ${R.Price} | Stock: {R.Stock}"));

            #endregion

            #region Task03(2.3)
            //List<Product> catalog = ProductCatalog.GetCatalog();
            //Console.WriteLine("-------Summary List-----------");

            //List<string> summary = ProductSearcher.TransformProducts(catalog, S =>$"{S.Name} ${S.Price}");
            //foreach (string s in summary)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.WriteLine();

            //Console.WriteLine("-----------Price Labels-------------");
            //List<string> pricelabel = ProductSearcher.TransformProducts(catalog, S => $"{S.Name}: {(S.Price > 100 ? "Expensive!" : "Affordable")}");
            //    {
            //    foreach(string S in pricelabel)
            //    {
            //        Console.WriteLine(S);
            //    }
            //     }

            #endregion

            #region Task03(3.3)
            // List<Product> catalog = ProductCatalog.GetCatalog();
            // Console.WriteLine("---------Low-StockAlert---------------");
            //List<Product> lowstock=   ProductSearcher.FilterProducts(catalog, filter => filter.Stock < 20);
            // foreach (Product filter in lowstock)
            // {
            //     Console.WriteLine($"[LOW STOCK] {filter.Name}: only {filter.Stock} left!");
            // }


            // }

            #endregion
        }
    }
}




