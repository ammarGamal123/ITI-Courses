namespace Demo.Models
{
    public class ProductSampleData
    {
        private List<Product> products = new List<Product>();
        

        public ProductSampleData()
        {
            products.Add(new Product { 
                Id = 1,
                Name = "Iphone",
                Price = 3000m,
                Description = "Excellence",
                Image = "1.jpg"
            });

            products.Add(new Product
            {
                Id = 2,
                Name = "Samsung",
                Price = 2000m,
                Description = "Very Good",
                Image = "2.jpg"
            });

            products.Add(new Product
            {
                Id = 3,
                Name = "Xaiome",
                Price = 2200m,
                Description = "Very Good",
                Image = "3.jpg"
            });

            products.Add(new Product
            {
                Id = 4,
                Name = "Realme",
                Price = 1950m,
                Description = "Good",
                Image = "4.jpg"
            });

        }

        public List<Product> GetAll()
        {
            return products;
        } 
        
        public Product GetById(int id)
        {
            return products?.FirstOrDefault(p => p.Id == id);
        }
    }
}
