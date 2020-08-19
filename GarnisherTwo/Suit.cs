using System;
using System.Collections.Generic;
using System.Text;

namespace Garnisher.GarnisherTwo
{
    //西装
    public class Suit : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.Write("西装  ");
        }
    }
}
