using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PYG.Common;
using PYG.DAO.Service;
using PYG.Models;

namespace PYG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(ILogger<HomeController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult GetNewGuid()
        {
            return Json(Guid.NewGuid());
        }

        public JsonResult GetTable()
        {
            var list = CategoryService.Instance.GetCategoryList();
            return Json(new { code = 200, msg = "获取成功", count = list?.Count(), data = list });
        }

        public JsonResult AddCategory(Guid id, string name, string icon, Guid parentId, int sortId)
        {
            if (string.IsNullOrWhiteSpace(name))
                return Json(new { code = 0, message = "名称不能为空!" });

            var count = CategoryService.Instance.AddCategory(id, name, icon, parentId, sortId);
            if (count > 0)
                return Json(new { code = 200, message = "添加成功!" });
            else
                return Json(new { code = 0, message = "添加失败!" });
        }

        public JsonResult DeleteCategory(Guid? id)
        {
            if (id == Guid.Empty)
                return Json(new { code = 0, message = "id为空!" });

            var count = CategoryService.Instance.DeleteCategory(id.Value, _hostingEnvironment.WebRootPath);
            if (count > 0)
                return Json(new { code = 200, message = "添加成功!" });
            else
                return Json(new { code = 0, message = "添加失败!" });
        }

        /// <summary>
        /// 上传图片
        /// </summary>
        /// <returns></returns>
        public IActionResult ImgUpload(Guid id, string name,  Guid parentId, int sortId)
        {
            if (string.IsNullOrWhiteSpace(name))
                return Json(new { code = 0, message = "名称不能为空!" });

            var imgFile = Request.Form.Files[0];
            if (imgFile != null && !string.IsNullOrEmpty(imgFile.FileName))
            {
                var filename = ContentDispositionHeaderValue
                                .Parse(imgFile.ContentDisposition)
                                .FileName
                                .Trim('"');
                var extname = filename.Substring(filename.LastIndexOf("."), filename.Length - filename.LastIndexOf("."));

                if (!extname.ToLower().Contains("jpg") && !extname.ToLower().Contains("png") && !extname.ToLower().Contains("gif"))
                    return Json(new { code = 1, msg = "只允许上传jpg,png,gif格式的图片.", });

                long mb = imgFile.Length / 1024 / 1024; 
                if (mb > 5)
                    return Json(new { code = 1, msg = "只允许上传小于 5MB 的图片.", });

                string fileName = "imager\\" + id + extname;
                string savePath = System.IO.Path.Combine(_hostingEnvironment.WebRootPath, fileName);
                using (FileStream fs = System.IO.File.Create(savePath))
                {
                    imgFile.CopyTo(fs);
                    fs.Flush();
                }

                var count = CategoryService.Instance.AddCategory(id, name, fileName, parentId, sortId);
                if (count > 0)
                    return Json(new { code = 200, message = "添加成功!" });
                else
                    return Json(new { code = 0, message = "添加失败!" });
            }
            return Json(new { code = 0, msg = "上传失败", });
        }
    }
}
