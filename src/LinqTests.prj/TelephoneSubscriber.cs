using System;
using System.Collections.Generic;

namespace LinqTests
{
	/// <summary>Предоставляет информацию о абоненте.</summary>
	public sealed class TelephoneSubscriber
	{
		private static int _lastInsertedId = 0;

		/// <summary>Возвращает идентификационный номер абонента.</summary>
		public int Id { get; private set; }

		/// <summary>Возвращает наименование абонента.</summary>
		public string Name { get; private set; }

		/// <summary>Возвращает страну проживания абонента.</summary>
		public Countries Country { get; private set; }

		/// <summary>Возвращает телефонный номер абонента.</summary>
		public List<PhoneNumber> PhoneNumber { get; private set; }

		public TelephoneSubscriber(string name, Countries country, PhoneNumber phoneNumber)
		{
			Id = _lastInsertedId++;
			Name = name;
			Country = country;

			PhoneNumber = new List<PhoneNumber>();
			PhoneNumber.Add(phoneNumber);
		}

		public TelephoneSubscriber()
		{
			Id = _lastInsertedId++;
			PhoneNumber = new List<PhoneNumber>();
		}
	}
}
