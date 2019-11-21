﻿using System.Web;
using System.Web.Optimization;

namespace NetFlask
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Css")
                .Include("~/Content/bootstrap.css",
                "~/css/style.css"));

            

            bundles.Add(new ScriptBundle("~/Scripts/jquery")
                .Include("~/js/jquery.min.js")
                );


            bundles.Add(new ScriptBundle("~/Scripts/Flexi1")
                .Include("~/js/FlexiselDemo1.js")
                );
            bundles.Add(new ScriptBundle("~/Scripts/Flexi2")
               .Include("~/js/FlexiselDemo2.js")
               );
            bundles.Add(new ScriptBundle("~/Scripts/Flexisel")
                .Include("~/js/jquery.flexisel.js")
                );

            //pour ajouter popup dans videos
            bundles.Add(new StyleBundle("~/Content/PopUp")
                .Include("~/css/popuo-box.css"));

            bundles.Add(new ScriptBundle("~/Scripts/Magnific-PopUp")
                .Include("~/js/jquery.magnific-popup.js"
                ));
        }
    }
}