using polyco.Domain.Entities;

namespace polyco.Persistence.Interfaces
{
    public interface ICustomersRepo
    {
        Task<List<Customer>> GetAll();
        Task<Customer> GetById(int id);
        Task<Customer> Create(Customer customer);
        Task<int> Update(int id, Customer customer);
        Task<int> Delete(int id);
    }
}