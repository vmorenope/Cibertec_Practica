using Practica.Repositories.Credit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICorporationRepository Corpotarions { get; }
        IMemberRepository Members { get; }
    }
}
