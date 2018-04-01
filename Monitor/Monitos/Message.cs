namespace Monitor
{
	internal class Message
	{
		private string value;
		private string operation;

		public Message(string value, string operation)
		{
			this.Value = value;
			this.Operation = operation;
		}

		public string Value { get => value; set => this.value = value; }
		public string Operation { get => operation; set => operation = value; }
	}
}