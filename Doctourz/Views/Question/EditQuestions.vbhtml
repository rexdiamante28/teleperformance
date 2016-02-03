@ModelType Doctourz.Questions
@Code
    ViewData("Title") = "EditQuestions"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
    
    Dim db As New ApplicationDbContext
    Dim traits = db.Traits
End Code


<div class="col-sm-6 col-sm-offset-3">
    <div class="col-xs-12 bgwhite" padd-10>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()

            @<div class="form-horizontal">
                <h4>Edit Question</h4>
                <hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                @Html.HiddenFor(Function(model) model.questionId)

                <div class="form-group">
                    <label class="col-md-2 control-label">Question</label>
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.question, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.question, "", New With {.class = "text-danger"})
                    </div>
                </div>

                @*<div class="form-group">
                    @Html.LabelFor(Function(model) model.traitId, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.traitId, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.traitId, "", New With {.class = "text-danger"})
                    </div>
                </div>*@

                <div class="form-group">
                    <label class="col-md-2 control-label">Trait</label>
                    <div class="col-md-10">
                        <select name="traitsList" class="form-control">
                            @For Each item In traits
                            If Model.traitId = item.traitId Then
                                @<option selected="selected" value="@item.traitId">@item.trait</option>
                            Else
                                @<option value="@item.traitId">@item.trait</option>
                            End If
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
                        <input type="submit" value="Save" class="btn btn-default" />
                        @Html.ActionLink("Back to List", "ViewQuestions", "Questions", New With {.class = "btn btn-info btn-sm no-radius"})
                    </div>
                </div>
            </div>
        End Using
    </div>
</div>
