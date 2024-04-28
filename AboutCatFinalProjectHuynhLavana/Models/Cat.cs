/***************************************************************
* Name         : About Cat final project
* Created      : 04/15/2024
* Course       : CIS 174 - Advanced C#
* Version      : 1.0
* OS           : Windows 11
* IDE          : Visual Studio 2020 Community
* Copyright    : This is my own original work based on
*                specifications issued by our instructor*    

           
* Multipage web application including a navigation menu.
*Connecting to a backend database with examples of Create, Read, Update, and Deletes
*Create proper controllers without including all your business logic in there (logic should be in service classes)
*Properly formed Razor views with tag helpers and partial views
*Properly use session state 
*Always validate user input 
*Use dependency injection in order to make your code modular and testable
*Unit test all your business logic in your service classes
*User authentication (sign in)
*User Authorization (allowing certain access to certain people or roles)
*Web API for access for third party applications (postman, games, and/or mobile applications
***************************************************************/


using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace AboutCatFinalProjectHuynhLavana.Models
{

    public class Cat
    {
        public int CatId { get; set; }
        
        [Required, StringLength(30)]
        public string CatName { get; set; } = string.Empty;

        [Required, StringLength(30)]
        public string CatBreed { get; set; } = string.Empty;


        [Required, StringLength(40)]
        public string CatFavoriteFood { get; set; } = string.Empty;


        [Required, StringLength(40)]
        public string CatFavoriteToy { get; set; } = string.Empty;


        [Required, StringLength(100)]
        public string Advice { get; set; } = string.Empty;

       public Cat(int catId, string catName, string catBreed, string catFavoriteFood, string catFavoriteToy, string advice)
        {
            CatId = catId;
            CatName = catName;
            CatBreed = catBreed;
            CatFavoriteFood = catFavoriteFood;
            CatFavoriteToy = catFavoriteToy;
            Advice = advice;
        }
        public Cat() { 

        }
    }
}

