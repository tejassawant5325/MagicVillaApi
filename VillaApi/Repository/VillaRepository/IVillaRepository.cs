using System.Linq.Expressions;
using VillaApi.Models;
using VillaApi.Repository.IRepository;

namespace VillaApi.Repository.VillaRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
