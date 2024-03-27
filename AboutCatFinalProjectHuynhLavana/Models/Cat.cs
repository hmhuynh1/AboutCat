using System.ComponentModel.DataAnnotations;

namespace AboutCatFinalProjectHuynhLavana.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }

    public class CatAdvice
    {
        [Required,StringLength (60)]
        public string Breed { get; set; }

        [Required, StringLength(30)]
        public string CatName { get; set; }
       
    }
}


//hello