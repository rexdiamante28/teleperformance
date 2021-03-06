﻿Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/respond.js"))

        bundles.Add(New ScriptBundle("~/bundles/user").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/User.js",
                  "~/Scripts/respond.js"))

        bundles.Add(New ScriptBundle("~/bundles/user1").Include(
                  "~/Scripts/bootstrap.js",
                  "~/Scripts/User1.js",
                  "~/Scripts/respond.js"))


        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/site.css",
                  "~/Content/custom.css"))

        bundles.Add(New StyleBundle("~/Content/user").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/User.css",
                  "~/Content/custom.css",
                  "~/font-awesome/css/font-awesome.css"))

        bundles.Add(New StyleBundle("~/Content/user1").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/User1.css",
                  "~/Content/custom.css",
                  "~/font-awesome/css/font-awesome.css"))

        bundles.Add(New StyleBundle("~/Content/old").Include(
                  "~/Content/bootstrap.css",
                  "~/Content/site.css",
                  "~/Content/custom.css",
                  "~/Content/old.css"))

    End Sub
End Module

