using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Unsubcripcion : IDisposable
        {
            private readonly List<IObserver<Aplicaciones>> observers;
        private IObserver<Aplicaciones> observer;

        public List<Aplicaciones> aplicacions { get; set; }

            public Unsubcripcion(List<IObservable<Aplicaciones>> observers, IObserver<Aplicaciones> observer)
            {
                this.observers = observers;
                this.observers = observer;
            }

        public Unsubcripcion(List<IObserver<Aplicaciones>> observers, IObserver<Aplicaciones> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

       
    }
    }