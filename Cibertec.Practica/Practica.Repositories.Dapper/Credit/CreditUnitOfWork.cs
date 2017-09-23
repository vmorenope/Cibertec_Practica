using Practica.UnitOfWork;
using Practica.Repositories.Credit;

namespace Practica.Repositories.Dapper.Credit
{
    public class CreditUnitOfWork : IUnitOfWork
    {
        public CreditUnitOfWork(string connectionString)
        {
            Corpotarions = new CorpotarionRepository(connectionString);
            Members = new MemberRepository(connectionString);
        }

        public ICorporationRepository Corpotarions { get; private set ; }
        public IMemberRepository Members { get; private set; }
    }
}
