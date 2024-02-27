using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace eUseControl.web.App_Start
{
    public class BundleConfig 
    {
        // GET: BundlConfig
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Home style
            bundles.Add(new StyleBundle("~/bundles/main/css").Include(
                      "~/assets/css/vendor/style.css", new CssRewriteUrlTransform()));

            // Animate.css
            bundles.Add(new StyleBundle("~/bundles/animate/css").Include(
                      "~/assets/css/plugins/animate.min.css", new CssRewriteUrlTransform()));

            // Pe-icon-7-stroke
            bundles.Add(new StyleBundle("~/bundles/peicon7stroke/css").Include(
                      "~/assets/css/plugins/pe-icon-7-stroke.css", new CssRewriteUrlTransform()));

            // Pe-icon-7-stroke
            bundles.Add(new StyleBundle("~/bundles/swiper-bundle.min/css").Include(
                      "~/assets/css/plugins/swiper-bundle.min.css", new CssRewriteUrlTransform()));


            // Font Awesome icons style
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include(
                      "~/assets/css/plugins/font-awesome.min.css", new CssRewriteUrlTransform()));
            //odometer
            bundles.Add(new StyleBundle("~/bundles/odometer/css").Include(
                      "~/assets/css/plugins/odometer.min.css", new CssRewriteUrlTransform()));

            //nice-select
            bundles.Add(new StyleBundle("~/bundles/nice-select/css").Include(
                      "~/assets/css/plugins/nice-select.css", new CssRewriteUrlTransform()));

            //select2
            bundles.Add(new StyleBundle("~/bundles/select2/css").Include(
                      "~/assets/css/plugins/select2.min.css", new CssRewriteUrlTransform()));
            //rangeSlider
            bundles.Add(new StyleBundle("~/bundles/rangeSlider/css").Include(
                      "~/assets/css/plugins/ion.rangeSlider.min.css", new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                "~/assets/css/style.css", new CssRewriteUrlTransform()));

            // < !--Scripts -->

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                      "~/assets/js/plugins/bootstrap.min.js"));

            // modernizr
            bundles.Add(new ScriptBundle("~/bundles/modernizr/js").Include(
                      "~/assets/js/vendor/modernizr-3.11.2.min.js"));

            // jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                      "~/assets/js/vendor/jquery-3.5.1.min.js"));

            // popper
            bundles.Add(new ScriptBundle("~/bundles/popper/js").Include(
                      "~/assets/js/plugins/popper.min.js"));

            // swiper-bundle
            bundles.Add(new ScriptBundle("~/bundles/swiper-bundle/js").Include(
                      "~/assets/js/plugins/swiper-bundle.min.js"));

            // ajax-contact
            bundles.Add(new ScriptBundle("~/bundles/ajax-contact/js").Include(
                      "~/assets/js/plugins/ajax-contact.js"));

            // appear
            bundles.Add(new ScriptBundle("~/bundles/appear/js").Include(
                      "~/assets/js/plugins/appear.js"));

            // odometer
            bundles.Add(new ScriptBundle("~/bundles/odometer/js").Include(
                      "~/assets/js/plugins/odometer.min.js"));

            // jquery.nice-select
            bundles.Add(new ScriptBundle("~/bundles/jquery.nice-select/js").Include(
                      "~/assets/js/plugins/jquery.nice-select.min.js"));

            // select2
            bundles.Add(new ScriptBundle("~/bundles/select2/js").Include(
                      "~/assets/js/plugins/select2.min.js"));

            // ion.rangeSlider
            bundles.Add(new ScriptBundle("~/bundles/ion.rangeSlider/js").Include(
                      "~/assets/js/plugins/ion.rangeSlider.min.js"));

            // jquery.zoom
            bundles.Add(new ScriptBundle("~/bundles/jquery.zoom/js").Include(
                      "~/assets/js/plugins/jquery.zoom.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                      "~/assets/js/main.js"));

        }
    }
}