using System;
using System.Threading.Tasks;

namespace AsyncMethods
{
	public sealed class TestMethods
	{
		private static readonly TimeSpan Timeout = TimeSpan.FromSeconds(1);

		/// <summary>Асихронно тестируют <see cref="IProgress{T}"/>.</summary>
		/// <returns>Задача, представляет асихронное тестирование интерфейса <see cref="IProgress{T}"/>.</returns>
		public static async Task TestProgressAsync(IProgress<TestProgressArgs> progress)
		{
			for(var i = 0; i <= 100; i++)
			{
				await Task.Delay(Timeout);
				progress.Report(new TestProgressArgs(i));
			}
		}
	}
}
