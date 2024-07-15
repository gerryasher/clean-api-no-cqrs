using Microsoft.EntityFrameworkCore;
using polyco.Domain.Entities;
using polyco.Persistence.Data;
using polyco.Persistence.Interfaces;

namespace polyco.Persistence.Repos
{
    public class CustomersRepo : ICustomersRepo
    {
        private readonly PolyCoDbContext _customerDbContext;

        public CustomersRepo(PolyCoDbContext customerDbContext)
        {
            _customerDbContext = customerDbContext;
        }
        public async Task<Customer> Create(Customer customer)
        {
            await _customerDbContext.Customers.AddAsync(customer);
            await _customerDbContext.SaveChangesAsync();
            return customer;
        }

        public async Task<int> Delete(int id)
        {
            return await _customerDbContext.Customers
                  .Where(model => model.Id == id)
                  .ExecuteDeleteAsync();
        }

        public async Task<List<Customer>> GetAll()
        {
            return await _customerDbContext.Customers.ToListAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await _customerDbContext.Customers.AsNoTracking()
               .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<int> Update(int id, Customer customer)
        {
            return await _customerDbContext.Customers
                  .Where(model => model.Id == id)
                  .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Id, customer.Id)
                    .SetProperty(m => m.BusinessName, customer.BusinessName)
                    .SetProperty(m => m.Street, customer.Street)
                    .SetProperty(m => m.City, customer.City)
                    .SetProperty(m => m.State, customer.State)
                    .SetProperty(m => m.Zip, customer.Zip)
                    .SetProperty(m => m.Phone, customer.Phone)
                    .SetProperty(m => m.Email, customer.Email)
                    .SetProperty(m => m.Industry, customer.Industry)
                    .SetProperty(m => m.BusinessType, customer.BusinessType)
                  );
        }
    }
}