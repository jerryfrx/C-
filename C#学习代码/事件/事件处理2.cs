using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ConsoleApp5
{
    class Program
    {        
        static void Main(string[] args)
        {
            //事件的拥有者
            Form form = new Form();
            //事件的响应者
            Controller controller = new Controller(form);
            form.ShowDialog();

            Console.ReadLine();
        }
    }
    class Controller
    {
        private Form form;
        public Controller(Form _form)
        {
            if(_form != null)
            {
                this.form = _form;
                //click 事件
                //订阅
                //为form的click事件添加事件处理器
                //this代表的就是Controller的实例
                this.form.Click += this.FormClicked;
            }
        }

        //事件处理器
        private void FormClicked(object sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
