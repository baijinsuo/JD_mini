using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PYG.Models
{
    public class CarouselModel
    {
        public string ImagerUrl { get; set; }

        public string OpenType { get; set; }

        public long GoodsId { get; set; }

        public string NavigatorUrl { get; set; }
    }

    public class CatItemsModel
    { 
        public string Name { get; set; }

        public string ImagerSrc { get; set; }

        public string OpenType { get; set; }

        public string NavigatorUrl { get; set; }
    }

    public class StairsModel
    { 
        public FloorTitle FloorTitle { get; set; }

        public List<ProductModel> ProductLists { get; set; }
    }

    public class FloorTitle
    { 
        public string Name { get; set; }

        public string ImagerSrc { get; set; }
    }

    public class ProductModel
    { 
        public string Name { get; set; }

        public string ImagerSrc { get; set; }

        public double ImagerWidth { get; set; }

        public string OpenType { get; set; }

        public string NavigatorUrl { get; set; }
    }
}
