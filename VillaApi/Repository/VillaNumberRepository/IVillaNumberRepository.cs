using VillaApi.Models;
using VillaApi.Repository.IRepository;

namespace VillaApi.Repository.VillaNumberRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
