﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NGO.Models;
using NGO.Models.ViewModel;
namespace NGO.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public int PageSize = 6;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        
        public ViewResult Index()
                => View(new ListViewModel
                {
                    Ngos = repository.ngos,
                    Articles = repository.articles,
                    Programmes = repository.programmes,
                    Galleries = repository.galleries
                });

        public ViewResult AboutUs()
=> View(new ListViewModel
{
    aboutUs = repository.aboutUs
});
        public ViewResult News(int newsPage = 1)
=> View(new ListViewModel
{
    Articles = repository.articles
    .OrderBy(p => p.Id)
               .Skip((newsPage - 1) * PageSize)
               .Take(PageSize),
    PageInfo = new PageInfo
    {
        CurrentPage = newsPage,
        ItemsPerPage = PageSize,
        TotalItems = repository.articles.Count()
    },
});

        public IActionResult ArticlePageDetail(int article_id)
=> View(new ListViewModel
{
    Articles = repository.articles.Where(a => a.Id == article_id)
});

        public IActionResult PartnerPageDetail(int partner_id)
=> View(new ListViewModel
{
    Ngos = repository.ngos.Where(a => a.Id == partner_id)
});


        public ViewResult Causes(int newsPage = 1)
=> View(new ListViewModel
{
    Programmes = repository.programmes
    .OrderBy(p => p.Id)
               .Skip((newsPage - 1) * PageSize)
               .Take(PageSize),
    PageInfo = new PageInfo
    {
        CurrentPage = newsPage,
        ItemsPerPage = PageSize,
        TotalItems = repository.programmes.Count()
    }
});
        public IActionResult ProgrammesPageDetail(int program_id)
=> View(new ListViewModel
{
Programmes = repository.programmes.Where(a => a.Id == program_id)
});
        public ViewResult Contact()
=> View(new ListViewModel
{

});
        public ViewResult Donate()
=> View(new ListViewModel
{

});
        public ViewResult Partner(int newsPage = 1)
=> View(new ListViewModel
{
    Ngos = repository.ngos
    .OrderBy(p => p.Id)
               .Skip((newsPage - 1) * PageSize)
               .Take(PageSize),
    PageInfo = new PageInfo
    {
        CurrentPage = newsPage,
        ItemsPerPage = PageSize,
        TotalItems = repository.ngos.Count()
    }

});

        public ViewResult Gallery()
=> View(new ListViewModel
{
    Galleries = repository.galleries,
    NumberGalleryPerRow = 4,
    GalleryColumns = (repository.galleries.Count()/4) + (repository.galleries.Count()%4 == 0 ? 0:1)
});

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
