@Imports Microsoft.AspNet.Identity
@Code
    Dim db = New ApplicationDbContext
    Dim userTraits = db.Traits
End Code

<div class="row">
    <a href="~/Question/TakeSurvey" class="btn btn-primary btn-lg btn-block">Guide Me</a>
    <hr />
</div>
<div class="col-xs-12 no-padd">
    @For Each trait In userTraits
    @<div class="col-xs-12 col-sm-6 no-padd">
        <label class="fblue10">@trait.trait</label>
    </div>
    @<div class="col-xs-12 col-sm-6 no-padd">
        <div class="progress">
            @Code
            Try
            Dim loopDbContext = New ApplicationDbContext
            Dim userId = User.Identity.GetUserId
            Dim progress = loopDbContext.Ratings.Where(Function(x) x.traitId = trait.traitId).Where(Function(x) x.userId = userId).First().score.ToString
            progress += "%"
           
            @<div style="width:@progress; background-color:#2FA4E7" class="progress-bar progress-bar-info">@progress</div>
            Catch
            End Try
            End Code
        </div>
    </div>
    Next
</div>