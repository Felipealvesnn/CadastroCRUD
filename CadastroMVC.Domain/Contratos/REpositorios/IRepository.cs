using CadastroMVC.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CadastroMVC.Domain.Contratos.REpositorios
{
    public interface IRepository<t> : IDisposable where t : Entity
    {
        IEnumerable<t> Retornatodos();
        t Get(int id);

        void Add(t entity);
        void Delete(t entity);
        void Edit(t eentity);

    }
}
