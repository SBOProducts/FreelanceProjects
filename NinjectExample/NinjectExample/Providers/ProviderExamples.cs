using Ninject;
using Ninject.Activation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.Providers
{
    public class ProviderExamples
    {
        public static void RunExamples()
        {
            IKernel kernel = new StandardKernel(new WarriorModule());
            Samurai warrior = kernel.Get<Samurai>();
            warrior.Attack("the evildoers");
        }
    }


    class SwordProvider : Provider<Sword>
    {
        protected override Sword CreateInstance(IContext context)
        {
            Sword sword = new Sword();

            // Do some complex initialization here.

            return sword;
        }
    }


    class WarriorModule : NinjectModule
    {
        public override void Load()
        {
            // use the provider to create a new instance of the sword where more configuration is needed than a simple create
            Bind<IWeapon>().ToProvider(new SwordProvider());

            // A lighter weight alternative to writing IProvider implementations is to bind a service to a delegate method.
            Bind<IWeapon>().ToMethod(context => new Sword());

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
