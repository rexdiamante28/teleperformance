@ModelType Doctourz.Questions
@Code
    ViewData("Title") = "AddQuestions"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
    
    Dim db As New ApplicationDbContext
    Dim traits = db.Traits
End Code
<div class="col-sm-6 col-sm-offset-3">
    <div class="col-xs-12 bgwhite padd-10">
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()

            @<div class="form-horizontal">
                <h4>Questions</h4>
                <hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

                <div class="form-group">
                    <label class="col-md-2 control-label">Question</label>
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.question, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.question, "", New With {.class = "text-danger"})
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-md-2 control-label">Trait</label>
                    <div class="col-md-10">
                        <select name="traitsList" class="form-control">
                            @For Each item In traits
                                @<option value="@item.traitId">@item.trait</option>
                            Next
                        </select>

                    </div>
                </div>
                 <div class="form-group">
                     <label class="col-md-2 control-label">Negative</label>
                     <div class="col-md-10">
                         @Html.EditorFor(Function(model) model.isNegative, New With {.htmlAttributes = New With {.class = ""}})
                         @Html.ValidationMessageFor(Function(model) model.isNegative, "", New With {.class = "text-danger"})
                     </div>
                 </div>

                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <input type="submit" value="Create" class="btn btn-default" />
                        @Html.ActionLink("Back to List", "ViewQuestions", "Questions", New With {.class = "btn btn-sm btn-info"})
                    </div>
                </div>
            </div>
        End Using
    </div>
</div>