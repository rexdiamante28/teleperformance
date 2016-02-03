@ModelType IEnumerable(Of Doctourz.Questions)
@Code
    ViewData("Title") = "ViewQuestions"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
    
    Dim db As New ApplicationDbContext
    Dim trait = db.Traits
End Code


<div class="col-sm-6 col-sm-offset-3">
    <div class="col-xs-12 padd-10 bgwhite">
        <text class="bold _19">Questions</text>
        <a href="/Question/AddQuestions" class="btn btn-info btn-sm pull-right"> <i class="fa fa-plus"></i> Add new</a>
    </div>
    <div class="col-xs-12 bgwhite padd-10 top-10 table-responsive">
        <table class="table table-striped table-bordered">
            <tr>
                <th>
                    Question
                </th>
                <th>
                    Negative
                </th>
                <th>
                    Trait
                </th>
                <th>
                    Actions
                </th>
            </tr>

            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.question)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.isNegative)
                    </td>
                    <td>
                        @For Each x In trait
                                If item.traitId = x.traitId Then
                            @Html.DisplayFor(Function(modelItem) x.trait)
                        End If
                    Next
                    </td>
                    <td>
                        @Html.ActionLink("Edit", "EditQuestions", New With {.id = item.questionId}) | 
                        <a href="#" id="@item.questionId" class="deleteQuestionBtn">Delete</a>
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
