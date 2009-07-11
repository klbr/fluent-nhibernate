using System.Collections.Generic;

namespace FluentNHibernate.Testing.Testing.Values
{
	public class ListEntity
	{
		public ListEntity()
		{
			backingField = new List<string>();
			GetterAndSetter = new List<string>();
			GetterAndPrivateSetter = new List<string>();
		}

		private IList<string> backingField;

		public IEnumerable<string> GetterAndSetter { get; set; }
		public IEnumerable<string> GetterAndPrivateSetter { get; private set; }
		public IEnumerable<string> BackingField
		{
			get { return backingField; }
		}

		public void AddListItem(string value)
		{
			backingField.Add(value);
		}
	}

	public class ReferenceEntity
	{
		public ReferenceEntity()
		{
			ReferenceList = new List<OtherEntity>();
		}

		public OtherEntity Reference { get; set; }
		public IEnumerable<OtherEntity> ReferenceList { get; set; }

		public void SetReference(OtherEntity value)
		{
			Reference = value;
		}
	}

	public class PropertyEntity
	{
		private string backingField;

		public string GetterAndSetter { get; set; }
		public string GetterAndPrivateSetter { get; private set; }

		public string BackingField
		{
			get { return backingField; }
		}

		public void SetBackingField(string value)
		{
			backingField = value;
		}
	}

	public class OtherEntity
	{}
}