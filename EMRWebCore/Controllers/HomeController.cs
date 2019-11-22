using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EMRWebCore.Models;
using Newtonsoft.Json;

namespace EMRWebCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmrSee(string param)
        {
            if (!string.IsNullOrEmpty(param))
            {
                var model = JsonConvert.DeserializeObject<SystemSettingModel>(param);
                if (model != null)
                {
                    ViewBag.zyId = model.zyId;
                    ViewBag.serviceUrl = model.serviceUrl;
                    ViewBag.departmentId = model.departmentId;
                    ViewBag.departmentName = model.departmentName;
                    ViewBag.doctorId = model.doctorId;
                    ViewBag.doctorName = model.doctorName;
                    ViewBag.orgId = model.orgId;
                    ViewBag.orgName = model.orgName;
                    return View();
                }
            }

            ViewData["Error"] = "参数不能为空!";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}