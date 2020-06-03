using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PYG.Models
{
    /// <summary>
    ///分类
    /// </summary>
    public class CategoryModel
    {
        public int CatId { get; set; }

        public string CatName { get; set; }

        public int CatPid { get; set; }

        public int CatLevel { get; set; }

        public bool CatDeleted { get; set; }

        public string CatIcon { get; set; }

        public List<CategoryModel> Children { get; set; }
    }
}
