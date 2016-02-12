@Code
    Layout = "../Shared/_BlankLayout.vbhtml"
End Code

<div class="login">
    <div class="col-xs-12 padd-30 no-padd text-center top-10">
        <div class="row  bgwhite padd-10">
            <div class="col-xs-12   no-padd bgwhite">
                <a class="point">@Html.ActionLink(" ", "Index", "Home")<img src="~/Content/Images/Website/tplogo.jpg" style="width:250px;" /></a>
            </div>
        </div>
        <div class="row bgwhite padd-20 top-10">
            <h4 class="bold custom-fblue">Log in to your account</h4>
            <div class="col-xs-12 no-padd ">
                <div class="col-sm-10 col-sm-offset-1 top-20">
                    <form>
                        <div id="errorDiv"></div>
                        <div class="form-group">
                            <input type="text" class="form-control " placeholder="Username" id="username">
                        </div>
                        <div class="form-group">
                            <input type="password" class="form-control " placeholder="Password" id="password">
                        </div>
                        <div class="form-group text-left">
                            <label><input type="checkbox" value="Remember me">&nbsp; Remember me</label>
                        </div>
                        <button class="btn btn-block top-10 bold btn-primary">LOG IN</button>&nbsp;&nbsp;&nbsp;
                    </form>
                    <div class="col-xs-12 text-center no-padd">
                        <b><a href="">Forgot your password?</a></b><br/><br/>

                        <b>Don't have an account? <a>@Html.ActionLink("Sign up!", "SignUp", "Home")</a></b><br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>