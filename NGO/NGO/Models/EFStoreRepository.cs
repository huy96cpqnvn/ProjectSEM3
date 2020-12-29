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

        public IQueryable<AboutUs> aboutUs => context.AboutUs;
        public IQueryable<Donate> donates => context.Donates;
        public IQueryable<Gallery> galleries => context.Galleries;
        public IQueryable<New> news => context.News;
        public IQueryable<Ngo> ngos => context.Ngos;
        public IQueryable<Programme> programmes => context.Programmes;

        
    }
}
 