using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor
{
	class Monitor : IObserver<Message>
	{
		private IDisposable cancellation;
		private Message currentMessage;

		internal Message CurrentMessage { get => currentMessage; set => currentMessage = value; }

		public String GetMessage()
		{
			if (currentMessage.Operation == null)
			{
				return "The specified element: \"" + currentMessage.Value + "\" is not been found";
			}
			else
			{			
				if ( currentMessage.Operation.Equals("Del") )
					return "The element " + currentMessage.Value + " has been deleted";
				if ( currentMessage.Operation.Equals("Add") )
					return "The element " + currentMessage.Value + " has been added";
				return null;
			}
		}

		public virtual void Subscribe(DataSource provider)
		{
			cancellation = provider.Subscribe(this);
		}

		public virtual void Unsubscribe()
		{
			cancellation.Dispose();
		}

		public void OnCompleted()
		{
			currentMessage = null;
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(Message message)
		{
			currentMessage = message;	
		}
	}
}
