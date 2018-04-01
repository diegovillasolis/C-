using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor
{
	class Program
	{
		static void Main(string[] args)
		{
			DataSource dataSource = new DataSource();
			Monitor monitor = new Monitor();

			monitor.Subscribe(dataSource);

			String element;
			String message;

			showPrincipalMenu();
			bool b = true;

			while (b)
			{
				switch (Console.ReadLine())
				{
					case "1":
						Console.WriteLine("Adding a new element \n");
						Console.WriteLine("Enter the new String");
						element = Console.ReadLine();

						dataSource.Add(element);
						message = monitor.GetMessage();
						Console.WriteLine();
						Console.WriteLine(message);

						Console.WriteLine("Enter a key to continue...");
						Console.ReadKey();

						showPrincipalMenu();
						break;
					case "2":
						Console.WriteLine("Deleting a new element \n");
						Console.WriteLine("Enter the String");
						element = Console.ReadLine();

						dataSource.Remove(element);
						message = monitor.GetMessage();
						Console.WriteLine();
						Console.WriteLine(message);

						Console.WriteLine("Enter a key to continue...");
						Console.ReadKey();

						showPrincipalMenu();
						break;
					case "3":
						Console.WriteLine("List the elements \n");

						Console.WriteLine(dataSource);

						Console.WriteLine("Enter a key to continue...");
						Console.ReadKey();

						showPrincipalMenu();
						break;
					case "0":
						Console.WriteLine("Exit \n");
						b = false;
						break;
					default :
						Console.WriteLine("Invalid option");
						break;
				}
			}
		}

		private static void showPrincipalMenu()
		{
			Console.WriteLine("-- Actions --\n");
			Console.WriteLine(
					"Select an option: \n\n" +
							"  1) Add a new string\n" +
							"  2) Remove a string\n" +
							"  3) List \n" +
							"  0) Exit\n "
			);
		}
	}
}
