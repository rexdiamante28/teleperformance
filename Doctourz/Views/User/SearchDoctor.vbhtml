@ModelType List(Of DoctorList)

@Code
    'Layout = "~/Views/Shared/_UserLayout.vbhtml"
    @Styles.Render("~/Content/user")
End Code

        <ul class="list-group point" id="patient-initial-info">
            @For Each doc In ViewBag.Doctors

                @<li class="list-group-item">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="col-xs-2 no-padd">
                                @If doc.docAvatar = "" Then
                                    @<img src="~/Content/Images/Website/dummy.jpg" class="col-xs-12 img-circle no-padd" />
                                Else
                                    @<img src="~/Images/@doc.docAvatar" class="col-xs-12 img-circle no-padd" />
                                End If
                            </div>
                            <div class="col-xs-10">
                                <text class="bold custom-fblue">@doc.docName</text><br />
                                <text class="fgray4">@doc.docSpecialization</text><br />
                                <text class="fgray4">Star ratings</text><br />
                                <text class="fgray4">@doc.docLocation</text><br />
                            </div>
                        </div>
                    </div>
                </li>
            Next
        </ul>

@Scripts.Render("~/bundles/jquery")
@Scripts.Render("~/bundles/user")
