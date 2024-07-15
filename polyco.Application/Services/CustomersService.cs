using polyco.Application.Interfaces;
using polyco.Domain.Entities;
using polyco.Persistence.Interfaces;

namespace polyco.Application.Services
{
    public class CustomersService : ICustomersService
    {
        private readonly ICustomersRepo _customersRepo;

        public CustomersService(ICustomersRepo customersRepo)
        {
            _customersRepo = customersRepo;
        }
        public async Task<Customer> CreateAsync(Customer customer)
        {
            return await _customersRepo.Create(customer);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _customersRepo.Delete(id);
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _customersRepo.GetAll();
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _customersRepo.GetById(id);
        }

        public async Task<int> UpdateAsync(int id, Customer customer)
        {
            return await _customersRepo.Update(id, customer);
        }
    }
}