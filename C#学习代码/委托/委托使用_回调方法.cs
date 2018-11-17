using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //委托使用方法二：回调方法
        
        static void Main(string[] args)
        {

            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Logger logger = new Logger();
            Action<Product> log = new Action<Product>(logger.Log);
         


            Box box1 = wrapFactory.WrapProduct(func1,log);
            Box box2 = wrapFactory.WrapProduct(func2,log);

            Console.WriteLine(box1.Produt.Name);
            Console.WriteLine(box2.Produt.Name);

            Console.ReadLine();
        }
    }
    //记录程序运行状态
    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product '{0}' created at {1}.Price is {2}",product.Name,DateTime.UtcNow,product.Price);
        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class Box
    {
        public Product Produt { get; set; }
        
    }
    class WrapFactory
    {
        //回调方法
        public Box WrapProduct(Func<Product> getProduct,Action<Product> logCallback)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            if(product.Price > 50)
            {
                logCallback.Invoke(product);
            }
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
            product.Price = 20;
            return product;
        }

        public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            product.Price = 100;
            return product;
        }
    }
}
