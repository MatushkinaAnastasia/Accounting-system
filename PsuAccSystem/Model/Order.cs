﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PsuAccSystem.Model
{
	public class Order
	{
		public Order(long id, string service, string customer, string worker, string price, string date, string time, string status)
		{
			Id = id;
			Service = service;
			Customer = customer;
			Price = price;
			Worker = worker;
			Date = date;
			Time = time;
			Status = status;
		}

		public long Id { get; set; }
		public string Service { get; set; }
		public string Customer { get; set; }
		public string Worker { get; set; }
		public string Price { get; set; }
		public string Date { get; set; }
		public string Time { get; set; }
		public string Status { get; set; }
	}
}
