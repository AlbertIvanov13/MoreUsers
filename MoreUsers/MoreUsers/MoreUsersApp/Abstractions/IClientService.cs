using MoreUsersApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreUsersApp.Abstractions
{
    public interface IClientService
    {
        List<Client> GetClients();

        bool CreateClient(string firstName, string lastName, string phone, string userId);
    }
}
