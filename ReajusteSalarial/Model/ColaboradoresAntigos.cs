using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial.Model
{
    public class ColaboradoresAntigos: Colaboradores
    {
        public int AnosEmpresa { get; set; }

        public ColaboradoresAntigos(double Salario, int anos) : base(Salario)
        {
        }
    }
}
