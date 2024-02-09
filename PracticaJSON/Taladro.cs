using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJSON
{
    internal class Taladro
    {
        // Propiedades de la clase
        public double FuerzaTorque { get; set; }
        public int RPM { get; set; }
        public double Voltage { get; set; }
        public double CEnergia { get; set; }
        //Constructor vacio
        public Taladro()
        {

        }

        public Taladro(double fuerzaTorque, int rpm, double voltage, double cEnergia)
        {
            FuerzaTorque = fuerzaTorque;
            RPM = rpm;
            Voltage = voltage;
            CEnergia = cEnergia;
        }


    }
}
