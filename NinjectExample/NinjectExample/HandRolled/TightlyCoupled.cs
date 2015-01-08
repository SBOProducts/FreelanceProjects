using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectExample.TightlyCoupled
{

    /*
     * 
     * As you might imagine, this will print Chopped the evildoers clean in half to the console. 
     * This works just fine, but what if we wanted to arm our Samurai with another weapon? 
     * Since the Sword is created inside the Samurai class’s constructor, we have to modify 
     * the implementation of the class in order to make this change. 
     * 
     * When a class is dependent on a concrete dependency, it is said to be tightly coupled to that class. 
     * In this example, the Samurai class is tightly coupled to the Sword class. When classes are tightly coupled, 
     * they cannot be interchanged without altering their implementation. In order to avoid tightly coupling classes, 
     * we can use interfaces to provide a level of indirection. Let’s create an interface to represent a weapon in our game.
     * 
     */
     
    class Sword
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chopped {0} clean in half", target);
        }
    }
    
    class Samurai
    {
        readonly Sword sword;
        public Samurai()
        {
            this.sword = new Sword();
        }

        public void Attack(string target)
        {
            this.sword.Hit(target);
        }
    }
}
