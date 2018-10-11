using ELearningSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningSystem.Views.BaseViewPage
{
    public abstract class BaseViewPage : WebViewPage
    {
        public virtual new Student User
        {
            get { return Session["USER"] as Student; }
        }
    }

    public abstract class BaseViewPage<TModel> : WebViewPage<TModel>
    {
        public virtual new Student User
        {
            get { return Session["USER"] as Student; }
        }
    }
}