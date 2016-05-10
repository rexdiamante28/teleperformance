@ModelType IEnumerable(Of Doctourz.AppUsers)
@Code
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code


<div class="col-sm-6 col-sm-offset-3">
    <div class="col-xs-12 padd-10 bgwhite">
        <text class="bold _19">Users List</text>
        <a href="/NewUser/NewUser" class="btn btn-info btn-sm pull-right"> <i class="fa fa-plus"></i> Add new</a>
    </div>
    <div class="col-xs-12 bgwhite padd-10 top-10 table-responsive">
        <table class="table table-striped table-bordered">
            <tr>
                <th>
                    Username
                </th>
                <th>
                    Name
                </th>
                <th>
                    Email
                </th>
                <th>
                    level
                </th>
                <th>
                    Actions
                </th>
            </tr>

            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.userName)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.name)
                    </td>
                     <td>
                         @Html.DisplayFor(Function(modelItem) item.email)
                     </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.level)
                    </td>
                    <td>
                        @Html.ActionLink("Edit", "EditQuestions", New With {.id = item.userId}) | 
                        <a href="#" id="@item.userId" class="deleteQuestionBtn">Delete</a>
                    </td>
                </tr>
            Next
        </table>
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
