using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTests
{
	public static class EnumExtension
	{
		public static string GetDescription(this Enum enumerableValue)
		{
			var type = enumerableValue.GetType();
			var memInfo = type.GetMember(enumerableValue.ToString());
			var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
			return (attributes.Length > 0) ? ((DescriptionAttribute)attributes[0]).Description : null;
		}
	}
}
