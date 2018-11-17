using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //委托使用方法一：模板方法
        
        static void Main(string[] args)
        {

            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Box box1 = wrapFactory.WrapProduct(func1);
            Box box2 = wrapFactory.WrapProduct(func2);

            Console.WriteLine(box1.Produt.Name);
            Console.WriteLine(box2.Produt.Name);

            Console.ReadLine();
        }
    }
    class Product
    {
        public string Name { get; set; }
    }
    class Box
    {
        public Product Produt { get; set; }
    }
    class WrapFactory
    {
        //模板方法
        public Box WrapProduct(Func<Product> getProduct)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            box.Produt = product;
            return box;
        }
    }
    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }

        public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            return product;
        }
    }
}
