@Imports Microsoft.AspNet.Identity
@Code
    Layout = "~/Views/Shared/_UserLayoutBlank.vbhtml"
    
    Dim db = New ApplicationDbContext
    Dim appUser As String = User.Identity.GetUserName
    Dim name = db.AppUsers.Where(Function(model) model.userName = appUser).First().name
    

    ViewData("Name") = name
End Code
<div class="login bgwhite top-100">
    <div class="col-xs-12 padd-30 bgwhite no-padd text-center top-10">
        <h3 class="">Complete your profile</h3>
        <b class="normal fgray3">Help doctors help you better</b>
        <div class="row top-20">
            <div class="col-xs-6 padd-5">
                <div class="colx-s-12 " style="background-color: #F3FDFF; padding: 10px 5px; height: 120px;">
                    <i class="fa fa-user" style="font-size:40px; color: #326799;"></i><br />
                    <b class="fgray3 _12">Professional guidance from leading global physician</b>
                </div>
            </div>
            <div class="col-xs-6 padd-5">
                <div class="colx-s-12 " style="background-color: #F3FDFF; padding: 10px 5px; height: 120px;">
                    <i class="fa fa-phone" style="font-size:40px; color: #326799;"></i><br />
                    <b class="fgray3 _12">24/7 on call medical staff</b>
                </div>
            </div>
            <div class="col-xs-6 padd-5">
                <div class="colx-s-12 " style="background-color: #F3FDFF; padding: 10px 5px; height: 120px;">
                    <i class="fa fa-feed" style="font-size:40px; color: #326799;"></i><br />
                    <b class="fgray3 _12">Customize your news health feed</b>
                </div>
            </div>
            <div class="col-xs-6 padd-5">
                <div class="colx-s-12 " style="background-color: #F3FDFF; padding: 10px 5px; height: 120px;">
                    <i class="fa fa-clipboard" style="font-size:40px; color: #326799;"></i><br />
                    <b class="fgray3 _12">Reminders to assist you through your healthcare journey</b>
                </div>
            </div>
        </div>
        <div class="col-sm-10 col-sm-offset-1 top-20">
            @If Request.IsAuthenticated Then
                @Using Html.BeginForm("Name", "User", FormMethod.Post, New With {.id = "profileForm"})
                    @Html.AntiForgeryToken
                    @<div id="errorDiv"></div>
                    @<div class="form-group">
                        <input type="text" class="form-control text-center" placeholder="Your name" name="name" value="@ViewData("Name")" >
                    </div>
                    @<a href="javascript:document.getElementById('profileForm').submit()" class="btn btn-primary btn-block top-10 bold">Continue</a>

                End Using
            End If
            @*<form method="post" action="">
                <div id="errorDiv"></div>
                <div class="form-group">
                    <input type="text" class="form-control text-center" placeholder="Your name" name="name" >
                </div>
                <button class="btn btn-primary btn-block top-10 bold">Continue</button>&nbsp;&nbsp;&nbsp;
                @Html.ActionLink("Submit", "Name", "User")
            </form>*@
            <div class="col-xs-12 text-center no-padd">
                <b><a href="/passwordrecovery">@Html.ActionLink("Skip", "Gender", "User")</a></b><br /><br />
            </div>
        </div>
    </div>
</div>
