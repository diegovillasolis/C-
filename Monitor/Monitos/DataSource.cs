using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor
{
	class DataSource : IObservable<Message>
	{
		private List<String> data;
		private List<IObserver<Message>> observers;

		public DataSource()
		{
			data = new List<String>();
			observers = new List<IObserver<Message>>();
		}

		public DataSource(List<String> data)
		{
			this.data = data;
		}

		public void Add(String element)
		{
			data.Add(element);
			foreach (var observer in observers)
				observer.OnNext(new Message(element, "Add"));
		}

		public void Remove(String element)
		{
			bool b = false;
			List<String> elementsToRemove = new List<String>();
			foreach (var e in data)
			{
				if (element.Equals(e))
				{
					b = true;
					elementsToRemove.Add(e);
					foreach (var observer in observers)
						observer.OnNext(new Message(element, "Del"));
				}
			}
			if (!b)
			{
				foreach (var observer in observers)
					observer.OnNext(new Message(element, null));
			}
			foreach (var e in elementsToRemove)
				data.Remove(e);

			elementsToRemove.Clear();
		}

		public void LastElement()
		{
			foreach (var observer in observers)
				observer.OnCompleted();

			observers.Clear();
		}

		public IDisposable Subscribe(IObserver<Message> observer)
		{
			// Check whether observer is already registered. If not, add it
			if (!observers.Contains(observer))
			{
				observers.Add(observer);
				// Provide observer with existing data.
				//foreach (var item in data)
					//observer.OnNext(item);
			}
			return new Unsubscriber<Message>(observers, observer);
		}

		public override string ToString()
		{
			String r = "[ ";
			foreach(String s in data)
			{
				r += "\"" + s + "\" ";  
			}
			return r += "]";
		}
	}
}
