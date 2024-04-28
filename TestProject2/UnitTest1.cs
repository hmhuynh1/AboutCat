
using System;
using AboutCatFinalProjectHuynhLavana.Models;
using CatsList.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Moq;



namespace TestProject2
{
    public class UnitTest1
    {
        
        [Fact]
        public void PostAdviceCatController()
        {
            // catc = CatController(MockCatContext)
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var options = new DbContextOptionsBuilder<CatContext>();
            options.UseSqlServer(config.GetConnectionString("CatContext"));
            var context = new CatContext(options.Options);
            var controller = new CatsController(context);
            var result = controller.Advice(new Cat
            {
                CatId = 1,
                CatName = "Casablanca",
                CatBreed = "T",
                CatFavoriteFood = "c",
                CatFavoriteToy = "t",
                Advice = "ho"
            });


            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Advice", redirectToActionResult.ActionName);
        }


        [Fact]
        public void GetAdviceCatController()
        {
            // catc = CatController(MockCatContext)
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var options = new DbContextOptionsBuilder<CatContext>();
            options.UseSqlServer(config.GetConnectionString("CatContext"));
            var context = new CatContext(options.Options);
            var controller = new CatsController(context);
            var result = controller.Advice();


            // Assert view is returned
            var viewResult = Assert.IsType<ViewResult>(result);
        }
    }
}