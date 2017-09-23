using Practica.Models;
using Practica.Repositories.Credit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Repositories.Dapper.Credit
{
    public class CorpotarionRepository : Repository<Corporation>, ICorporationRepository
    {
        public CorpotarionRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
