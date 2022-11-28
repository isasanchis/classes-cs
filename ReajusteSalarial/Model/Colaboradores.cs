using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial.Model
{
    public class Colaboradores
    {
        private double Salario { get; set; }

        public Colaboradores(double salario) { }

        public double getSalario() { return Salario; }

    }
}
