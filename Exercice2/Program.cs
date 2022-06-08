using System;
using Beverages;
using System.Diagnostics;

namespace Exercice2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IBeverage tea = new Tea(TeaType.Oolong);
			Debug.Assert(tea.GetTemperature() > (float)95, "Tea temperature needs be above 95C");

			ISweetener sugar = new Erythriol(0.5);
			tea.Sweeten(sugar);
			Debug.Assert(tea.GetSweetenersList().Count == 1, "We put a single sweetener type");

			IBeverage coffee = new Coffee(CoffeeType.ColdBrew);
			Debug.Assert(coffee.GetTemperature() < (float)5, "Coldbrew coffee temperature needs be below 5C");

			IBeverage horror = new Mix(tea, coffee);
			Debug.Assert(horror.GetTemperature() < (float)55, "Horror temperature needs be average of tea and coffee");
			Debug.Assert(horror.GetSweetenersList().Count == 1, "We put a single sweetener type");

			ISweetener coffeeSugar = new Erythriol(0.5);
			coffee.Sweeten(coffeeSugar);
			Debug.Assert(horror.GetSweetenersList().Count == 1, "We put a single sweetener type, just more of it");
		}
	}
}
