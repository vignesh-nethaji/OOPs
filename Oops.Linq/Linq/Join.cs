using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Sln
{/// <summary>
/// Supportive Class For Join Class Methods.
/// </summary>
    class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

        class Join
    {
        /// <summary>
        /// Groups two collections by a common key value, and is similar to left outer join in SQL.
        /// This Lambda Expression sample groups collection "persons" with collection "languages" by a common key.
        /// </summary>
        public static void Sample_GroupJoin_Lambda()
        {
            Language[] languages = new Language[]
            {
        new Language {Id = 1, Name = "English"},
        new Language {Id = 2, Name = "Russian"}
            };

            Person[] persons = new Person[]
            {
        new Person { LanguageId = 1, FirstName = "Tom" },
        new Person { LanguageId = 1, FirstName = "Sandy" },
        new Person { LanguageId = 2, FirstName = "Vladimir" },
        new Person { LanguageId = 2, FirstName = "Mikhail" },
            };

            var result = languages.GroupJoin(persons, lang => lang.Id, pers => pers.LanguageId,
                (lang, ps) => new { Key = lang.Name, Persons = ps });

            Console.WriteLine("Group-joined list of people speaking either English or Russian:");
            foreach (var language in result)
            {
                Console.WriteLine(String.Format("Persons speaking {0}:", language.Key));

                foreach (var person in language.Persons)
                {
                    Console.WriteLine(person.FirstName);
                }
            }
        }

        /// <summary>
        /// Joins two collections by a common key value, and is similar to inner join in SQL.
        /// This Lambda Expression sample joins two arrays where elements match in both.
        /// </summary>
        public static void Sample_Join_Lambda()
        {
            string[] warmCountries = { "Turkey", "Italy", "Spain", "Saudi Arabia", "Etiobia" };
            string[] europeanCountries = { "Denmark", "Germany", "Italy", "Portugal", "Spain" };

            var result = warmCountries.Join(europeanCountries, warm => warm, european => european, (warm, european) => warm);

            Console.WriteLine("Joined countries which are both warm and Europan:");
            foreach (var country in result) // Note: result is an anomymous type, thus must use a var to iterate.
                Console.WriteLine(country);
        }

    }


}
