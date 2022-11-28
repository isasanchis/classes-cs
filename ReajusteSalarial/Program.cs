using ReajusteSalarial.Model;

namespace ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoReajuste calculo = new();

            calculo.MostraAnos();
        }

    }
}