using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraReviews.Product
{
	public class ProductImp : IProduct
	{
		public string Name { get ; set ; }
		public string Manufacturer { get; set; }
		public string SKU { get; set; }
		public List<Feature> Features { get; set; }

		public string GetContent()
		{
			return "Hello";
		}
	}
}
