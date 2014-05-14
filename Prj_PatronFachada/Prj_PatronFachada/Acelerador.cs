using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prj_PatronFachada
{
    class Acelerador:IAcelerador
    {
        #region IAcelerador Members

        public void PresionarAcelerador()
        {
            Console.WriteLine("Acelerador presionado");
        }

        public void SoltarAcelerador()
        {
            Console.WriteLine("Acelerador levantado");
        }

        #endregion
    }
}
