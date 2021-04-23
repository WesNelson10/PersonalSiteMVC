using System.Web;
using System.Web.Optimization;

namespace PersonalSiteMVC.UI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));           

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                      "~/Content/vendor/icofont/icofont.min.css",
                      "~/Content/vendor/remixicon/remixicon.css",
                      "~/Content/vendor/owl.carousel/assets/owl.carousel.min.css",
                      "~/Content/vendor/boxicons/css/boxicons.min.css",
                      "~/Content/vendor/venobox/venobox.css",
                      "~/Content/vendor/bootstrap/css/style.css"));
        }
    }
}
