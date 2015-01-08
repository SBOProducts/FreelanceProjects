using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.ConstructorInjection
{

    //https://github.com/ninject/ninject/wiki/Injection-Patterns

    interface IWeapon
    {
        void Hit(string target);
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
