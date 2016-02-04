<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/user1")
    @Scripts.Render("~/bundles/modernizr")

   

</head>
<body class="bggray5" style="padding:0px!important;">
        <!-- Page Content -->
            @RenderBody()
        <!-- /#page-wrapper -->
  
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/user1")
    @RenderSection("scripts", required:=False)
</body>
</html>

