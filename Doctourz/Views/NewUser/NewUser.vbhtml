@Modeltype RegisterViewModel
@Code
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code


<div class="col-sm-6 col-sm-offset-3">
    <div class="col-xs-12 padd-10 bgwhite">
        <text class="bold _19">Add New Doctor</text>
    </div>

    <div class="col-xs-12 padd-10 bgwhite top-10">
           <div class="col-sm-8 col-sm-offset-2">
               @Using Html.BeginForm("NewUser", "NewUser", FormMethod.Post)
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
                       <button type="submit" class="btn btn-primary">Save</button>
                   </div>
               End Using
           </div>
    </div>
</div>


@Section scripts
<script>
    $(".deleteQuestionBtn").click(function (event) {
        var traitId = $(event.currentTarget).context.id;
        $.ajax({
            url: '/Question/DeleteQuestion/' + traitId,
            data: { id: traitId },
            type: 'POST',
            dataType: 'html',
            success: function () {
                alert("Successfully Deleted");
                window.location ="/Question/ViewQuestions";
            }
        })
    })
</script>
End Section
