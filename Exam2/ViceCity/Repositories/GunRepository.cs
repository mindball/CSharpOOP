using System;
using System.Collections.Generic;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        public IReadOnlyCollection<IGun> Models { get; }

        public void Add(IGun model)
        {
            throw new NotImplementedException();
        }

        public IGun Find(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IGun model)
        {
            throw new NotImplementedException();
        }
    }
}
