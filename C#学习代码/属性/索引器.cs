using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

//索引器indexer
namespace ConsoleApp5
{
    class Program
    {        
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu["Math"] = 90;
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore);
            Console.ReadLine();
        }
    }
    class Student
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();

        //索引器
        public int? this[string subject]
        {
            get
            {
                if (scoreDictionary.ContainsKey(subject))
                {
                    return this.scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(value.HasValue == null)
                {
                    throw new Exception("Score cant be null!");
                }
                if (scoreDictionary.ContainsKey(subject))
                {
                    this.scoreDictionary[subject] = value.Value;
                }
                else
                {
                    this.scoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }
}