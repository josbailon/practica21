using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Notificaciones
    {
        private readonly List<IObserver<Aplicaciones>> observers;

        public List<Aplicaciones> aplicacions { get; set; }

        public Notificaciones()
        {
            observers = new();
            aplicacions = new();
        }

        public IDisposable Subcribir(IObserver<Aplicaciones> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                foreach (var item in aplicacions)
                {
                    observer.OnNext(item);
                }
            }
            return new Unsubcripcion(observers, observer);
        }

        public void AddAplicaciones(Aplicaciones app)
        {
            aplicacions.Add(app);
            foreach (var observer in observers)
            {
                observer.OnNext(app);
            }
        }

        public void CerrarAplicacion()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }
            observers.Clear();
        }
    }
}
