﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prj_PatronFachada
{
    interface IObserver
    {
        void Update(Centralita subject);
    }
}
