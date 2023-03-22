using LINQITöö;

namespace LINQITöö
{
    public class GenderList
    {
        public static readonly List<Gender> genderList = new List<Gender>
        {
            new Gender()
            {
                Id = Guid.Parse("c284a971-0248-4401-a2fe-2d1e369a94ae"),
                Sex = "male"
            },
            new Gender()
            {
                Id = Guid.Parse("4050ad99-098c-43f0-a1f5-96065c0cc153"),
                Sex = "female"
            },
        };
    }
}
