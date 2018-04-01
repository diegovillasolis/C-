using System;
using System.Collections.Generic;

namespace Monitor
{
	internal class Unsubscriber<Message> : IDisposable
	{
		private List<IObserver<Message>> _observers;
		private IObserver<Message> _observer;

		public Unsubscriber(List<IObserver<Message>> observers, IObserver<Message> observer)
		{
			this._observers = observers;
			this._observer = observer;
		}

		public void Dispose()
		{
			if (_observers.Contains(_observer))
				_observers.Remove(_observer);
		}
	}
}