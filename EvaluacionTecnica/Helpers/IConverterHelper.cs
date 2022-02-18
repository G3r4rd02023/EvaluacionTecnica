using EvaluacionTecnica.Data.Entities;
using EvaluacionTecnica.Models;
using System.Threading.Tasks;

namespace EvaluacionTecnica.Helpers
{
    public interface IConverterHelper
    {
        Task<Customer> ToCustomerAsync(CustomerViewModel model, bool isNew);
        CustomerViewModel ToCustomerViewModel(Customer customer);
    }
}
