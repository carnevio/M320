using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M320_Aufgaben
{
    public class Zylinder
    {
        private double durchmesser;
        private double hoehe;
        public Zylinder() 
        {
            this.durchmesser = 0.0;
            this.hoehe = 0.0;
        }

        public Zylinder(double durchmesser, double hoehe)
        {
            this.durchmesser=durchmesser;
            this.hoehe=hoehe;
        }

        public void setDurchmesser(double durchmesser)
        {
            this.durchmesser = durchmesser;
        }

        public void setHoehe(double hoehe)
        {
            this.hoehe = hoehe;
        }

        public double getGrundflaeche()
        {
            double radius = durchmesser / 2.0;
            return Math.PI * radius * radius;
        }

        public double getMantelflaeche()
        {
            double radius = durchmesser / 2.0;
            return 2 * Math.PI * radius * hoehe;
        }

        public double getOberflaeche()
        {
            return 2 * getGrundflaeche() + getMantelflaeche();
        }

        public double getVolumen()
        {
            return getGrundflaeche() * hoehe;
        }

        public static double getOberflaeche(double durchmesser, double hoehe)
        {
            double radius = durchmesser / 2.0;
            double grundflaeche = Math.PI * radius * radius;
            double mantelflaeche = 2 * Math.PI * radius * hoehe;
            return 2 * grundflaeche + mantelflaeche;
        }
    }
}

