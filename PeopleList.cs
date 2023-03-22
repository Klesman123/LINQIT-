using LINQITöö;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQITöö
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Tiina",
                Age = 31,
                GenderId = Guid.Parse("4050ad99-098c-43f0-a1f5-96065c0cc153")
            },
            new People()
            {
                Id = 2,
                Name = "Miina",
                Age = 21,
                GenderId = Guid.Parse("4050ad99-098c-43f0-a1f5-96065c0cc153")
            },
            new People()
            {
                Id = 3,
                Name = "Ülo",
                Age = 18,
                GenderId = Guid.Parse("c284a971-0248-4401-a2fe-2d1e369a94ae")
            },
            new People()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("4050ad99-098c-43f0-a1f5-96065c0cc153")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("4050ad99-098c-43f0-a1f5-96065c0cc153")
            },
            new People()
            {
                Id = 6,
                Name = "Annika",
                Age = 40,
                GenderId = Guid.Parse("4050ad99-098c-43f0-a1f5-96065c0cc153")
            },
            new People()
            {
                Id = 7,
                Name = "Jaanus",
                Age = 23,
                GenderId = Guid.Parse("c284a971-0248-4401-a2fe-2d1e369a94ae")
            }
        };
    }
}
