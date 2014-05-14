using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prj_PatronFachada
{
    class Embrague:IEmbrague
    {
       #region IEmbrague Members

        public void PresionarEmbrague()
        {
            Console.WriteLine("Embrague presionado");
        }

        public void SoltarEmbrague()
        {
            Console.WriteLine("Embrague suelto");
        }

        #endregion
    }
}
