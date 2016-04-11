using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
	public sealed class ValidateResult
	{
		public bool Success { get; set; }

		public int MessageCount { get; set; }

		public int CharsCount { get; set; }
	}

	public class MessageValidator
	{
		private const int MaxMessageLength = 64;

		public ValidateResult ValidateMessage(string message)
		{
			if(message == null)
			{
				throw new ArgumentNullException(nameof(message));
			}

			double x = message.Length / MaxMessageLength;
			var i = Math.Truncate(x);

			if((message.Length % MaxMessageLength) > 0)
			{
				i++;
			}

			var success = message.Length <= MaxMessageLength;
			var count = Convert.ToInt32(i);
			var charsCount = message.Length;

			return new ValidateResult
			{
				CharsCount = charsCount,
				Success = success,
				MessageCount = count,
			};
		}
	}
}
