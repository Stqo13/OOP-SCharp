﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Product
    {
        public Product(string name, decimal cost)
        {
            this.Name = name;
			this.Cost = cost;
        }
        private string name;

		public string Name
		{
			get { return name; }
			private set 
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Name cannot be empty");
				}
				name = value; 
			}
		}
		private decimal cost;

		public decimal Cost
		{
			get { return cost; }
			private set 
			{
				if (value<0)
				{
					throw new ArgumentException("Money cannot be negative");
				}
				cost = value; 
			}
		}
        public override string ToString()
        {
			return this.Name;
        }
    }
}
