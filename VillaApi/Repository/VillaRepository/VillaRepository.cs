﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VillaApi.Data;
using VillaApi.Models;
using VillaApi.Repository.IRepository;

namespace VillaApi.Repository.VillaRepository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
