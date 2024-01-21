using System.Text.RegularExpressions;
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

            #region Generators Operators 

            /* var result = Enumerable.Range(0, 20);

             var r01 = Enumerable.Empty<Product>();

             var r02 = Enumerable.Repeat(3 , 10);

             var r03 = Enumerable.Repeat(ProductList[0] , 5);
 */


            #endregion



            List<string> nameLists = new List<string>()
            {
                "Ahmed Ali" , "Sally Samir" , "Ammar Gamal"
            };

            #region Select Many
            // output seq count > input seq count
            // transform each element in input seq to subseq (IEnumerable<>)

            /*var result = nameLists.SelectMany(FN => FN.Split(' '));

            // Query Syntax : use Multiple from to produce Select Many 

            result = from FN in nameLists
                     from SN in FN.Split(" ")
                     orderby SN.Length descending
                     select SN;

            var r01 = nameLists.SelectMany(SN => SN.ToCharArray());*/


            #endregion


            #region Casting Operators : Imediate Excution 
            /*
                        List<Product> unAvPrds = ProductList.Where(p => p.UnitsInStock == 0).ToList();

                        Product[] pArr = ProductList.Where(p => p.UnitsInStock != 0)
                                                    .OrderBy(p => p.UnitPrice).ToArray();

                        var result = ProductList.Where(p => p.UnitsInStock == 0)
                                                //.ToHashSet();
                                                //.ToDictionary(p => p.ProductID) // Dic <long , Product>
                                                //.ToDictionary(p => p.ProductID, p => new { p.ProductID, p.ProductName });
                                                // Dic <long , Anonymous [long,string]>
                                                //.ToLookup();
            */
            #endregion



            #region Set Operators 
            /*var seq01 = Enumerable.Range(0, 100); // 0 : 99
            var seq02 = Enumerable.Range(50, 100); // 50 : 99 ,, start from 50 and sum += 100

            var result = seq01.Union(seq02); // remove duplicates 

            result = seq01.Concat(seq02); // save duplicates 
            result = result.Distinct(); // remove duplicates

            result = seq01.Except(seq02);
            result = seq01.Intersect(seq02);

            foreach (var item in result)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();*/

            #region Index Range C# 8.0
            /*
            var lst1 = lst01.ToList();

            Console.WriteLine(lst1[0]);
            Console.WriteLine(lst1[^1]);
            Console.WriteLine(lst1[^5]);


            Range result = 1..^10;*/

            #endregion



            #endregion

            #region Quantifiers , return boolean

            /*Console.WriteLine(ProductList.Any()); // return true if input seq has atleast 1 element
*/
            // Console.WriteLine(ProductList.Any(p => p.UnitPrice > 200));
            // return true if input seq have atleast 1 element matches the condition

            // Console.WriteLine(ProductList.All(p => p.UnitsInStock > 0));
            // return true of all elements in input seq matches the conditions 

            /*var seq01 = Enumerable.Range(0, 100);
            var seq02 = Enumerable.Range(50, 100);

            Console.WriteLine( seq01.SequenceEqual(seq02));
*/




            #endregion


            #region Zip
            // input 2 seq , one combined o/p seq
            /*var lst02 = Enumerable.Range(0, 10);
            
            var result = nameLists.Zip(lst02 , (FN , i) => new {i , Name = FN.ToUpper()});*/


            #endregion

            #region Grouping

            /*var result = from p in ProductList
                         where p.UnitsInStock > 0
                         group p by p.Category
                         into prdGroups
                         where prdGroups.Count() >= 10
                         orderby prdGroups.Count() descending
                         select new { Category = prdGroups.Key, prdCount = prdGroups.Count() };

            result = ProductList.GroupBy(p => p.Category).Where(prdG => prdG.Count() >= 10)
                .OrderByDescending(pg => pg.Count())
                .Select(pg => new { Category = pg.Key, prdCount = pg.Count() });*/

            /*foreach ( var prdGroup in result ) {
                Console.WriteLine($"Group Key {prdGroup.Key}");

                *//*foreach(var prd in prdGroup )
                {
                    Console.WriteLine($".. {prd.ProductName}");
                }*//*
            }*/

            #endregion

            #region Let / Into - Introducing new Range Variable in Query Syntax

            List<string> Names = new List<string>()
            {
                "Ahmed" , "Aly" , "Samir" , "Mai" , "Sally" , "Moemen" , "Shimaa" , "Mohammed"
            };

            // Regular Expression
            /*var result = from N in Names
                         select Regex.Replace(N, "[aeiouAEIOU]", string.Empty)
                        // Restart Query with new range variable , Old Range Variable is not Accessable
                        into NoVol
                         where NoVol.Length >= 3
                         orderby NoVol, NoVol.Length descending
                         select NoVol;
*/
           var result = from N in Names
                     let NoVol = Regex.Replace(N , "[aeiouAEIOU]" , string.Empty)
                     where NoVol.Length >= 3
                     orderby NoVol , N.Length descending
                     select NoVol;

            #endregion



            
             foreach(var item in result)
             {
                 Console.WriteLine(item);
             }
            /*
            foreach(var item in r01)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in r03)
            {
                Console.WriteLine(item + " ");
            }*/




            Console.ReadKey();
        }
    }
}