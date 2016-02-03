@ModelType Doctourz.Traits
@Code
    ViewData("Title") = "EditTraits"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code


<div class="col-sm-6 col-sm-offset-3 top-20">
    <div class="col-xs-12 bgwhite padd-10">
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()

            @<div class="form-horizontal">
                <h4>Edit Trait</h4>
                
                <hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                @Html.HiddenFor(Function(model) model.traitId)

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.trait, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.trait, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.trait, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.description, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.description, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.description, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <input type="submit" value="Save" class="btn btn-default" />
                        @Html.ActionLink("Back to List", "ViewTraits","Questions", New With {.class="btn btn-info"})
                    </div>
                </div>
            </div>
        End Using
    </div>
</div>