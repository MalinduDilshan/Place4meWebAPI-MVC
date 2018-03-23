using System.Web;
using System.Web.Optimization;

namespace Place4me
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/place4meStyle/js/jquery.min.js",
                        "~/Content/place4meStyle/js/jquery.easing.1.3.js",
                        "~/Content/place4meStyle/js/bootstrap.min.js",
                        "~/Content/place4meStyle/js/jquery.waypoints.min.js",
                        "~/Content/place4meStyle/js/owl.carousel.min.js",
                        "~/Content/place4meStyle/js/jquery.flexslider-min.js",
                        "~/Content/place4meStyle/js/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/place4meStyle/js/modernizr-2.6.2.min.js")); 

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/place4meStyle/css/animate.css",
                      "~/Content/place4meStyle/css/icomoon.css",
                      "~/Content/place4meStyle/css/bootstrap.css",
                      "~/Content/place4meStyle/css/flexslider.css",
                      "~/Content/place4meStyle/css/owl.carousel.min.css",
                      "~/Content/place4meStyle/css/owl.theme.default.min.css",
                      "~/Content/place4meStyle/css/style.css",
                      "~/Content/Site.css"));
        }
    }
}
