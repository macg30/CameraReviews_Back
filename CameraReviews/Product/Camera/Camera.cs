using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraReviews.Product.Camera
{
	public class Camera : ICamera
	{
		public int maxISO { get; set; }
		public string Type { get; set; }
		public int CropFactor { get; set; }
		public string Name { get; set; }
		public string Manufacturer { get; set; }
		public string SKU { get; set; }
		public List<Feature> Features { get; set; }

		public string GetContent()
		{
			return $"Name: {this.Name}\nType: {Type}\nCropFactor: {CropFactor}";
		}
	}
}
