using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PYG.Models;

namespace PYG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {




        private List<CategoryModel> GetCategories()
        {
            List<CategoryModel> list = new List<CategoryModel>();

            var model1 = new CategoryModel()
            {
                CatId=1,
                CatName="大家电",
                CatPid=0,
                CatLevel=0,
                CatDeleted=false,
                CatIcon="",
                Children=new List<CategoryModel>()
                { 
                    new CategoryModel(){ CatId=3,CatName="电视",CatPid=1,CatLevel=1,CatDeleted=false,CatIcon="",
                        Children=new List<CategoryModel>(){
                            new CategoryModel(){ CatId=5,CatName="曲面电视",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=""}
                    
                    } }
                }
            };
            return list;
        }
    }
}