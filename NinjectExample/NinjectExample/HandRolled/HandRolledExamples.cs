using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.HandRolled
{
    class HandRolledExamples
    {
        public static void RunHandRolledExamples()
        {
            TightlyCoupled();

            AddingInterfaceButStillTightlyCoupled();

            UseAConstructorParameter();
        }

        static void AddSpace()
        {
            Console.WriteLine();
            Console.WriteLine();
        }


        static void TightlyCoupled()
        {
            Console.WriteLine("Tightly coupled code example");
            var warrior = new NinjectExample.TightlyCoupled.Samurai();
            warrior.Attack("the evildoers");
            AddSpace();
        }


        static void AddingInterfaceButStillTightlyCoupled()
        {
            Console.WriteLine("Using an interface, but still tightly coupled");
            var warrior = new NinjectExample.AddingInterfaceButStillTightlyCoupled.Samurai();
            warrior.Attack("the evildoers");
            AddSpace();
        }


        static void UseAConstructorParameter()
        {
            Console.WriteLine("Pass the interface into constructor, this is DI");
            NinjectExample.UserParameter.IWeapon sword = new NinjectExample.UserParameter.Sword();
            var warrior = new NinjectExample.UserParameter.Samurai(sword);
            warrior.Attack("the evildoers");
            AddSpace();
        }
    }
}
