
using AboutCatFinalProjectHuynhLavana.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AboutCatFinalProjectHuynhLavan
{
    public class testClass
    {
       
        public static int getActivityLevel(string breed, string food)
        {
            Cat cat = new Cat( 100, "my cat",  breed, food,"my toy","my advice");

            if (food == null || breed == null) return 0;
            if (food == "SHEBA PERFECT PORTIONS")
            {
                return 1;
            }
            if (breed == "Mackerel Tabby")
            {
                return 2;
            }
            if (food == "can food" && breed == "Siamese Cat")
            {
                return 3;
            }
            else return 4;

        }

    }
}
