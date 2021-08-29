using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraReviews.Product
{
	public class Product : IProduct
	{
		public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string Manufacturer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string SKU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public List<Feature> Feature { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public string GetContent()
		{
			throw new NotImplementedException();
		}
	}
}
