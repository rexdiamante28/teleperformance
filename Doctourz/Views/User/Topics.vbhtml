@Code
    Layout = "~/Views/Shared/_UserLayoutBlank.vbhtml"
End Code


<div class="login bgwhite top-100">
    <div class="col-xs-12 padd-30 bgwhite no-padd text-center top-10">
        <h4 class="bold fgray2">Hi there!</h4>
        <div class="progress">
            <div class="progress-bar progress-bar-primary" role="progressbar" aria-valuenow="30"
                 aria-valuemin="0" aria-valuemax="100" style="width:30%;">
                30%
            </div>
        </div>
        <div class="alert alert-info">
            <h4 class="fblue3">For a more personalized experience</h4>
            <b class="normal fgray2 _12">Please add three or more topics</b>
        </div>
        <div class="col-sm-12 top-20 no-padd">
            <form>
                <div id="errorDiv"></div>
                <div class="forn-group text-center" style="position: relative;">
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td class="text-left _17">{{title}}</td>
                                <td><input type="checkbox" class="pretty-radio point" name="topics" value={{_id}}></td>
                            </tr>
                        </tbody>
                    </table>

                </div>
                <button class="btn btn-primary btn-block top-10 bold bottom-10">Continue</button>
                <div class="col-xs-12 text-center no-padd">
                    <b><a href="/passwordrecovery">@Html.ActionLink("Skip", "TakeSurvey", "Question")</a></b><br /><br />
                </div>
            </form>
        </div>
    </div>
</div>