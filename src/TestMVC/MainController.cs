using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMVC
{
	public sealed class MainController
	{
		#region Properties

		public BindingList<StudenMetadataRecord> Records { get; }

		public SutentsMetadataRepository Repository { get; }

		#endregion

		#region .ctor

		public MainController(SutentsMetadataRepository repository)
		{
			if(repository == null)
			{
				throw new ArgumentNullException(nameof(repository));
			}

			Repository = repository;
			Records = new BindingList<StudenMetadataRecord>(repository.Fetch().ToList());
		}

		#endregion

		#region Methods

		public void AddStudentMetadata(string fullname)
		{
			var studentMetadata = Repository.Add(fullname);
			Records.Add(studentMetadata);
		}

		#endregion
	}
}
