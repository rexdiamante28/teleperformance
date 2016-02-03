<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/old")
    @Scripts.Render("~/bundles/modernizr")
    <link href='https://fonts.googleapis.com/css?family=PT+Sans' rel='stylesheet' type='text/css'>

</head>
<body style="padding-top:0px;font-family: 'PT Sans', sans-serif;">
    <nav class="topbar">
        <div class="col-xs-12 no-padd">
            <a href="/Home/"><img id="logo" src="~/Content/Images/Website/logo_white.png" style="margin-left: 3%;width: 250px;"></a>
            <a href="/Account/Login" class="btn btn-warning pull-right top-10 no-radius no-border" style="margin-right:3%; margin-left: 5px !important;border-radius: 5px; background-color:#F26E23;">Sign In</a>
            <a href="/Home/About" class="btn btn-warning pull-right top-10 no-radius no-border" style="border-radius: 5px;background-color:#F26E23;">About</a>
        </div>
    </nav>
        @RenderBody()

    <div class="col-xs-12 no-padd text-center bggray5 padd-30">
        <ul id="social">
            <li id="social1"><a href="#"><img src="~/Content/Images/Website/px.gif" width="32" height="33"></a></li>
            <li id="social2"><a href="#"><img src="~/Content/Images/Website/px.gif" width="32" height="33"></a></li>
            <li id="social3"><a href="#"><img src="~/Content/Images/Website/px.gif" width="32" height="33"></a></li>
        </ul>
        <a class="fgray2 right-10 point">Terms of Service</a>
        <a class="fgray2 right-10 point">Privacy Policy</a>
        <a class="fgray2 right-10 point">Legal Disclaimers</a>
        <a class="fgray2 right-10 point">Contact us</a>
        <br /><br />
        <img src="~/Content/Images/Website/ft-logo.gif">
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")

    <script>
    $(document).ready(function () {

        Main = function main() {

            $(window).scroll(function () {
                if ($(".topbar").offset().top > 50) {
                    $(".topbar").addClass("bgwhite-trans padd-10");
                    document.getElementById('logo').setAttribute("src", "../Content/Images/Website/logo_blue.png");
                } else {
                    $(".topbar").removeClass("bgwhite-trans padd-10");
                    document.getElementById('logo').setAttribute("src", "../Content/Images/Website/logo_white.png");
                }
            });



        }
        Main();

    });

    </script>


    @RenderSection("scripts", required:=False)
</body>
</html>
