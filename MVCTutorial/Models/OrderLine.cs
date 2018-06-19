﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
	public class OrderLine
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public string Product { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }

		public OrderLine() { }
	}
}