using System;
using System.Collections.Generic;
using System.Text;

using CameraReviews.Product;

namespace CameraReviews.Review
{
	public interface IReview
	{
		public string Title { get; set; }
		public string Content { get; set; }

		public string Author { get; set; }

		public List<IProduct> Products { get; set; }
	}
}
