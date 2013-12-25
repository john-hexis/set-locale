﻿using System;
using System.Web.Mvc;
using SetLocale.Client.Web.Models;

namespace SetLocale.Client.Web.Controllers
{
    public class AjaxController : BaseController
    {
        [HttpPost, ValidateAntiForgeryToken]
        public JsonResult NewToken(int appId)
        {
            var token = new TokenModel
            {
                CreationDate = DateTime.Now,
                CreationDateStr = DateTime.Now.ToString("f"),
                UsageCount = 1,
                Token = Guid.NewGuid().ToString().Replace("-", "")
            };

            return Json(token, JsonRequestBehavior.DenyGet);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public JsonResult DeleteToken(string token)
        {
            var model = new ResponseModel
            {
                Msg = "ok...",
                Ok = true
            };

            return Json(model, JsonRequestBehavior.DenyGet);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public JsonResult ChangeUserStatus(int id, bool isActive)
        {
            var model = new ResponseModel
            {
                Msg = "ok...",
                Ok = true
            };

            return Json(model, JsonRequestBehavior.DenyGet);
        }
    }

}