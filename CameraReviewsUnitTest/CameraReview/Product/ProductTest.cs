using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CameraReviews.Product ;
using NSubstitute;
using CameraReviews.Product.Camera;

namespace CameraReviewsUnitTest.CameraReview.Product
{
	[TestClass]
	public class ProductTest
	{
		[TestMethod]
		public void Product_ShouldReturnContent_Success()
		{
			//Setup
			//var product = Substitute.For<IProduct>(); //Mock
			var product = new ProductImp 
			{
				Name  = "Producto 1",
				SKU = "Producto 1",
				Manufacturer = "empresa",
			}; //Implementation

			//Execute
			var content = product.GetContent();

			//Assert
			Assert.IsNotNull(content);
			Assert.IsTrue(!string.IsNullOrEmpty(content), "Should return content but obtain null or whitespace"); //null, "", " "
		}

		[TestMethod]
		public void CameraProduct_ShouldReturnContentThatIncludeFeautres_Success()
		{
			//Setup
			//var product = Substitute.For<IProduct>(); //Mock
			var type = "FullFrame";
			var cameraProduct = new Camera {
				Name = "Canon 60D",
				Type = "FullFrame",
				CropFactor = 1
			};

			//Execute
			var content = cameraProduct.GetContent();

			//Assert
			Assert.IsTrue(!string.IsNullOrEmpty(content), "Should return content but obtain null or whitespace"); //null, "", " "
			Assert.IsNotNull(content.Contains(type));
			Assert.IsNotNull(content.Contains("FullFrame"));
		}


	}
}
