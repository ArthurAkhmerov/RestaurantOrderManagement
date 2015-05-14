using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ROM.Business.Entities;

namespace ROM.Data.Contracts
{
    public interface IAccountRepository
    {
        Account GetByLogin(string login);
    }
}
