using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTests
{
	class Program
	{
		private static Random _rand = new Random();

		static void Main(string[] args)
		{
			var operators = InitializeOperators();

			Console.WriteLine("First operator is " + operators.FirstOrDefault().Name);
			Console.WriteLine("Last operator is " + operators.LastOrDefault().Name);

			Console.WriteLine();

			foreach(var phoneOperator in operators.Where(op => op.Mask == "474"))
			{
				Console.WriteLine(phoneOperator.Name + " with mask 474");
			}

			Console.WriteLine();

			var fullNumber = operators
				.Where(op => op.Country == Countries.Russia)
				.Select(op => 
				new
				{
					Mask = op.Mask,
					AbonentInfo = op.Subscribers.Select(sub=> 
					new
					{
						AvailableNumbers = sub.PhoneNumber.Where(pNum => pNum.IsBlocked == false),
						Name = sub.Name
					})
				});

			foreach(var number in fullNumber)
			{
				foreach(var info in number.AbonentInfo)
				{
					Console.WriteLine($"Abonent {info.Name} have available numbers: ");

					foreach(var availableNumber in info.AvailableNumbers)
					{
						Console.WriteLine($"+7({number.Mask}){availableNumber.Number}");
					}

					Console.WriteLine();
				}
			}

			Console.WriteLine();

			Console.WriteLine("Dictionary keys: ");

			foreach(var key in operators.ToDictionary(key => key.Id).Keys)
			{
				Console.Write(key.ToString());
			}
			Console.WriteLine();
			Console.WriteLine();

			var newSubscribers = InitilizeData();

			var japanOperator = operators.Where(op=>op.Country == Countries.Japan).FirstOrDefault();
			if(japanOperator != null)
			{
				japanOperator.Subscribers.Concat(newSubscribers.Where(sub => sub.Country == Countries.Japan));

				Console.WriteLine($"Operator {japanOperator.Name} added new subcribers. Total subscribers: {japanOperator.Subscribers.Count()}");
			}

			Console.WriteLine();

			operators.ToList();
			operators.ToArray();
			var grouped = operators.GroupBy(el => el.Country);

			Console.WriteLine("Unique countries: ");
			foreach(var item in grouped)
			{
				Console.WriteLine(item.Key);
			}

			Console.WriteLine();

			//7

			object[] nums = new object[] { 1, 2, 3, "AA", 5 };

			Console.WriteLine("Of type result: ");

			foreach(var number in nums.OfType<int>())
			{
				Console.Write(number);
			}
			Console.WriteLine();
			Console.WriteLine();

			var badCountries = operators
				.Where(op=>op.Subscribers.Any(sub=>sub.PhoneNumber.Any(pNum => pNum.IsBlocked == true)))
				.Select(op =>
				new
				{
					Country = op.Country.GetDescription()
				}).GroupBy(el => el.Country);

			Console.WriteLine("Bad countries:");

			foreach(var country in badCountries)
			{
				Console.WriteLine(country.Key);
			}
			Console.WriteLine();

			//9

			operators.Distinct();

			operators.Reverse();

			Console.WriteLine("Element at index 1. " + operators.ElementAt(1).Name);
			Console.WriteLine();
			//12

			//https://code.msdn.microsoft.com/LINQ-Set-Operators-374f34fe#intersect1
			int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
			int[] numbersB = { 1, 3, 5, 7, 8 };

			var commonNumbers = numbersA.Intersect(numbersB);

			Console.WriteLine("Common numbers shared by both arrays:");
			foreach(var n in commonNumbers)
			{
				Console.WriteLine(n);
			}
			Console.WriteLine();

			//https://code.msdn.microsoft.com/LINQ-Set-Operators-374f34fe#intersect1
			IEnumerable<int> aOnlyNumbers = numbersA.Except(numbersB);

			Console.WriteLine("Numbers in first array but not second array:");
			foreach(var n in aOnlyNumbers)
			{
				Console.WriteLine(n);
			}
			Console.WriteLine();

			Console.WriteLine("Max: " + numbersA.Max());
			Console.WriteLine("Min: " + numbersA.Min());

			Console.ReadKey();
		}

		private static IReadOnlyList<TelephoneSubscriber> InitilizeData()
		{
			var subscribers = new List<TelephoneSubscriber>();

			for(int i = 0; i < _rand.Next(15); i++)
			{
				var phoneNumber = new PhoneNumber(_rand.Next(1000000, 9999999));
				if(_rand.Next(2) == 1) phoneNumber.IsBlocked = true;

				var index = _rand.Next(RandStrings.FIO.Length);

				subscribers.Add(new TelephoneSubscriber(RandStrings.FIO[index], (Countries)_rand.Next(1, 5), phoneNumber));
			}

			return subscribers;
		}

		private static List<Operator> InitializeOperators()
		{
			var list = new List<Operator>();	
			for(int i = 0; i < 4; i++)
			{
				var maskIndex = _rand.Next(RandStrings.Masks.Length);
				var operatorIndex = _rand.Next(RandStrings.Operators.Length);

				var phoneOperator = new Operator(RandStrings.Masks[maskIndex], 
					(Countries) _rand.Next(1, 4), 
					RandStrings.Operators[operatorIndex]);

				phoneOperator.Subscribers.AddRange(InitilizeData());
				list.Add(phoneOperator);
			}
			return list;
		}

	}
}
