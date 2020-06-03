using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PYG.Common;
using PYG.DAO.Service;
using PYG.Models;

namespace PYG.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private string domain = ConfigurationUtil.GetSection("Domain");

        [HttpGet("GetCategoryList")]
        public IActionResult GetCategoryList()
        {
            return Ok(CategoryService.Instance.GetCategoryList());
        }

        private List<CategoryModel> GetCategories()
        {
            List<CategoryModel> list = new List<CategoryModel>();
            var model1 = new CategoryModel()
            {
                CatId = 1,
                CatName = "大家电",
                CatPid = 0,
                CatLevel = 0,
                CatDeleted = false,
                CatIcon = "",
                Children = new List<CategoryModel>()
                {
                    new CategoryModel(){ CatId=3,CatName="电视",CatPid=1,CatLevel=1,CatDeleted=false,CatIcon="",
                        Children=new List<CategoryModel>(){
                            new CategoryModel(){ CatId=5,CatName="曲面电视",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1001.jpg"},
                             new CategoryModel(){ CatId=5,CatName="海信",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1002.jpg"},
                              new CategoryModel(){ CatId=5,CatName="TCl",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1003.jpg"}, 
                            new CategoryModel(){ CatId=5,CatName="小米",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1001.jpg"},
                             new CategoryModel(){ CatId=5,CatName="HUAWEI",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1002.jpg"},
                              new CategoryModel(){ CatId=5,CatName="康佳",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1003.jpg"}
                    } },

                    new CategoryModel(){ CatId=3,CatName="空调",CatPid=1,CatLevel=1,CatDeleted=false,CatIcon="",
                        Children=new List<CategoryModel>(){
                            new CategoryModel(){ CatId=5,CatName="格力空调",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1001.jpg"},
                             new CategoryModel(){ CatId=5,CatName="海尔",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1002.jpg"},
                              new CategoryModel(){ CatId=5,CatName="移动空调",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1003.jpg"},
                            new CategoryModel(){ CatId=5,CatName="小米",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1001.jpg"},
                             new CategoryModel(){ CatId=5,CatName="HUAWEI",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1002.jpg"},
                              new CategoryModel(){ CatId=5,CatName="康佳",CatPid=3,CatLevel=2,CatDeleted=false,CatIcon=$"{domain}/imager/1003.jpg"}
                    } }


                }
            };
            list.Add(model1);
            return list;
        }
    }
}