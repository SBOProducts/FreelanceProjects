using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.AddingInterfaceButStillTightlyCoupled
{

    /*
     * 
     * Now our Samurai can be armed with different weapons. But wait! The Sword is still created inside the constructor 
     * of Samurai. Since we still need to alter the implementation of Samurai in order to give our warrior another weapon, 
     * Samurai is still tightly coupled to Sword.
     * 
     */


    interface IWeapon
    {
        void Hit(string target);
    }

    class Sword: IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chopped {0} clean in half", target);
        }
    }

    class Samurai
    {
        readonly IWeapon weapon;
        public Samurai()
        {
            this.weapon = new Sword();
        }

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
}
