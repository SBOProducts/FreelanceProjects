using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.UserParameter
{

    /*
     * 
     *  Rather than creating the Sword from within the constructor of Samurai, 
     *  we can expose it as a parameter of the constructor instead.
     *  
     *  Then, to arm our warrior, we can inject the Sword via the Samurai ‘s constructor. 
     *  This is an example of dependency injection (specifically, constructor injection).  
     *  
     */

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
            this.weapon = weapon;
        }

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }


}
