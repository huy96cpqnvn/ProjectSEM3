using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models
{
    public interface IStoreRepository
    {
        IQueryable<New> News { get;}
        IQueryable<Programme> Programmes { get;}
        IQueryable<Donate> Donates { get; }
        IQueryable<Gallery> Galleries { get;}
        IQueryable<AboutUs> AboutUs { get;}
        IQueryable<Ngo> Ngos { get;}
    }
}
