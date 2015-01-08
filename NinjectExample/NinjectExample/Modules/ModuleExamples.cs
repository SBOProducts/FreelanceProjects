using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.Modules
{
    
    public class ModuleExamples
    {
        public static void RunExamples()
        {
            IKernel kernel = new StandardKernel(new WarriorModule());
            Samurai warrior = kernel.Get<Samurai>();
            warrior.Attack("the evildoers");
        }
    }



    public class WarriorModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Sword>();
            Bind<Samurai>().ToSelf().InSingletonScope();
        }
    }

    interface IWeapon
    {
        void Hit(string target);
    }

    class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chopped {0} clean in half", target);
        }
    }

    class Samurai
    {
        readonly IWeapon weapon;

        public Samurai(IWeapon weapon)
        {
            if (weapon == null)
                throw new ArgumentNullException("weapon");
            this.weapon = weapon;
        }

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }

    

}
