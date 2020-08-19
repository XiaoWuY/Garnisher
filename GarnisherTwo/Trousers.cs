using System;
using System.Collections.Generic;
using System.Text;

namespace Garnisher.GarnisherTwo
{
    // 长裤
    public class Trousers : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.Write("长裤  ");
        }
    }
}
