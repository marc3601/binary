using System;
using System.Collections.Generic;

internal class Program
{
	private static void Main()
	{
		while (true)
		{
			Console.WriteLine("\nJakią liczbę przekonwertować? (od 0 do 2 147 483 647)");
			string input = Console.ReadLine();
			string type = IsFloatOrInt(input);
			List<string> dec = new List<string>();
			List<string> bin = new List<string>();
			if (type == "INT")
			{
				if (input == "0")
				{
					Console.Write(0);
				}
				float convertThis = float.Parse(input);
				for (float temp = convertThis; temp >= 1f; temp /= 2f)
				{
					dec.Add(temp.ToString());
				}
				foreach (string item2 in dec)
				{
					float.TryParse(item2, out var v);
					if ((int)v % 2 == 0 && (int)v != 0)
					{
						bin.Add("0");
					}
					else if ((int)v % 2 != 0 || (int)v == 0)
					{
						bin.Add("1");
					}
				}
				bin.Reverse();
				foreach (string item in bin)
				{
					Console.Write(item);
				}
			}
			else
			{
				Console.WriteLine("Coś poszło nie tak!");
			}
		}
	}

	private static string IsFloatOrInt(string value)
	{
		if (int.TryParse(value, out var _))
		{
			return "INT";
		}
		if (float.TryParse(value, out var _))
		{
			return "FLOAT";
		}
		return "Error occured";
	}
}