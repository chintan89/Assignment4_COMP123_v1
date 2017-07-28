using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name - Chintan Patel
 * Student # 300622893
 * Date - July 27/2017
 * version - 0.2  Create a  Constructer Method ,implemented HasMoons & Habitable method and added subclass
 */
namespace Assignment4_COMP123
{
    class Terrestrialplanet :Planet,IHasMoons,IHabitable
    {
        //3a.Private instance variable
        private bool _oxygen;

        //3b.The Constructer Method
        public Terrestrialplanet(string name, double diameter, double mass,bool oxygen) : base(name, diameter, mass)
        {
            oxygen = this._oxygen;
        }
       
        //3c.Implement the HasMoons method that will return true if the MoonCount property is greaterthan Zero
        public bool HasMoons()
        {
           if(MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //3d.Implement the Habitable method that will return true if the Habitable property is greaterthan Zero
        public bool Habitable()
        {
            if(this._oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
