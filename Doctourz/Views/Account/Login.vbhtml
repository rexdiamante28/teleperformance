@ModelType LoginViewModel
@Code
    ViewBag.Title = "Log in"
    Layout = "../Shared/_BlankLayout.vbhtml"
End Code

<div class="login">
    <div class="col-xs-12 padd-30 no-padd text-center top-10">
        <div class="row  bgwhite padd-10">
            <div class="col-xs-12   no-padd bgwhite">
                <a class="point">@Html.ActionLink(" ", "Index", "Home")<img src="~/Content/Images/Website/logo_blue.png" style="width:250px;" /></a>
            </div>
        </div>
        <div class="row bgwhite padd-20 top-10">
            <h4 class="bold custom-fblue">Log in to your account</h4>
            <div class="col-xs-12 no-padd ">
                <div class="col-sm-10 col-sm-offset-1 top-20">
                    @Using Html.BeginForm("Login", "Account", FormMethod.Post)
                        @Html.AntiForgeryToken()
                        @Html.ValidationSummary("", New With {.class = "text-danger"})
                        @<div class="form-group">
                            @Html.TextBoxFor(Function(model) model.Username, New With{.class="form-control", .placeholder="Username"})
                        </div>
                        @<div class="form-group">
                             @Html.PasswordFor(Function(model) model.Password, New With {.class = "form-control", .placeholder = "Password"})
                        </div>
                        @<div class="form-group text-left">
                            <label><input type="checkbox" value="Remember me">&nbsp; Remember me</label>
                        </div>
                        @<button type="submit" class="btn btn-block top-10 bold btn-primary">LOG IN</button>@:&nbsp;&nbsp;&nbsp;
                    End Using
                    <div class="col-xs-12 text-center no-padd">
                        <b><a href="">Forgot your password?</a></b><br /><br />

                        <b>Don't have an account? <a>@Html.ActionLink("Sign up!", "Register", "Account")</a></b><br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
