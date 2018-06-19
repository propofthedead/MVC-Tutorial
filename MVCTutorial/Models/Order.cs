using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string Descriptoin { get; set; }
		public decimal total { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer customer { get; set; }

		public Order() { }
	}
}