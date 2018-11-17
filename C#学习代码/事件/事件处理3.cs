using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


//事件的拥有者和事件的响应者是同一个对象
namespace ConsoleApp5
{
    class Program
    {        
        static void Main(string[] args)
        {
            //事件的拥有者
            MyForm myform = new MyForm();
            myform.Click += myform.Action;
            myform.ShowDialog();
        }
    }
    class MyForm : Form
    {
        internal void Action(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
