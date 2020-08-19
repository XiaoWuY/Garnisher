using System;
using System.Collections.Generic;
using System.Text;

namespace Garnisher.GarnisherTwo
{
    //领带
    public class Tie : Finery
    {
        public override void Show()
        {
            base.Show();
            Console.Write("领带  ");
        }
    }
}
