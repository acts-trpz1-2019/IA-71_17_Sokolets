using System.Web;
using System.Web.Optimization;

namespace NDCShop
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;
            var jqueryCdnMagnific = "https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js";
            var jquetyCdnMagnific2 = "https://cdnjs.cloudflare.com/ajax/libs/magnific-popup.js/1.1.0/jquery.magnific-popup.min.js";
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            


            bundles.Add(new ScriptBundle("~/bundles/bootstrap", jqueryCdnMagnific).Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/section.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                              "~/Content/stylesheet.css",
                              "~/Content/signin.css"));
        }
    }
}
