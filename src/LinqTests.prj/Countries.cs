using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTests
{
	/// <summary>Список обслуживаемых стран.</summary>
	public enum Countries
	{
		[Description("Russia")]
		Russia = 1,

		[Description("Polland")]
		Polland = 2,

		[Description("USA")]
		USA = 3,

		[Description("Japan")]
		Japan = 4
	}
}
