using static LinqDay02.ListGenerators;


namespace LinqDay02
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Where - Filteration

            /*var result = ProductList.Where(p => p.UnitsInStock == 0);

            result = from p in ProductList
                     where p.UnitsInStock == 0
                     select p;



            result = ProductList.Where(p => (p.UnitsInStock == 0 && p.Category == "Meat/Poultry"));


            result = from p in ProductList
                     where p.UnitsInStock == 0 && p.Category == "Meat/Poultry"
                     select p;
            

            result = ProductList.Where ((p , i) => p.UnitsInStock == 0 && i <= 10);*/
            // Indexed where valid only in fluent syntax
            // Can't be written using query expression


            #endregion


            #region Select : Transformation Operator
            // Project\Transformation every Element in Input seq to a new output seq 
            // new datatype (or same datatype)

            /*var result = ProductList.Select(p => p.ProductName);
            // Product => string

            result = from p in ProductList
                     select p.ProductName;

            var result2 = ProductList.Where (p => p.UnitsInStock == 0)
                                .Select (p => new {Id = p.ProductID, p.ProductName});

            result2 = from p in ProductList
                      select new { Id = p.ProductID, p.ProductName };
            // Product => Anonymous Type 


            // Product => Product
            var discountedLst = ProductList.Select(p => new Product()
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Category = p.Category,
                UnitsInStock = p.UnitsInStock,
                UnitPrice = p.UnitPrice * 1.1M,

            });

            discountedLst = from p in ProductList
                            select new Product()
                            {
                                ProductID = p.ProductID,
                                ProductName = p.ProductName,
                                Category = p.Category,
                                UnitsInStock = p.UnitsInStock,
                                UnitPrice = p.UnitPrice * 1.1M

                            };

            // Indexed select , valid only in fluent syntax


            var result3 = ProductList.Where(p => p.UnitsInStock == 0)
                            .Select((p, i) => new { Index = i, Name = p.ProductName });


            var result4 = ProductList.Select(p => new { Name = p.ProductName, newPrice = p.UnitPrice * 1.1M })
                                 .Where(p => p.newPrice > 20);

            var r01 = ProductList.Select(p => new { Name = p.ProductName, newPrice = p.UnitPrice * 1.1M });
            var r02 = r01.Where(p => p.newPrice > 20);


            var rr01 = from p in ProductList
                       select new { Name = p.ProductName, newPrice = p.UnitPrice * 1.1M };

            var rr02 = from p in rr01
                       where p.newPrice > 20
                       select p;

            var rr = from p in ProductList
                     select new { Name = p.ProductName, newPrice = p.UnitPrice * 1.1M }
                     into taxedProd
                     where taxedProd.newPrice > 20
                     select taxedProd;*/




            #endregion


            #region Ordering Element

            /*var result = ProductList.OrderBy(p => p.UnitsInStock)
                          .Select(p => new { p.ProductName, p.UnitsInStock,p.UnitPrice });

            result = from p in ProductList
                     orderby p.UnitsInStock
                     select new { p.ProductName, p.UnitsInStock, p.UnitPrice };

            result = ProductList.OrderByDescending(p => p.UnitsInStock)
                          .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });

            result = from p in ProductList
                     orderby p.UnitsInStock descending
                     select new { p.ProductName, p.UnitsInStock, p.UnitPrice };

           result = ProductList.OrderBy(p => p.UnitsInStock)
                          .ThenBy(p => p.UnitPrice)
                          .Select(p => new { p.ProductName, p.UnitsInStock, p.UnitPrice });

            result = from p in ProductList
                     orderby p.UnitsInStock descending, p.UnitPrice descending
                     select new { p.ProductName, p.UnitsInStock, p.UnitPrice };*/



            #endregion


            #region Element - Imediate Execution
            // valid only in fluent syntax

            /*List<Product> discountedLst = new List<Product>(); // Empty Seq

            var result = ProductList.First();
            result = ProductList.Last();


            result = ProductList.First(p => p.UnitsInStock == 0);
            result = ProductList.Last(p => p.UnitsInStock == 0);

            result = discountedLst.First();
            // if input seq have no element it will throw exception
            // result = discountedLst.Last();

            result = discountedLst.FirstOrDefault();
            // return first element if existed , return default value if empty seq
            // no exception will be thrown
            // result = default(Product);
            result = discountedLst.LastOrDefault();


            // result = ProductList.First(p => p.UnitPrice > 300);
            // no element matching Predicate , throw exception

            result = ProductList.FirstOrDefault(p => p.UnitPrice > 300);
            result = ProductList.LastOrDefault(p => p.UnitPrice > 300);


            // Hybrid Syntax (Query expression).Fluent Syntax

            var r = (from p in ProductList
                     where p.UnitsInStock == 0
                     select new { p.ProductName, p.Category }).First();

            result = ProductList.ElementAt(17);
            // result = ProductList.ElementAt(300); // Exception
            result = ProductList.ElementAtOrDefault(300);

            discountedLst.Add(ProductList[0]);


            // result = ProductList.Single();
            result = discountedLst.Single();
            // return Single element in seq (Only one element in seq)
            // throw exception if empty or more than one element exists


            discountedLst.Clear();
            result = discountedLst.SingleOrDefault(); // return null , no exception will be thrown


            result = ProductList.Single(p => p.ProductID == 7);
            // throw exception if more than one element matches predicate or if no element matches predicate

            result = ProductList.SingleOrDefault(p => p.ProductID == 777);
            // result = ProductList.SingleOrDefault(p => p.UnitsInStock == 0);
            // throw exception if more than one element matches with predicate
            // return default if no elements matches with predicate


            Console.WriteLine(result?.ProductName?? "NA");*/






            #endregion


            #region Aggregate - Imediate Execution
            //var result = ProductList.Count();
            //result = ProductList.Count(p => p.UnitsInStock == 0);

            // var result = ProductList.Max();
            // return Product : Max (based on Icomparable\<T> Implementation) Product

            /* var result = ProductList.Max(p => p.UnitPrice);
             // Max unit price

             Product prd = ProductList.Min();
             result = ProductList.Min(p => p.ProductName.Length);

             var rslt = (from p in ProductList
                        where p.ProductName.Length == ProductList.Min(p => p.ProductName.Length)
                        select p).FirstOrDefault();
             Console.WriteLine(rslt?.ProductName?? "NA");

             Console.WriteLine(ProductList.Average(p => p.UnitsInStock));
             Console.WriteLine(ProductList.Sum(p => p.UnitsInStock));*/

            #endregion


            Console.ReadKey();
        }
    }
}