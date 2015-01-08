using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample
{
    public static class NinjectExamples
    {
        public static void RunExamples()
        {
            BindUsingModule();
            BindUsingForEach();
        }

        static void BindUsingModule()
        {
            Ninject.IKernel kernel = new StandardKernel(new NinjectExample.MultipleImplentations.TestModule());

            var samurai = kernel.Get<NinjectExample.MultipleImplentations.Samurai>();
            samurai.Attack("your enemy");
        }

        public static void BindUsingForEach()
        {
            Ninject.IKernel kernel = new StandardKernel(new NinjectExample.MultipleImplentations.TestModule());

            IEnumerable<NinjectExample.MultipleImplentations.IWeapon> weapons = kernel.GetAll<NinjectExample.MultipleImplentations.IWeapon>();
            foreach (var weapon in weapons)
                Console.WriteLine(weapon.Hit("the evildoers"));
        }


    }
}
