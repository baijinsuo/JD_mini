using System;
using System.Collections.Generic;
using System.Text;

namespace PYG.DAO.Entity
{
    /// <summary>
    /// 分类
    /// </summary>
    public class Category : BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 父级ID
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// 排序Id
        /// </summary>
        public int? SortId { get; set; }

        /// <summary>
        /// 删除状态
        /// </summary>
        public int IsDelete { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator { get; set; }
    }
}
