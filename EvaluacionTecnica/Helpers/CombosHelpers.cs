using EvaluacionTecnica.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace EvaluacionTecnica.Helpers
{
    public class CombosHelpers : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelpers(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetComboAccountTypes()
        {
            List<SelectListItem> list = _context.AccountTypes.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = $"{x.Id}"
            })
                 .OrderBy(x => x.Text)
                .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un tipo de cuenta...]",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboCurrencyTypes()
        {
            List<SelectListItem> list = _context.CurrencyTypes.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = $"{x.Id}"
            })
                  .OrderBy(x => x.Text)
                 .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un tipo de moneda...]",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboGenders()
        {
            List<SelectListItem> list = _context.Genders.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = $"{x.Id}"
            })
                  .OrderBy(x => x.Text)
                 .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un genero...]",
                Value = "0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboStatuses()
        {
            List<SelectListItem> list = _context.Statuses.Select(x => new SelectListItem
            {
                Text = x.Description,
                Value = $"{x.Id}"
            })
                 .OrderBy(x => x.Text)
                .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un estado...]",
                Value = "0"
            });
            return list;
        }
    }
}
