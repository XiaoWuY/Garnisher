using System;
using System.Collections.Generic;
using System.Text;

namespace Garnisher.GarnisherTwo
{
    // 网鞋
    public class Sneaker : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.Write("网鞋  ");
        }
    }
}
