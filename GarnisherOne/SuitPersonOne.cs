using System;
using System.Collections.Generic;
using System.Text;

namespace Garnisher.GarnisherOne
{
    // 穿西装的人
    public class SuitPersonOne : PersonOne
    {
        public void Show()
        {
            base.Show();
            Console.Write("西装  ");
        }

    }
}
