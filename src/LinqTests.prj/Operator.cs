using System;
using System.Collections.Generic;

namespace LinqTests
{
	/// <summary>Предоставляет информацию об операторе сотовой связи.</summary>
	public sealed class Operator
	{
		private static int _lastInsertedId = 0;

		/// <summary>Возвращает идентификационный номер оператора связи.</summary>
		public int Id { get; private set; }

		/// <summary>Возвращает нименование оператора связи.</summary>
		public string Name { get; private set; }

		/// <summary>Возвращает маску набора номера оператора связи..</summary>
		public string Mask { get; private set; }

		/// <summary>Возвращает страну регистрации оператора связи.</summary>
		public Countries Country { get; private set; }

		/// <summary>Возвращает страну регистрации оператора связи.</summary>
		public List<TelephoneSubscriber> Subscribers { get; private set; }

		public Operator(string mask, Countries country, string name)
		{
			Id = _lastInsertedId++;
			Mask = mask;
			Country = country;
			Name = name;

			Subscribers = new List<TelephoneSubscriber>();
		}

		public Operator()
		{
			Id = _lastInsertedId++;
			Subscribers = new List<TelephoneSubscriber>();
		}
	}
}
