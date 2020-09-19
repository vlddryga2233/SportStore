using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Moq;
using SportStore.Components;
using SportStore.Models;
using Xunit;

namespace SportStore.Tests
{
    public class NavigationMenuViewComponentTest
    {
        [Fact]
        public void Can_Select_Categories()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
            {
                new Product{Id=1,Name="P1",Category="C1"},
                new Product{Id=2,Name="P2",Category="C1"},
                new Product{Id=3,Name="P3",Category="C2"},
                new Product{Id=4,Name="P4",Category="C3"}
            }).AsQueryable<Product>());

            NavigationMenuViewComponent target =
                new NavigationMenuViewComponent(mock.Object);

            //Act
            string[] results = ((IEnumerable<string>)(target.Invoke()
                as ViewViewComponentResult).ViewData.Model).ToArray();

            //Assert
            Assert.True(Enumerable.SequenceEqual(new string[] { "C1", "C2", "C3" }, results));
        }

        [Fact]
        public void Indicates_Selected_Category()
        {
            //Arrange
            string categoryToSelect = "Apples";
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
            {
                new Product {Id = 1, Name = "P1", Category = "Apples"},
                new Product {Id = 2, Name = "P2", Category = "Oranges"}
            }).AsQueryable<Product>());
            NavigationMenuViewComponent target =
                new NavigationMenuViewComponent(mock.Object);

            target.ViewComponentContext = new ViewComponentContext
            {
                ViewContext = new ViewContext
                {
                    RouteData = new Microsoft.AspNetCore.Routing.RouteData()
                }
            };

            target.RouteData.Values["category"] = categoryToSelect;

            //Action
            string result = (string)(target.Invoke() as
                ViewViewComponentResult).ViewData["SelectedCategory"];

            //Assert
            Assert.Equal(categoryToSelect, result);


        }
    }
}
