using EvaluacionTecnica.Data;
using EvaluacionTecnica.Data.Entities;
using EvaluacionTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvaluacionTecnica.Helpers
{
    public class ConverterHelper : IConverterHelper
    {

        private readonly DataContext _context;
        private readonly ICombosHelper _combosHelper;

        public ConverterHelper(DataContext context, ICombosHelper combosHelper)
        {
            _context = context;
            _combosHelper = combosHelper;
        }

        public async Task<Customer> ToCustomerAsync(CustomerViewModel model, bool isNew)
        {
            return new Customer
            {
                Address = model.Address,
                Id = isNew ? 0 : model.Id,
                BirthDay = model.BirthDay,
                FirstName = model.FirstName,
                LastName = model.LastName,
                City = model.City,
                Code = model.Code,
                Gender = await _context.Genders.FindAsync(model.GenderId),
                Identidad = model.Identidad,                               
            };
        }

        public CustomerViewModel ToCustomerViewModel(Customer customer)
        {
            return new CustomerViewModel
            {
                Address = customer.Address,
                BirthDay = customer.BirthDay,
                City = customer.City,
                Code = customer.Code,
                FirstName = customer.FirstName,
                GenderId = customer.Gender.Id,
                Genders = _combosHelper.GetComboGenders(),
                Gender = customer.Gender,
                Id = customer.Id,
                Identidad = customer.Identidad,
                LastName = customer.LastName
            };
        }
    }
}
