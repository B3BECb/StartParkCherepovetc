using System;

namespace LinqTests
{
	/// <summary>Предоставляет информацию о телефонном номере.</summary>
	public sealed class PhoneNumber
	{
		/// <summary>Возвращает телефонный номер.</summary>
		public int Number { get; private set; }

		/// <summary>Возвращает состояние блокировки номера.</summary>
		public bool IsBlocked { get; set; }

		public PhoneNumber(int number)
		{
			Number = number;
		}

		public PhoneNumber() { }
	}
}
