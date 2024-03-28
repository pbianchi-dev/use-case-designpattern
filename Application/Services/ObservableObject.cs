using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class ObservableObject : IObservable<object>
    {
        private List<IObserver<object>> observers = new List<IObserver<object>>();

        public IDisposable Subscribe(IObserver<object> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void NotifyObservers(object obj)
        {
            foreach (var observer in observers)
            {
                observer.OnNext(obj);
            }
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<object>> _observers;
            private IObserver<object> _observer;

            public Unsubscriber(List<IObserver<object>> observers, IObserver<object> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }

}
