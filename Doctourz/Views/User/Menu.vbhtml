@Imports Microsoft.AspNet.Identity
@Code
    If (Request.IsAuthenticated) Then
        Dim userId = User.Identity.GetUserId
        Dim db = New ApplicationDbContext
        Dim appUser = db.AppUsers.Where(Function(x) x.userId = userId).First()
        ViewBag.appUserName = appUser.name
        ViewBag.appUserEmail = appUser.email
        ViewBag.avatar = appUser.avatar
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
            <li id="sidelink1" onclick="SidebarChildDecide(this.id); loadPage('Notifications')" ><i class="fa fa-bell-o"></i>Notifications</li>
            <li id="sidelink2" onclick="SidebarChildDecide(this.id); loadPage('HealthProfile');" ><i class="fa fa-user"></i>Health Profile</li>
            <li id="sidelink3" onclick="SidebarChildDecide(this.id); loadPage('Dma')" class="side-menu-link"><img src="~/Content/icons/dma-white.gif" />DMA</li>
            <li id="sidelink4" onclick="SidebarChildDecide(this.id); loadPage('Dma')" ><i class="fa fa-user-md"></i>Consults</li>
            <li id="sidelink5" onclick="SidebarChildDecide(this.id); loadPage('Dma')" ><i class="fa fa-wechat"></i>Answer</li>
            <li id="sidelink6" onclick="SidebarChildDecide(this.id); loadPage('Dma')" ><i class="fa fa-users"></i>Doctors Matches</li>
            <li id="sidelink7" onclick="SidebarChildDecide(this.id); loadPage('Dma')" ><i class="fa fa-folder-o"></i>Files</li>
            <li id="sidelink8" onclick="SidebarChildDecide(this.id); loadPage('Dma')" ><i class="fa fa-file-text-o"></i>Topics</li>
            <li id="sidelink9" onclick="SidebarChildDecide(this.id); loadPage('Dma')" ><i class="fa fa-user-plus"></i>People You Care For</li>
            <li id="sidelink10" onclick="SidebarChildDecide(this.id); loadPage('Dma')" ><i class="fa fa-envelope-o"></i>Invite Friends and Family</li>
            <li id="sidelink11" onclick="SidebarChildDecide(this.id); loadPage('Dma')" ><i class="fa fa-question-circle"></i>Help and Support</li>
            <a href="/Question/Main" style="text-decoration:none;color:white"><li id="sidelink12"><i class="fa fa-cog"></i>Settings</li></a>
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