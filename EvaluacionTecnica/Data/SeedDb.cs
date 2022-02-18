using EvaluacionTecnica.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluacionTecnica.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckGenderAsync();
            await CheckStatusAsync();
            await CheckAccountTypeAsync();
            await CheckCurrencyTypeAsync();
        }

        private async Task CheckCurrencyTypeAsync()
        {
            if (!_context.CurrencyTypes.Any())
            {
                _context.CurrencyTypes.Add(new CurrencyType { Description = "Lempiras" });
                _context.CurrencyTypes.Add(new CurrencyType { Description = "Dolarés" });
                _context.CurrencyTypes.Add(new CurrencyType { Description = "Euros" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckAccountTypeAsync()
        {
            if (!_context.AccountTypes.Any())
            {
                _context.AccountTypes.Add(new AccountType { Description = "Ahorro" });
                _context.AccountTypes.Add(new AccountType { Description = "Cheques" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckStatusAsync()
        {
            if (!_context.Statuses.Any())
            {
                _context.Statuses.Add(new Status { Description = "Activo" });
                _context.Statuses.Add(new Status { Description = "Inactivo" });
                _context.Statuses.Add(new Status { Description = "Bloqueado" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckGenderAsync()
        {
            if (!_context.Genders.Any())
            {
                _context.Genders.Add(new Gender { Description = "Másculino" });
                _context.Genders.Add(new Gender { Description = "Femenino" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
