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
                    CategoryName = "Информатика"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Макро икономика"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Микро икономика"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Екология"
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
                    ProductName = "Програмиране",
                    Description = "Програмирането е наука, която се занимава с методите и средствата за създаване на компютърни програми.",
                    ImagePath="image1.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Емоционална интелегентност",
                    Description = "Под емоционална интелигентност се разбира способността или умението да се възприемат, оценяват и управляват собствените емоции, да се разграничават различните емоции и да се назовават и определят правилно, както и да се използва емоционалната информация, за да бъдат ръководени чрез това мисленето и поведението .",
                    ImagePath="image2.jpg",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Фондови пазари",
                    Description = "Фондов пазар или капиталов пазар за търгуване на капитали или деривативи на споразумяна цена, това са финансови инструменти на списък на фондовата борса, както и онези, които са търгувани само частно.",
                    ImagePath="image3.jpg",
                    UnitPrice = 32.99,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Производителност на труда",
                    Description = "Производителността на труда е икономически показател за количеството стоки или услуги, създавани от единица труд.",
                    ImagePath="image4.jpg",
                    UnitPrice = 8.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Връзки с обществеността",
                    Description = "Връзки с обществеността е дейност по управление на информацията, свързана с публичния имидж на известни, публични личности, организации и програми.",
                                 
                    ImagePath="image5.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Опазване на околната среда",
                    Description = "Опазването на околната среда е човешка дейност за поддържане на устойчиво равновесие в биосферата.",
                    ImagePath="image6.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Разработка на софтуер",
                    Description = "Разработката на софтуер е разработването на софтуерен продукт съобразен с нуждите на дадена целева група или маркетинга на един софтуерен продукт.",
                    ImagePath="image7.jpg",
                    UnitPrice = 4.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Уеб дизайн",
                    Description = "Уеб дизайнът включва много и различни умения и дисциплини в производството и поддръжката на уебсайтове.",
                    ImagePath="image8.jpg",
                    UnitPrice = 2.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Потребление",
                    Description = "Потреблението е действието и резултата от ползването на дадена стока или услуга.",
                    ImagePath="image9.jpg",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Парична политика",
                    Description = "Паричната политика, наричана още монетарна политика, е упражняването на контрол върху количеството пари в икономиката и е едно от основните средства за макроикономическо регулиране.",
                    ImagePath="image10.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Икономика на труда",
                    Description = "Икономика на труда изследва заплащанията, наемането и динамика на трудовите пазари.",
                    ImagePath="image11.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Приложна екология",
                    Description = "Приложната екология се занимава с прилагането на екологичните знания на практика, за справяне с екологичните проблеми.",
                    ImagePath="image12.jpg",
                    UnitPrice = 29.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Социална екология",
                    Description = "Социалната екология е основен раздел на екологията, както и подраздел на екоикономиката.",
                    ImagePath="image13.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                         
            };

            return products;
        }
    }
}