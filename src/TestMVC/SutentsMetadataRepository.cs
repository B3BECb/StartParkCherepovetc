using System;
using System.Collections.Generic;

namespace TestMVC
{
	public class SutentsMetadataRepository
	{
		public IReadOnlyList<StudenMetadataRecord> Fetch()
		{
			return new List<StudenMetadataRecord>()
			{
				new StudenMetadataRecord(0, "Petrov Petr"),
			};
		}

		public StudenMetadataRecord Add(string fullname)
		{
			return new StudenMetadataRecord(0, fullname);
		}
	}
}
