using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PYG.Common;
using PYG.Models;

namespace PYG.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private string domain = ConfigurationUtil.GetSection("Domain");

        [HttpGet("GetCarouselList")]
        public IActionResult GetCarouselList()
        {
            return Ok(GetCarousels());
        }

        [HttpGet("GetCateList")]
        public IActionResult GetCateList()
        {
            return Ok(GetCatItems());
        }

        [HttpGet("GetCateList1")]
        public IActionResult GetCateList1()
        {
            return Ok(GetCatItemsPng());
        }

        [HttpGet("GetStairsList")]
        public IActionResult GetStairsList()
        {
            return Ok(GetStairsItems());
        }

        private List<CarouselModel> GetCarousels()
        {
            return new List<CarouselModel>()
            {
               new CarouselModel(){ GoodsId=1001,ImagerUrl=$"{domain}imager/01.jpg",NavigatorUrl="/page/goods_details/index?goods_id=1001",OpenType="navigate"},
               new CarouselModel(){ GoodsId=1002,ImagerUrl=$"{domain}imager/02.jpg",NavigatorUrl="/page/goods_details/index?goods_id=1002",OpenType="navigate"},
               new CarouselModel(){ GoodsId=1003,ImagerUrl=$"{domain}imager/03.jpg",NavigatorUrl="/page/goods_details/index?goods_id=1003",OpenType="navigate"},
               new CarouselModel(){ GoodsId=1004,ImagerUrl=$"{domain}imager/04.jpg",NavigatorUrl="/page/goods_details/index?goods_id=1004",OpenType="navigate"},
               new CarouselModel(){ GoodsId=1005,ImagerUrl=$"{domain}imager/05.jpg",NavigatorUrl="/page/goods_details/index?goods_id=1005",OpenType="navigate"},
               new CarouselModel(){ GoodsId=1006,ImagerUrl=$"{domain}imager/06.jpg",NavigatorUrl="/page/goods_details/index?goods_id=1006",OpenType="navigate"},
               new CarouselModel(){ GoodsId=1007,ImagerUrl=$"{domain}imager/07.jpg",NavigatorUrl="/page/goods_details/index?goods_id=1007",OpenType="navigate"},
               new CarouselModel(){ GoodsId=1008,ImagerUrl=$"{domain}imager/08.jpg",NavigatorUrl="/page/goods_details/index?goods_id=1008",OpenType="navigate"},
            };
        }
        private List<CatItemsModel> GetCatItemsPng()
        {
            return new List<CatItemsModel>()
            {
                new CatItemsModel(){Name="分类",ImagerSrc=$"{domain}imager/icon_index_nav_1.png",NavigatorUrl="/pages/category/index",OpenType="switchTab" },
                new CatItemsModel(){Name="秒杀拍",ImagerSrc=$"{domain}imager/icon_index_nav_2.png" },
                new CatItemsModel(){Name="超市购",ImagerSrc=$"{domain}imager/icon_index_nav_3.png"},
                new CatItemsModel(){Name="母婴品",ImagerSrc=$"{domain}imager/icon_index_nav_4.png"}
            };
        }

        private List<CatItemsModel> GetCatItems()
        {
            return new List<CatItemsModel>()
            {
                new CatItemsModel(){Name="分类",ImagerSrc=$"{domain}imager/icon_index_nav_1.svg",NavigatorUrl="/pages/category/index",OpenType="switchTab" },
                new CatItemsModel(){Name="秒杀拍",ImagerSrc=$"{domain}imager/icon_index_nav_2.svg" },
                new CatItemsModel(){Name="超市购",ImagerSrc=$"{domain}imager/icon_index_nav_3.svg"},
                new CatItemsModel(){Name="母婴品",ImagerSrc=$"{domain}imager/icon_index_nav_4.svg"}
            };
        }

        private List<StairsModel> GetStairsItems()
        {
            List<StairsModel> list = new List<StairsModel>();
            var stairs1 = new StairsModel
            {
                FloorTitle = new FloorTitle() { Name = "时尚女装", ImagerSrc = $"{domain}imager/pic_floor_title01.png" },
                ProductLists = new List<ProductModel>()
                {
                    new ProductModel(){ Name="优质服饰",ImagerSrc=$"{domain}imager/pic_floor_01.jpg",ImagerWidth=232,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                     new ProductModel(){ Name="春季热门",ImagerSrc=$"{domain}imager/pic_floor_02.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                      new ProductModel(){ Name="爆款清仓",ImagerSrc=$"{domain}imager/pic_floor_03.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                       new ProductModel(){ Name="倒春寒",ImagerSrc=$"{domain}imager/pic_floor_04.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                        new ProductModel(){ Name="倒春寒",ImagerSrc=$"{domain}imager/pic_floor_05.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"}
                }
            };


            var stairs2 = new StairsModel
            {
                FloorTitle = new FloorTitle() { Name = "户外运动", ImagerSrc = $"{domain}imager/pic_floor_title02.png" },
                ProductLists = new List<ProductModel>()
                {
                    new ProductModel(){ Name="优质服饰",ImagerSrc=$"{domain}imager/pic_floor_06.jpg",ImagerWidth=232,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                     new ProductModel(){ Name="春季热门",ImagerSrc=$"{domain}imager/pic_floor_07.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                      new ProductModel(){ Name="爆款清仓",ImagerSrc=$"{domain}imager/pic_floor_08.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                       new ProductModel(){ Name="倒春寒",ImagerSrc=$"{domain}imager/pic_floor_09.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                        new ProductModel(){ Name="倒春寒",ImagerSrc=$"{domain}imager/pic_floor_10.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"}
                }
            };

            var stairs3 = new StairsModel
            {
                FloorTitle = new FloorTitle() { Name = "箱包配饰", ImagerSrc = $"{domain}imager/pic_floor_title03.png" },
                ProductLists = new List<ProductModel>()
                {
                    new ProductModel(){ Name="优质服饰",ImagerSrc=$"{domain}imager/pic_floor_11.jpg",ImagerWidth=232,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                     new ProductModel(){ Name="春季热门",ImagerSrc=$"{domain}imager/pic_floor_12.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                      new ProductModel(){ Name="爆款清仓",ImagerSrc=$"{domain}imager/pic_floor_13.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                       new ProductModel(){ Name="倒春寒",ImagerSrc=$"{domain}imager/pic_floor_14.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"},
                        new ProductModel(){ Name="倒春寒",ImagerSrc=$"{domain}imager/pic_floor_15.jpg",ImagerWidth=233,OpenType="navigate",NavigatorUrl="/pages/goods_list/index?query='服饰'"}
                }
            };


            list.Add(stairs1);
            list.Add(stairs2);
            list.Add(stairs3);
            return list;
        }
    }
}