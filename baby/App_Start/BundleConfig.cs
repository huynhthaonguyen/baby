using System.Web;
using System.Web.Optimization;

namespace baby
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/CSS/font_Muli.css",
                "~/Content/CSS/bootstrap.min.css",
                "~/Content/CSS/font-awesome.min.css",
                "~/Content/CSS/themify-icons.css",
                "~/Content/CSS/elegant-icons.css",
                "~/Content/CSS/owl.carousel.min.css",
                "~/Content/CSS/nice-select.css",    
                "~/Content/CSS/jquery-ui.min.css",
                "~/Content/CSS/slicknav.min.css",
                "~/Content/CSS/style.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Content/JS/jquery-3.3.1.min.js",
                "~/Content/JS/bootstrap.min.js",
                "~/Content/JS/jquery-ui.min.js",
                "~/Content/JS/jquery.countdown.min.js",
                "~/Content/JS/jquery.nice-select.min.js",
                "~/Content/JS/jquery.zoom.min.js",
                "~/Content/JS/jquery.dd.min.js",
                "~/Content/JS/jquery.slicknav.js",
                "~/Content/JS/owl.carousel.min.js",
                "~/Content/JS/main.js"
                ));
        }
    }
}
