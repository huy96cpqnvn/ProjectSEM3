using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDBContext context;
        public EFStoreRepository(StoreDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<AboutUs> AboutUs => context.AboutUs;
        public IQueryable<Donate> Donates => context.Donates;
        public IQueryable<Gallery> Galleries => context.Galleries;
        public IQueryable<New> News => context.News;
        public IQueryable<Ngo> Ngos => context.Ngos;
        public IQueryable<Programme> Programmes => context.Programmes;
    }
}
 