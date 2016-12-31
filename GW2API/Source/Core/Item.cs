using System;

namespace GW2API.Core
{
	public class ItemSlot
	{
		internal ItemSlot() {}
		public int? id { get; set; }
		public int count { get; set; }
		public string binding { get; set; }
		public string bound_to { get; set; }
	}
}
