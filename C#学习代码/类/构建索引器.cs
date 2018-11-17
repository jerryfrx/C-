//索引器一般情况下都在集合类型下，这里使用不规范

using System;
using System.Collections.Generic;

namespace ConsoleApp {
    class Program {
        public static void Main(string[] args ) {
            Student stu = new Student();
            stu["math"] = 90;
            stu["physical"] = 100;
            var score = stu["math"];
            Console.WriteLine(score);
        }
    }
    class Student {
        private Dictionary<string,int> scoreDic = new Dictionary<string, int>();
        public int? this[string subject] {
            get {
                if ( this.scoreDic.ContainsKey(subject) ) {
                    return scoreDic[subject];
                }
                else {
                    return null;
                }
            }
            set {
                if(value.HasValue == false  ) {
                    throw new Exception();
                }
                if ( this.scoreDic.ContainsKey(subject) ) {
                    scoreDic[subject] = value.Value;
                }
                else {
                    scoreDic.Add(subject,value.Value);
                }
            }
        }
    }
}