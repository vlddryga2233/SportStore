using Moq;
using SportStore.Controllers;
using SportStore.Models;
using SportStore.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace SportStore.Tests
{
    public class ProductControllerTest
    {
        [Fact]
        public void Can_Paginate()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
            {
                new Product { Id = 1, Name = "P1"},
                new Product { Id = 2, Name = "P2"},
                new Product { Id = 3, Name = "P3"},
                new Product { Id= 4, Name = "P4"},
                new Product { Id = 5, Name = "P5"}
            }).AsQueryable<Product>());

            ProductController controller = new ProductController(mock.Object);
            controller.pagesize = 3;


            ProductListVIewModel result =
                controller.List(null,2).ViewData.Model as ProductListVIewModel;

            Product[] prodArray = result.Products.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P4", prodArray[0].Name);
            Assert.Equal("P5", prodArray[1].Name);


        }

        [Fact]
        public void Can_Send_Pagination_View_Model()
        {
            // Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product {Id = 1, Name = "P1"},
                new Product {Id = 2, Name = "P2"},
                new Product {Id = 3, Name = "P3"},
                new Product {Id = 4, Name = "P4"},
                new Product {Id = 5, Name = "P5"}
            }).AsQueryable<Product>());
            // Arrange
            ProductController controller =
            new ProductController(mock.Object) { pagesize = 3 };
            // Act
            ProductListVIewModel result =
            controller.List(null,2).ViewData.Model as ProductListVIewModel;
            // Assert
            PageInfo pageInfo = result.PageInfo;
            Assert.Equal(2, pageInfo.CurrentPage);
            Assert.Equal(3, pageInfo.ItemsPerPage);
            Assert.Equal(5, pageInfo.TotalItems);
            Assert.Equal(2, pageInfo.TotalPages);
        }      
        
        [Fact]
        public void Can_Filter_Products()
        {
            //Arrange
            //Create the mock repository
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
            {
                new Product {Id= 1, Name="P1",Category="Cat1"},
                new Product {Id= 2, Name="P2",Category="Cat2"},
                new Product {Id= 3, Name="P3",Category="Cat1"},
                new Product {Id= 4, Name="P4",Category="Cat2"},
                new Product {Id= 5, Name="P5",Category="Cat3"}
            }).AsQueryable<Product>());

            //Arrange - create a controller and  make  the page size 3 items
            ProductController controller = new ProductController(mock.Object);
            controller.pagesize = 3;

            //Action
            Product[] result =
                (controller.List("Cat2", 1).ViewData.Model as ProductListVIewModel)
                        .Products.ToArray();

            //Assert
            Assert.Equal(2, result.Length);
            Assert.True(result[0].Name == "P2" && result[0].Category == "Cat2");
            Assert.True(result[1].Name == "P4" && result[0].Category == "Cat2");


        }
    }
}
