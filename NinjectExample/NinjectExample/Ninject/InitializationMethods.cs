using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Neither of these uses are as clean as constructor injection, but may be necessary under some circumstances
 */


namespace NinjectExample.SetterMethodInjection
{
    interface IWeapon
    {
        void Hit(string target);
    }

    class Samurai
    {
        IWeapon weapon;

        [Inject]
        public void Arm(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
}


// do not confuse property setter injection with the Property Injection Pattern
namespace NinjectExample.PropertySetterInjection
{
    interface IWeapon
    {
        void Hit(string target);
    }

    class Samurai
    {
        [Inject]
        public IWeapon Weapon { private get; set; }

        public void Attack(string target)
        {
            this.Weapon.Hit(target);
        }
    }
}