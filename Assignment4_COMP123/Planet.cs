using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name - Chintan Patel
 * Student # 300622893
 * Date - July 25/2017
 * version - 0.3 - Planet class declared as a public
 */
namespace Assignment4_COMP123
{
    
    class Planet
    {
        /* 1a.Private instant variables*/
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationalPeriod;
        
        /* 1b.Public properties*/
        public double Diameter
        {
            get
            {
                return _diameter;
            }
        }
        public double Mass
        {
            get
            {
                return _mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double OrbitalPriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationalPeriod
        {
            get
            {
                return this._rotationalPeriod;
            }
            set
            {
                this._rotationalPeriod = value;
            }
        }

        /* 1c. Constructor Method*/
       public Planet(string name,double diameter,double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
        /* 1d. override ToString Method outputs Name, Diameter and Mass to he console*/
        public override string ToString()
        {
            string planetInfo = "Name:"+ this._name + "\nDiameter:" + this._diameter + " thousands of kilometers \nMass: " + this._mass + " x 10^24 kilograms\n";
            Console.WriteLine(planetInfo);
            return planetInfo;
        }
    }
}
