@Imports Microsoft.AspNet.Identity
@Code
    Layout = "../Shared/_UserLayout.vbhtml"

    Dim db = New ApplicationDbContext
    Dim appUser As String = User.Identity.GetUserName
    Dim name = db.AppUsers.Where(Function(model) model.userName = appUser).First()

    ViewData("Name") = name
End Code

<div class="col-sm-6 col-sm-offset-3">
    <div class="col-xs-12 bgwhite padd-10 top-10">
        <legend>
            Employee Profile
        </legend>
        <div class="col-xs-12">
            <form>
                <div class="col-sm-6">
                    <div class="form-group">
                        <label class="text-muted normal">First Name</label>
                        <input type="text" class="form-control" name="firstName" value="@ViewBag.Name.firstName" />
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="form-group">
                        <label class="text-muted normal">First Name</label>
                        <input type="text" class="form-control" name="lastName" value="@ViewBag.Name.lastName" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>