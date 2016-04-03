using System;

namespace StartPark
{
	public static class Verify
	{
		public static class Argument
		{
			public static void IsNeitherNullNorEmpty(string value, string parameterName)
			{
				if(string.IsNullOrEmpty(value))
				{
					if(value == null)
					{
						throw new ArgumentNullException(parameterName, "The parameter can not be either null or empty.");
					}
					throw new ArgumentException("The parameter can not be either null or empty.", parameterName);
				}
			}
		}
		
	}
}
