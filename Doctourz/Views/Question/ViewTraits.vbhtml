@ModelType IEnumerable(Of Doctourz.Traits)
@Code
    ViewData("Title") = "ViewTraits"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code

<div class="col-sm-6 col-sm-offset-3">
    <div class="col-xs-12 padd-10 bgwhite">
        <text class="bold _19">Traits</text>
        <a href="/Question/Addtraits" class="btn btn-info btn-sm pull-right"> <i class="fa fa-plus"></i> Add new</a>
    </div>
    <div class="col-xs-12 bgwhite padd-10 top-10 table-responsive">
        <table class="table table-striped table-bordered">
            <tr>
                <th>
                    Trait
                </th>
                <th>
                    Description
                </th>
                <th>
                    Actions
                </th>
            </tr>

            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.trait)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.description)
                    </td>
                    <td>
                        @Html.ActionLink("Edit", "EditTraits", New With {.id = item.traitId}) |
                        <a href="#" id="@item.traitId" class="deleteTraitBtn">Delete</a>
                    </td>
                </tr>
            Next

        </table>
    </div>

    
</div>


@Section scripts
<script>
    $(".deleteTraitBtn").click(function (event) {
        var conf = confirm("Deleting a trait will delete questions according to it. Are you sure you want to delete trait?");
        if (conf) {
            var traitId = $(event.currentTarget).context.id;
            $.ajax({
                url: '/Question/DeleteTrait/' + traitId,
                data: { id: traitId },
                type: 'POST',
                dataType: 'html',
                success: function () {
                    alert("Successfully Deleted");
                    window.location = "/Question/ViewTraits";
                }
            })
        }

    })
</script>
End Section
