using PYG.Common;
using PYG.DAO.Entity;
using PYG.DAO.Service.Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PYG.DAO.Service
{
    /// <summary>
    /// 分类服务
    /// </summary>
    public class CategoryService : SingletonBase<CategoryService>
    {
        private CategoryService() { }

        public List<Category> GetCategoryList()
        {
            string domain = ConfigurationUtil.GetSection("Domain");
            var data = SqlHelper.Instance.Queryable<Category>().OrderBy(r => r.CreateTime, SqlSugar.OrderByType.Desc).ToList();
            data?.ForEach(item =>
            {
                item.Icon = $"{domain}{item.Icon}";
            });
            return data;
        }

        /// <summary>
        /// 添加分类信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="icon"></param>
        /// <param name="parentId"></param>
        /// <param name="sortId"></param>
        /// <returns></returns>
        public int AddCategory(Guid id, string name, string icon, Guid? parentId, int sortId)
        {
            Category model = new Category();
            model.ID = id;
            model.Name = name;
            model.Icon = icon;
            model.ParentId = parentId;
            model.SortId = sortId;
            model.IsDelete = 0;
            model.CreateTime = DateTime.Now;
            model.Creator = "胡汉三";
            return SqlHelper.Instance.Insertable(model).ExecuteCommand();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCategory(Guid id, string hosting)
        {
            var data = SqlHelper.Instance.Queryable<Category>().Where(r => r.ID == id).First();
            string imgPath = System.IO.Path.Combine(hosting, data?.Icon);
            if (File.Exists(imgPath))
                File.Delete(imgPath);
            return SqlHelper.Instance.Deleteable<Category>(it => it.ID == id).ExecuteCommand();
        }
    }
}
