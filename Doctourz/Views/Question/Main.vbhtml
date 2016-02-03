@Code
    ViewData("Title") = "Main"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code


<div class="col-sm-6 col-sm-offset-3">
    <div class="col-xs-12 bgwhite padd-10 top-10" >
        @Html.ActionLink("Traits", "ViewTraits", "Question")
    </div>
    <div class="col-xs-12 bgwhite padd-10 top-10">
        @Html.ActionLink("Questions", "ViewQuestions", "Question")
    </div>
</div>