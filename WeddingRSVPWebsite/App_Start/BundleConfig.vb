Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/jquery.min.js",
                  "~/Scripts/jquery.easing.1.3.js",
                  "~/Scripts/bootstrap.min.js",
                  "~/Scripts/jquery.waypoints.min.js",
                  "~/Scripts/owl.carousel.min.js",
                  "~/Scripts/jquery.countTo.js",
                  "~/Scripts/jquery.stellar.min.js",
                  "~/Scripts/jquery.magnific-popup.min.js",
                  "~/Scripts/magnific-popup-options.js",
                  "~/Scripts/simplyCountdown.js",
                  "~/Scripts/main.js",
                  "~/Scripts/bootstrap.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/icomoon.css",
                  "~/Content/magnific-popup.css",
                  "~/Content/owl.carousel.min.css",
                  "~/Content/owl.theme.default.min.css",
                  "~/Content/style.css",
                  "~/Content/site.css"))
    End Sub
End Module

