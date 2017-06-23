using System;
using System.Collections.Generic;

namespace BaggageClaim
{
    /// <summary>
    ///     Enables observers to stop receiving notifications before the OnCompleted method is called.
    ///     Checks whether an observer still exists in the observers collection. If it does, removes the observer.
    /// </summary>
    internal class Unsubscriber : IDisposable
    {
        private readonly IObserver<BaggageInfo> _observer;
        private readonly List<IObserver<BaggageInfo>> _observers;

        public Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}