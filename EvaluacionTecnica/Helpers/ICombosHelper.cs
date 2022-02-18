using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EvaluacionTecnica.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboCurrencyTypes();
        IEnumerable<SelectListItem> GetComboAccountTypes();
        IEnumerable<SelectListItem> GetComboStatuses();
        IEnumerable<SelectListItem> GetComboGenders();
    }
}
