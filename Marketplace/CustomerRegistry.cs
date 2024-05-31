using System.Collections.Generic;

namespace Marketplace
{
    public static class CustomerRegistry
    {
        private static Dictionary<string, Customer> customers = new Dictionary<string, Customer>();

        public static void Register(Customer customer)
        {
            if (!customers.ContainsKey(customer.Email))
            {
                customers[customer.Email] = customer;
            }
        }

        public static Customer GetCustomerByEmail(string email)
        {
            customers.TryGetValue(email, out var customer);
            return customer;
        }

        public static List<Customer> GetAllCustomers()
        {
            return new List<Customer>(customers.Values);
        }
    }
}
