using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

//应用最为广泛 
//事件的拥有者是事件响应者的一个字段成员
//事件响应者用自己的方法订阅自己成员的某个事件
namespace ConsoleApp5
{
    class Program
    {        
        static void Main(string[] args)
        {
            //事件的响应者
            MyForm myform = new MyForm();
            myform.ShowDialog();
        }
    }
    class MyForm : Form
    {
        private TextBox textBox;
        
        //事件的拥有者
        private Button button;

        public MyForm()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.Controls.Add(textBox);
            this.Controls.Add(button);

            //事件是click，订阅是 += 
            this.button.Click += this.ButtonClicked;
            this.button.Text = "click";
            this.button.Top = 50;
        }

        //事件的处理器
        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello world!";
        }
    }
}
