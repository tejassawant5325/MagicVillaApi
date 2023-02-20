using VillaApi.Models.DTO;

namespace VillaApi.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new()
        {
            new VillaDTO{ Id = 1,Name="Pool View",Sqft=1000,Occupancy=4},
            new VillaDTO{ Id = 2,Name="Beach View",Sqft=2000,Occupancy=6}
        };
    }
}
