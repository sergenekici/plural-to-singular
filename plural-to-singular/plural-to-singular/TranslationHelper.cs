using System;
using System.Globalization;
using System.Data.Entity.Design.PluralizationServices;

namespace plural_to_singular
{
    public static class TranslationHelper
    {
        public static string PluralToSingular(string text)
        {
            var cult = new CultureInfo("en-US");
            string singular = PluralizationService.CreateService(cult)
                       .Singularize(text); 

            return singular;
        }


        public static string SingularToPlural(string text)
        {
            var cult = new CultureInfo("en-US");
            string plural = PluralizationService.CreateService(cult)
                       .Pluralize(text);

            return plural;
        }
         
    }
}
