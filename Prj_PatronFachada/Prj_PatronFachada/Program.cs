using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prj_PatronFachada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IAcelerador acelerador = new Acelerador();
            IEmbrague embrague = new Embrague();
            IPalancaCambios palancaCambios = new PalancaCambios();

            acelerador.SoltarAcelerador();
            embrague.PresionarEmbrague();
            palancaCambios.PuntoMuerto();
            palancaCambios.InsertarVelocidad(3);
            embrague.SoltarEmbrague();
            acelerador.PresionarAcelerador();*/





            IObserver observer = new Centralita();
            IAcelerador acelerador = new Acelerador();
            IEmbrague embrague = new Embrague();
            IPalancaCambios palancaCambios = new PalancaCambios();

            Centralita centralita = new Centralita(embrague, acelerador, palancaCambios);
            centralita.AumentarMarcha(observer);

            Console.ReadLine();
            
        }
    }
}
