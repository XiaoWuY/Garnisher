using System;
using System.Collections.Generic;
using System.Text;

namespace Garnisher.GarnisherOne
{
    // 穿大t恤的人
    public class TShirtPersonOne: PersonOne
    {
        public void Show()
        {
            base.Show();
            Console.Write("大t恤  ");
        }
    }
}
