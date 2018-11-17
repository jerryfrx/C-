using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//完整事件声明流程，模拟餐馆点菜流程
//1.首先定义事件的拥有者Customer
//2.为Customer声明点菜事件（1.首先声明委托类型，根据参数声明数据类型-谁点菜、点什么菜 2.拿委托类型声明委托事件）
//   事件是基于委托的--事件需要使用委托类型来做约束、能够记录或引用方法只有委托实例才能做到
//3.声明事件Order
//4.声明事件的响应者
//5.订阅事件
namespace ConsoleApp17 {
    class Program {
        static void Main( string[] args ) {
            Customer customer =new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayTheBill();
        }
    }
    //按照约定名称定义为：事件名称+EventArgs
    //点菜信息
    public class OrderEventArgs : EventArgs {
        public string DishName { get; set; }
        public string Size { get; set; }

    }
    //第一个参数表明是谁点的菜
    //第二个参数是存储点菜的信息的
    public delegate void OrderEventHandler( Customer customer,OrderEventArgs e );
    public class Customer {
        //事件的简要声明
        //public event OrderEventHandler order;
        /* if(this.orderEventHandler != null ) {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "potato";
                e.Size = "small";
                this.orderEventHandler.Invoke(this,e);
            }
         * 改成
         * if(this.order != null ) {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "potato";
                e.Size = "small";
                this.order.Invoke(this,e);
            }*/

        //事件完整声明
        //用来存储和引用事件处理器
        private OrderEventHandler orderEventHandler;
        //声明事件，希望被外界访问所以用public，关键字event，用OrderEventHandler这个委托类型来约束事件
        public event OrderEventHandler Order{
            //事件处理器的添加器，value代表外界传进来的OrderEventHandler
            add {
                this.orderEventHandler += value;
            }
            //移除器
            remove{
                this.orderEventHandler -= value;
            }
        }
        public double Bill { get; set; }//账单
        public void PayTheBill() {
            Console.WriteLine("I will pay ${0}",this.Bill);
        }
        //触发事件
        public void WalkIn() {
            Console.WriteLine("Walk into the restaurant");
        }
        public void SitDown() {
            Console.WriteLine("Sit down");
        }
        public void Think() {
            for ( int i = 0;i < 5;i++ ) {
                Console.WriteLine("let me think...");
                Thread.Sleep(1000);
            }
            if(this.orderEventHandler != null ) {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "potato";
                e.Size = "small";
                this.orderEventHandler.Invoke(this,e);
            }
        }
        public void Action() {
            this.WalkIn();
            this.SitDown();
            this.Think();
        }
    }
    //声明事件响应者
    public class Waiter {
        internal void Action( Customer customer,OrderEventArgs e ) {
            Console.WriteLine("I will serve you dish-{0}",e.DishName);
            double price = 10;
            switch ( e.Size ) {
                case "small":
                    price = price;
                    break;
                case "medium":
                    price = price + 10;
                    break;
                case "large":
                    price = price + 20;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
        }
    }
}