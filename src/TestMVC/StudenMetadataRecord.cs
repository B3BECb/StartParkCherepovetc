using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVC
{
	public class StudenMetadataRecord
	{
		public int Id { get; }

		public string Fullname { get; }

		public StudenMetadataRecord(int id, string fullname)
		{
			Id = id;
			Fullname = fullname;
		}
	}
}
