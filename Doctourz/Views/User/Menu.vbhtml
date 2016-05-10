@Imports Microsoft.AspNet.Identity
@Code
    If (Request.IsAuthenticated) Then
        Try
            Dim userId = User.Identity.GetUserId
           
            System.Web.HttpContext.Current.Session("MyVariable") = userId
         
            Dim db = New ApplicationDbContext
            Dim appUser = db.AppUsers.Where(Function(x) x.userId = userId).First()
            
            ViewBag.Level = appUser.level
            ViewBag.appUserName = appUser.name
            ViewBag.appUserEmail = appUser.email
            ViewBag.avatar = appUser.avatar
        Catch ex As Exception
            
        End Try
    End If
End Code

<script src="~/Scripts/SideBar.js"></script>
<script>


    function submitForm(form) {
        $("#avatarForm").submit();
    }

    function loadPage(action) {
        $.post("/User/" + action, function (data) {
            $(".sidebar-body").html(data);
        });
    }
</script>
<div class="sidebar-child-close" id="sidebar-child" onmouseover="UnfoldSideBar()">
    <div class="col-xs-12 top-10 padd-5">
        <input type="text" value="empty" readonly class="hidden" id="currentSidebarChild" />
        <a class="_23 fwhite fhoverred1 point" onclick="CloseCover(),CloseSidebarChild(),FoldSideBar()">
            <i class="pull-right fa fa-close"></i>
        </a>
        <div class="sidebar-body col-xs-12 no-padd">

        </div>
    </div>
</div>
<div class="" id="transparent-cover" onclick="FoldSideBar(),CloseCover(),CloseSidebarChild()"></div>
<div class="navbar-default sidebar sidebar-close" id="sidebar" role="navigation" onmouseover="UnfoldSideBar()">
    <div class="sidebar-nav navbar-collapse">
        <div class="name-section">
               <form method="POST" action="/User/Upload" enctype="multipart/form-data" id="avatarForm">
                   <label>
                       <input type="file" name="file" id="avatar" onchange="submitForm('avatarForm')">
                       @If ViewBag.avatar = "" Then
                           @<img id="myAvatar" src="~/Content/Images/Website/dummy.jpg" class="img-responsive img-circle" style="margin:0 auto; max-width:100px; width: 90%;">
                       Else
                           @<img id="myAvatar" src="~/Images/@ViewBag.avatar" class="img-responsive img-circle" style="margin:0 auto; max-width:100px; width: 90%;">
                       End If
                   </label>
               </form>
            <div class="name-section top-10 hidden" id="name-section">
                <h4 class="text-center" id="userFullName">@ViewBag.appUserName.ToString</h4>
                <div class="name-section-button text-center">Get help now</div>
            </div>
        </div>
        <ul class="nav" id="side-menu">

            
                <a href="/User/ProfileView" style="text-decoration:none;color:white"><li id="sidelink12"><i class="fa fa-user"></i>Profile</li></a>
                <a href="/User/telemed2?room=room1" style="text-decoration:none;color:white"><li id="sidelink12"><i class="fa fa-refresh"></i>Call</li></a>
                <a href="/Question/Main" style="text-decoration:none;color:white"><li id="sidelink12"><i class="fa fa-refresh"></i>Logs</li></a>
                @If ViewBag.Level.Equals("Administrator") Then
                    @<a href="/NewUser/users" style="text-decoration:none;color:white"><li id="sidelink12"><i class="fa fa-users"></i>Users</li></a>
                End If

            @If Request.IsAuthenticated Then
                @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm"})
                    @Html.AntiForgeryToken
                    @<a href="javascript:document.getElementById('logoutForm').submit()" style="text-decoration:none;color:white"><li id="sidelink13" class=""><img src="~/Content/icons/sign-out.gif" />Log out</li></a>
                End Using
            End If

        </ul>
    </div>
    <!-- /.sidebar-collapse -->
</div>