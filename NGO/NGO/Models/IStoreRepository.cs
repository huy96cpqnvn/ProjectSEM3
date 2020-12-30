using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models
{
    public interface IStoreRepository
    {
        IQueryable<AboutUs> aboutUs { get;}
        IQueryable<Donate>  donates { get;}
        IQueryable<Gallery> galleries { get; }
        IQueryable<Article> articles { get; }
        IQueryable<Ngo> ngos { get; }
        IQueryable<Programme> programmes { get;}

    }
}
