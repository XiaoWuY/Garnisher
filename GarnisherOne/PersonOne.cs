using System;
using System.Collections.Generic;
using System.Text;

namespace Garnisher.GarnisherOne
{
    public class PersonOne
    {
        public string Name { get; set; }
        //待添加功能的Show方法，具体组件中的Show方法只有原始功能
        public  void Show()
        {
            Console.Write($"打扮的人是{this.Name}："); 
            Console.Write("大t恤  ");
            Console.Write("网鞋  ");
        }
    }
}
