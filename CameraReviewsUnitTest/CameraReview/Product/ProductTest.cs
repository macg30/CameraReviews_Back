using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CameraReviews.Product;
using NSubstitute;

namespace CameraReviewsUnitTest.CameraReview.Product
{
	[TestClass]
	public class ProductTest
	{
		[TestMethod]
		public void Product_ShouldReturnContent_Success()
		{
			//Setup
			var product = Substitute.For<IProduct>(); //Mock
			//var product = new Product(); //Implementation

			//Execute
			var content = product.GetContent();

			//Assert
			Assert.IsNotNull(content);
			Assert.IsTrue(!string.IsNullOrEmpty(content), "Should return content but obtain null or whitespace"); //null, "", " "
		}

	}
}
