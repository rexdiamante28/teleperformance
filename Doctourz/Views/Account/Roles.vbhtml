﻿@Code
    ViewBag.Title = "Create"
End Code

<h2>Create Role</h2>

<hr/>
@Using Html.BeginForm()

    @Html.AntiForgeryToken()
    @Html.ValidationSummary(true)

    @<div>
        Role name
    </div>
    @<p>
        @Html.TextBox("RoleName")
    </p>
    @<input type="submit" value="Save" />
End Using 