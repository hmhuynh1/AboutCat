
using System;
using AboutCatFinalProjectHuynhLavan;



namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
           
            string CatBreed = "Mackerel Tabby";
            string CatFavoritedFood = "Tuna";
            int actual;
            int expected = 4;
        
            // Act
           actual = testClass.getActivityLevel( CatFavoritedFood, CatBreed);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}