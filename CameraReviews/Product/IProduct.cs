using System;
using System.Collections.Generic;
using System.Text;

namespace CameraReviews.Product
{
	public interface IProduct
	{
		public string Name { get; set; }
		public string Manufacturer { get; set; }
		public string SKU { get; set; }

		public List<Feature> Feature { get; set; }

		public string GetContent();
	}
}
