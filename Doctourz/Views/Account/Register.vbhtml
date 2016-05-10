@Modeltype RegisterViewModel
@Code
    Layout = "../Shared/_BlankLayout.vbhtml"
End Code

<div class="col-xs-12  bggray5 full-height">
    <div class="col-sm-8 col-sm-offset-2">
        <div class="row padd-20 bgwhite">
            <img src="~/Content/Images/Website/tplogo.jpg" style="width:250px;" />
            <div class="pull-right text-center top-20">
                <a class="right-10">@Html.ActionLink("Signup", "Register", "Account")</a>
                <a class="right-10">@Html.ActionLink("Login", "Login", "Account")</a>
            </div>
        </div>
    </div>
    <div class="col-xs-12 col-sm-8 col-sm-offset-2 top-10 ">
        <div class="row padd-20 bgwhite">
            <div class="col-sm-6 col-sm-offset-3">
                <div class="col-sm-10 col-sm-offset-1 top-20">
                    @Using Html.BeginForm("Register", "Account", FormMethod.Post)
                        @Html.AntiForgeryToken()
                        @Html.ValidationSummary("", New With {.class = "text-danger"})
                        @<div id="errorDiv">
                        </div>
                        @<b class="pull-right fgray3 normal">* All fields required</b>
                        @<div class="form-group">
                            @Html.TextBoxFor(Function(model) model.firstName, New With {.class = "form-control", .placeholder = "First Name"})
                        </div>
                        @<div class="form-group">
                            @Html.TextBoxFor(Function(model) model.lastName, New With {.class = "form-control", .placeholder = "Last Name"})
                        </div>
                        @<div class="form-group">
                            @Html.TextBoxFor(Function(model) model.Email, New With {.class = "form-control", .placeholder = "Email"})
                        </div>
                        @<div class="form-group">
                            @Html.TextBoxFor(Function(model) model.userName, New With {.class = "form-control", .placeholder = "Username"})
                        </div>
                        @<b class="pull-right fgray3 normal">(minimum of 8 characters)</b>
                        @<div class="form-group">
                            @Html.PasswordFor(Function(model) model.Password, New With {.class = "form-control", .placeholder = "Password"})
                        </div>
                        @<div class="form-group">
                            @Html.PasswordFor(Function(model) model.ConfirmPassword, New With {.class = "form-control", .placeholder = "Confirm Password"})
                        </div>
                        @<div class="form-group">
                            <label class="point"><input type="checkbox" id="agree" name="terms" value="1"> I agree to <a>Terms and Conditions</a></label>
                        </div>
                        @<div class="form-group">
                            <button type="submit" class="btn btn-primary btn-block">Register</button>
                        </div>
                        
                    End Using
                </div>
            </div>
        </div>
    </div>
</div>


@section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
