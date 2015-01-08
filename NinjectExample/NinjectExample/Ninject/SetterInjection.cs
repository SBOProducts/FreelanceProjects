using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.SetterInjection
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
