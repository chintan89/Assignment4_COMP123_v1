using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name - Chintan Patel
 * Student # 300622893
 * Date - July 25/2017
 * version - 0.2 - Created constructor method, implemented HasMoons & HasRings method and added subclass
 */
namespace Assignment4_COMP123
{
    class GiantPlanet : Planet, IHasMoons ,IHasRings
    {
        //2a.Private instance variable
        private string _type;

        //2b.Creat constructor method
       public GiantPlanet(string name,double diameter,double mass,string type) : base(name,diameter,mass)
        {
            type = this._type;
        }

        //2c.Implement the HasMoons method that will return true if the MoonCount Property is greater than Zero
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //2d.Implement the HasRings method that will return true if the MoonCount Property is greater than Zero
        public bool HasRings()
        {
            if (RingCount > 0)
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
