﻿using CarService.DataAccess.Abstract;
using CarService.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DataAccess.Concrete
{
    public class AppRepository : IAppRepository
    {
        private readonly AppDataContext _context;

        public AppRepository(AppDataContext context)
        {
            _context = context;
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await _context.AddAsync<T>(entity);
        }

        public async Task DeleteAsync<T>(T entity) where T : class
        {
            await Task.Run(() =>
            {
                _context.Remove(entity);
            });
        }

        public async Task<List<Category>> GetAllCategory()
        {
            var details = await _context
                 .Category
                 .Include(c => c.Details)
                 .ToListAsync();

            return details;
        }

        public async Task<List<Detail>> GetAllDetails()
        {
            var details = await _context
                 .Details
                 .ToListAsync();
            return details;
        }

        public async Task<List<Detail>> GetAllDetailsByCategory(int id)
        {
            var details = await _context
                 .Details
                 .Where(d => d.CategoryId == id)
                 .ToListAsync();
            return details;
        }

        public async Task<Category> GetCategory(int id)
        {
            var details = await _context
                 .Category
                 .Include(c => c.Details)
                 .FirstOrDefaultAsync(x => x.Id == id);

            return details!;
        }

        public async Task<Detail> GetDetail(int id)
        {
            var details = await _context
                 .Details
                 .FirstOrDefaultAsync(d => d.Id == id);

            return details!;
        }

        public async Task<bool> SaveAllAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
