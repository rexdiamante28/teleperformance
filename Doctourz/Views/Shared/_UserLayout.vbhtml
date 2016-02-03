<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Doctourz</title>
    @Styles.Render("~/Content/user")
    <link href='https://fonts.googleapis.com/css?family=PT+Sans' rel='stylesheet' type='text/css'>

 </head>
<body class="bggray5" style="padding-top:0px;font-family: 'PT Sans', sans-serif;">
    <div id="telemedCover" class="hidden" onmouseover="FoldSideBar()">
        <input type="text" value="empty" id="currentBottomBar" class="hidden" />
    </div>
    <div id="wrapper">
        <!-- MENU -->
        @Html.Action("Menu", "User")

        <!-- Page Content -->
        <div id="page-wrapper" class="bggray5" onmouseover="FoldSideBar()">
            <nav class="navbar bgwhite no-radius">
                <div class="container-fluid">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-2">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="fa fa-bars fa-2x custom-fblue"></span>
                        </button>
                        <a class="navbar-brand no-padd" href="#"><img src="~/Content/Images/Website/logo_blue.png" style="width:240px;" /></a>
                    </div>
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
                        <ul class="nav navbar-nav"></ul>
                        <ul class="nav navbar-nav navbar-right">
                            <li id="topbar0"><a href="/user/telemed2?room=room1"><i class="fa fa-video-camera "></i><br />Telemed</a></li>
                            <li id="topbar1"><a href="#"><i class="fa fa-user-md "></i><br />Ask Doctor</a></li>
                            <li id="topbar2"><a href="/user/news"><i class="fa fa-newspaper-o "></i><br />News</a></li>
                            <li id="topbar3"><a href="/user/search"><i class="fa fa-search "></i><br />Search</a></li>
                            <li id="topbar4"><a href="#"><img src="~/Content/icons/dma.gif" /><br />To-Do</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
            @RenderBody()
        </div>
        <!-- /#page-wrapper -->
    </div>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/user")
    @RenderSection("scripts", required:=False)

</body>
</html>

