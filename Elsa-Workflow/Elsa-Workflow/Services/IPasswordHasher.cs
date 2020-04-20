using Elsa_Workflow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elsa_Workflow.Services
{
    interface IPasswordHasher
    {   
        HashedPassword HashPassword(string password);

        HashedPassword HashPassword(string password, byte[] salt);
    }
}
