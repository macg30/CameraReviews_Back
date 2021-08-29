using System;
using System.Collections.Generic;
using System.Text;

namespace CameraReviews.Product.Camera
{
	public interface ICamera : IProduct
	{
		public int maxISO { get; set; }

		public string Type { get; set; }

		public int CropFactor { get; set; }
	}
}
