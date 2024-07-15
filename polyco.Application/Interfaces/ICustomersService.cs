using polyco.Domain.Entities;

namespace polyco.Application.Interfaces
{
    public interface ICustomersService
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task<Customer> CreateAsync(Customer customer);
        Task<int> UpdateAsync(int id, Customer customer);
        Task<int> DeleteAsync(int id);
    }
}