using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
	class Banking
	{
		public int DateYear { get; set; }
		public int DateMounth {	get; set; }
		public int DateDay { get; set; }
		public int DateHours { get; set; }
		public int DateMinuts { get; set; }
		public string Type { get; set; }
		public string To { get; set; }
		public double Money { get; set; }
		public double CurrentMoney { get; set; }

		#region list
		static List<Banking> banking = new List<Banking>
		{
			new Banking { DateYear=2015, DateMounth=5, DateDay=15, DateHours=13, DateMinuts= 45, Type = "AddMoney", To = "Money Transfer", Money = 8632.72, CurrentMoney = 8632.72 },
			new Banking { DateYear=2015, DateMounth=5, DateDay=15, DateHours=13, DateMinuts= 45, Type = "AddMoney", To = "Money Transfer", Money = 512.56, CurrentMoney = 9145.28 },
			new Banking { DateYear=2015, DateMounth=5, DateDay=15, DateHours=13, DateMinuts= 46, Type = "AddMoney", To = "Money Transfer", Money = 1068.03, CurrentMoney = 10213.31},
			new Banking { DateYear=2015, DateMounth=5, DateDay=17, DateHours=17, DateMinuts= 2, Type = "Pay", To = "Woki-Che", Money = 490, CurrentMoney = 9723.31},
			new Banking { DateYear=2015, DateMounth=5, DateDay=18, DateHours=11, DateMinuts= 33, Type = "Remove", To = "Remove from a card", Money = 200, CurrentMoney = 9523.31 },
			new Banking { DateYear=2015, DateMounth=5, DateDay=21, DateHours=18, DateMinuts= 3, Type = "Pay", To = "Vega", Money = 14.76, CurrentMoney = 9508.55},
			new Banking { DateYear=2015, DateMounth=5, DateDay=21, DateHours=18, DateMinuts= 3, Type = "AddMoney", To = "Add to a card", Money = 15000.00, CurrentMoney = 24508.55},
			new Banking { DateYear=2015, DateMounth=6, DateDay=25, DateHours=20, DateMinuts= 53, Type = "Pay", To = "Woki-Che", Money = 570.00, CurrentMoney = 23938.55},
		};
		#endregion
		static void Main(string[] args)
		{
			#region queries
			var MoneyTransfer =
			from benefit in banking
			where benefit.Type == "AddMoney"
			select benefit;

			var LoseMoney =
			from lost in banking
			where lost.Type != "AddMoney"
			select lost;

			var Day =
			from day in banking
			where day.DateDay == 15 && day.DateMounth == 5
			select day;

			var Eat =
			from eat in banking
			where eat.To == "Woki-Che"
			select eat;
			
			#endregion
			#region print
			Console.WriteLine("1.Add money");
			Console.WriteLine("");
			foreach(Banking benefit in MoneyTransfer)
			{
				Console.WriteLine("{0}, {1} rub. Now u have {5} rub. Date: {2}.{3}.{4}", benefit.To, benefit.Money, benefit.DateYear, benefit.DateMounth, benefit.DateDay, benefit.CurrentMoney);
			}
			Console.WriteLine("");
			Console.WriteLine("2.Lost money");
			Console.WriteLine("");
			foreach(Banking lost in LoseMoney)
			{
				Console.WriteLine("{0}, {1} rub. Now u have {5} rub.Date: {2}.{3}.{4}", lost.To, lost.Money, lost.DateYear, lost.DateMounth, lost.DateDay, lost.CurrentMoney);
			}

			Console.WriteLine("");
			Console.WriteLine("3. All for 3.05");
			Console.WriteLine("");
			foreach(Banking day in Day)
			{
				Console.WriteLine("{0}, {1} ",day.To, day.Money);
			}

			Console.WriteLine("");
			Console.WriteLine("4. Lost money in Woki-che");
			Console.WriteLine("");
			foreach(Banking eat in Eat)
			{
				Console.WriteLine("{0}.{1}.{2} u lost money:{3}", eat.DateDay, eat.DateMounth, eat.DateYear, eat.Money);
			}
			Console.ReadKey();
			#endregion
		}
	}
}
