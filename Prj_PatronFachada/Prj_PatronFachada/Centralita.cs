using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prj_PatronFachada
{
    class Centralita
    {
        public void ReducirMarcha()
        {
            _acelerador.SoltarAcelerador();
            _embrague.PresionarEmbrague();
            _palancaCambios.PuntoMuerto();
            if (_palancaCambios.GetVelocidadActual() > 1)
                _palancaCambios.InsertarVelocidad(_palancaCambios.GetVelocidadActual() - 1);
            _embrague.SoltarEmbrague();
            _acelerador.PresionarAcelerador();
        }
    }
}
