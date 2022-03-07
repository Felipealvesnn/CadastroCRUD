using CadastroMVC.Domain.Entities;
using CadastroMVC.Domain.Contratos.REpositorios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastroMVC.Data.EF.Repositories
{
    public class RepositoryEf<t> : IRepository<t> where t : Entity
    {

        protected readonly DbContexto _ctx;
        public RepositoryEf(DbContexto ctx)
        {
            _ctx = ctx;

        }

        public IEnumerable<t> Retornatodos()
        {
            return _ctx.Set<t>().ToList();
        }

        public t Get(int id)
        {

            return _ctx.Set<t>().Find(id);
        }

        public void Add(t entity)
        {

            _ctx.Set<t>().Add(entity);
            save();
        }

        public void Edit(t eentity)
        {
            _ctx.Entry(eentity).State = System.Data.Entity.EntityState.Modified;

            save();
        }

        public void Delete(t entity)
        {

            _ctx.Set<t>().Remove(entity);
            save();

        }

        private void save()
        {
            _ctx.SaveChanges();

        }


        public void Dispose()
        {
           
        }

    }
}


