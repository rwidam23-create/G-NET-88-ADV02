using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced03Assimant.Task01
{
    internal class ProductSearcher
    {
        //// Used Func<Product, bool> because we need to check each product
        //// against a condition and get a true/false result back.

        ////    public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> condition)
        ////    {
        ////        List<Product> result = new List<Product>();
        ////        foreach (Product p in products)
        ////        {
        ////            if (condition.Invoke(p))
        ////            {
        ////                result.Add(p);
        ////            }
        ////        }
        ////        return result;
        ////    }
        ////}

        //// Used Action<Product> because we only need to perform an action
        //// (printing) on each product without returning any value.
        ////public static void PrintReports(List<Product> products,Action<Product> action) 
        ////{
        ////    List<Product> result = new List<Product>();
        ////    foreach (Product R in products)
        ////    {
        ////        action.Invoke(R);
        ////    }


        ////}
        //// Used Func<Product, string> because we need to transform each
        //// product into a new value (a string) and return it
        ////public static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
        ////{
        ////    List<string> result = new List<string>();
        ////    foreach (Product S in products)
        ////    {
        ////        result.Add(transform.Invoke(S));



        ////    }return result;
        ////}

        //// Used Predicate<Product>, C#'s built-in delegate for conditions,
        //// to filter products matching a given condition.
        ////    public static List<Product> FilterProducts(List<Product> products,Predicate<Product> predicate)
        ////    {
        ////       List<Product> result= new List<Product>();
        ////        foreach(Product filter in products)
        ////        {
        ////            if (predicate.Invoke(filter))
        ////            {
        ////                result.Add(filter);
        ////            }
        ////        } return result;
        ////    }
    }
}
    
