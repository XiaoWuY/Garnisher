using System;
using System.Collections.Generic;
using System.Text;

namespace Garnisher.GarnisherTwo
{
    //皮鞋
    public class Leather : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.Write("皮鞋  ");
        }
    }
}
