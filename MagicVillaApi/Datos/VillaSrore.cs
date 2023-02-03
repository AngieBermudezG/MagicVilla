using MagicVillaApi.Dto;

namespace MagicVillaApi.Datos
{
    public class VillaSrore
    {
        public static List<VillaDto> ListTheVilla = new List<VillaDto>
        {
            new VillaDto
                {
                    Id = 1,
                    Name =  "Vista a la piscina"
                },
                new VillaDto
                {
                    Id = 2,
                    Name = "Vista a la playa"
                },
                new VillaDto
                {
                    Id = 3,
                    Name = "Vista al norte"
                }
        };
    }
}
