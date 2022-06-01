using Microsoft.EntityFrameworkCore;
using Pronia.DAL;
using Pronia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronia.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<AnotherSetting> GetDatas()
        {

            AnotherSetting anothersetting = await _context.AnotherSettings.FirstOrDefaultAsync();
            return anothersetting;
        }
    }
}
