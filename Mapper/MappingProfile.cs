using AutoMapper;
using issueTracker.Controllers.Resources;
using issueTracker.Models;

namespace issueTracker.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
         CreateMap<Category,CategoryResource>();   
        }
    }
}