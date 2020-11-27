using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_shop_books.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Art"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Science"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Cooking"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Religion"
                },
               
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Painting art",
                    Description = "Painting is the practice of applying paint, pigment, color or other medium to a solid surface (called the 'matrix' or 'support').[1] The medium is commonly applied to the base with a brush, but other implements, such as knives, sponges, and airbrushes, can be used.",
                    ImagePath="image1.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Opera and ballet",
                    Description = "Ballet is a type of performance dance that originated in the Italian Renaissance courts of the 15th century and later developed into a concert dance",
                    ImagePath="image2.jpg",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Information Technology",
                    Description = "Information technology (IT) is the use of computers to store, retrieve, transmit, and manipulate data or information. IT is typically used within the context of business operations as opposed to personal or entertainment technologies.",
                    ImagePath="image3.jpg",
                    UnitPrice = 32.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Mediterranean cuisine",
                    Description = "Mediterranean cuisine is the foods and methods of preparation by people of the Mediterranean Basin",
                    ImagePath="image4.jpg",
                    UnitPrice = 8.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Balkan cuisine",
                    Description = "Balkan cuisine is a type of Mediterranean cuisine combining European with some Oriental characteristics",
                                 
                    ImagePath="image5.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Natural science",
                    Description = "Natural science is concerned with the description, prediction, and understanding of natural phenomena based on empirical evidence from observation and experimentation.",
                    ImagePath="image6.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Fashion and design",
                    Description = "Fashion design is the art of applying design, aesthetics and natural beauty to clothing and its accessories.",
                    ImagePath="image7.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Architecture",
                    Description = "Architecture (Latin architectura, from the Greek ἀρχιτέκτων arkhitekton 'architect', from ἀρχι- 'chief' and τέκτων 'creator') is both the process and the product of planning, designing, and constructing buildings or other structures.",
                    ImagePath="image8.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Social science",
                    Description = "Social science is concerned with society and the relationships among individuals within a society. ",
                    ImagePath="image9.jpg",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Formal science",
                    Description = "Formal science is involved in the study of formal systems. It includes mathematics, systems theory, and theoretical computer science.",
                    ImagePath="image10.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "European cuisine",
                    Description = "European or western cuisine is the cuisines of Europe and other Western countries, including the cuisines brought to other countries by European settlers",
                    ImagePath="image11.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Beliefs",
                    Description = "Traditionally, faith, in addition to reason, has been considered a source of religious beliefs.",
                    ImagePath="image12.jpg",
                    UnitPrice = 29.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Culture",
                    Description = "Culture and religion have usually been seen as closely related.",
                    ImagePath="image13.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                         
            };

            return products;
        }
    }
}