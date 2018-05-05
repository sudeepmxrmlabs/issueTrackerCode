using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using issueTracker.Controllers.Resources;
using issueTracker.Models;
using issueTracker.persistence;
using Microsoft.AspNetCore.Mvc;

namespace issueTracker.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IssueDbContext dbCtx;
        private readonly IMapper maper;
        public CategoriesController(IssueDbContext dbCtx, IMapper maper)
        {
            this.maper = maper;
            this.dbCtx = dbCtx;

        }
        [HttpGet("/api/Categories")]
        public IEnumerable<CategoryResource> GetCategories()
        {
            var maker =  dbCtx.Categories.ToList();
            return maper.Map<List<Category>,List<CategoryResource>>(maker);
        }
    }
}