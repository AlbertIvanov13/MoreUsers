using MoreUsersApp.Abstractions;
using MoreUsersApp.Data;
using MoreUsersApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreUsersApp.Services
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext _context;

        public ClientService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool CreateClient(string firstName, string lastName, string phone, string userId)
        {
            if (_context.Clients.Any(p => p.UserId == userId))
            {
                throw new InvalidOperationException("Client already exists.");
            }
            Client clientfromDb = new Client()
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                UserId = userId
            };

            _context.Clients.Add(clientfromDb);

            return _context.SaveChanges() != 0;
        }

        public List<Client> GetClients()
        {
            throw new NotImplementedException();
        }
    }
}
