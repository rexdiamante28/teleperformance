<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/user")
    @Scripts.Render("~/bundles/modernizr")

   

</head>
<body class="bggray5">
        <!-- Page Content -->
            @RenderBody()
        <!-- /#page-wrapper -->
  
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/user")
    @RenderSection("scripts", required:=False)
</body>
</html>

