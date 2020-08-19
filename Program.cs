using Garnisher.GarnisherOne;
using Garnisher.GarnisherTwo;
using System;

namespace Garnisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PersonOne personOne = new PersonOne() { Name = "小黑" };
            personOne.Show();

            Console.WriteLine();
            SuitPersonOne suitPersonOne = new SuitPersonOne() { Name = "小黑" };
            suitPersonOne.Show();
            Console.WriteLine();

            TShirtPersonOne shirtPersonOne = new TShirtPersonOne() { Name = "小黑" };
            shirtPersonOne.Show();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("==============================");

            // 首先要有打扮的人
            AbstractPerson xiaoXin = new Person() { Name = "小新"};
            // 然后准备要穿的衣服
            Finery personWithSuit = new Suit(); // 西装
            Finery personWithTie = new Tie();  // 领带
            Finery personWithTrousers = new Trousers(); // 长裤
            Finery personWithLeather = new Leather();  // 皮鞋
            // 最后按顺序把衣服穿上 
            // 先穿裤子
            personWithTrousers.SetPerson(xiaoXin);
            // 再让穿裤子的小新穿西装
            personWithSuit.SetPerson(personWithTrousers);
            // 最后把鞋子领带都穿上
            personWithTie.SetPerson(personWithSuit);
            personWithLeather.SetPerson(personWithTie);

            // 照下镜子
            personWithLeather.Show();

            Console.WriteLine();
            Console.WriteLine("==============================");

            AbstractPerson xiaoHei = new Person() { Name = "小黑" };

            Finery personWithTShirt = new TShirt(); // 大t恤
            Finery personWithSneaker = new Sneaker(); // 网鞋

            personWithTShirt.SetPerson(xiaoHei);
            personWithSneaker.SetPerson(personWithTShirt);

            personWithSneaker.Show();



            Console.ReadKey();
        }
    }
}
