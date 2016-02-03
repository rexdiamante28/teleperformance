@Code
    Layout = "~/Views/Shared/_UserLayoutBlank.vbhtml"
End Code

<div class="login bgwhite top-100">
    <div class="col-xs-12 padd-30 bgwhite no-padd text-center top-10">
        <h4 class="bold fgray2">Hi there!</h4>
        <div class="progress">
            <div class="progress-bar progress-bar-primary" role="progressbar" aria-valuenow="30"
                 aria-valuemin="0" aria-valuemax="100" style="width:30%;">
                30%
            </div>
        </div>
        <div class="alert alert-info">
            <h4 class="fblue3">Three quick things</h4>
            <b class="normal fgray2 _12">Tell doctors a little more so they can personalize their answers</b>
        </div>
        <div class="col-sm-10 col-sm-offset-1 top-20">
            @If Request.IsAuthenticated Then
                @Using Html.BeginForm("Birthdate", "User", FormMethod.Post, New With {.id = "profileForm"})
                    @Html.AntiForgeryToken
                    @<div id="errorDiv"></div>
                    @<div class="forn-group text-center">
                        <label>Date of Birth</label><br />
                        <i class="fa fa-calendar fblue5 bottom-10" style="font-size:60px;"></i><br />
                         <input type="date" class="form-control" id="birthdate" name="birthdate">
                    </div>
                    @<a href="javascript:document.getElementById('profileForm').submit()" class="btn btn-primary btn-block top-10 bold bottom-10">Continue</a>
                End Using
            End If
            <div class="col-xs-12 text-center no-padd">
                <b><a href="/passwordrecovery">@Html.ActionLink("Skip", "Location", "User")</a></b><br /><br />
            </div>
        </div>
    </div>
</div>