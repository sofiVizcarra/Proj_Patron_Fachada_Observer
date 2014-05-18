using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Prj_PatronFachada
{
    class Centralita:IObserver
    {
        private IEmbrague _embrague;
        private IAcelerador _acelerador;
        private IPalancaCambios _palancaCambios;

        private ArrayList observers = new ArrayList();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }
        public Centralita() {}
        public Centralita(IEmbrague embrague, IAcelerador acelerador, IPalancaCambios palancaCambios)
        {
            this._embrague = embrague;
            this._acelerador = acelerador;
            this._palancaCambios = palancaCambios;
        }
        public void AumentarMarcha(IObserver observer)
        {
            _acelerador.SoltarAcelerador();
            _embrague.PresionarEmbrague();
            _palancaCambios.PuntoMuerto();
            if (_palancaCambios.GetVelocidadActual() < 5)
                _palancaCambios.InsertarVelocidad(_palancaCambios.GetVelocidadActual() + 1);
            _embrague.SoltarEmbrague();
            _acelerador.PresionarAcelerador();
            AddObserver(observer);
            Notify();
        }
        public void ReducirMarcha(IObserver observer)
        {
            _acelerador.SoltarAcelerador();
            _embrague.PresionarEmbrague();
            _palancaCambios.PuntoMuerto();
            if (_palancaCambios.GetVelocidadActual() > 1)
                _palancaCambios.InsertarVelocidad(_palancaCambios.GetVelocidadActual() - 1);
            _embrague.SoltarEmbrague();
            _acelerador.PresionarAcelerador();
            AddObserver(observer);
            Notify();
        }
    }
}
