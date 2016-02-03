@Code
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code

<div class="col-sm-6 col-sm-offset-3 no-padd">
    <div class="col-sm-12 bgwhite">
        {{#each questions}}
        <button>#</button>
        {{/each}}
        <div id="myTabContent" class="tab-content">
            {{#each questions}}
            <div class="col-xs-12">
                <h4>{{question}}<label class="pull-right"></label></h4>
                <hr />
                {{#if equals negative true}}
                <div class="form-group">
                    <label><input id=1llllllllll{{_id}}llllllllll{{traits_id}} type="radio" name={{_id}} value="1"> Strongly Agree</label><br />
                    <label><input id=2llllllllll{{_id}}llllllllll{{traits_id}} type="radio" name={{_id}} value="2"> Agree</label><br />
                    <label><input id=3llllllllll{{_id}}llllllllll{{traits_id}} type="radio" name={{_id}} value="3"> Neither Agree nor Disagree</label><br />
                    <label><input id=4llllllllll{{_id}}llllllllll{{traits_id}} type="radio" name={{_id}} value="4"> Disagree</label><br />
                    <label><input id=5llllllllll{{_id}}llllllllll{{traits_id}} type="radio" name={{_id}} value="5"> Strongly Disagree</label><br />
                </div>
                {{else}}
                <div class="form-group">
                    <label><input id=5llllllllll{{_id}}llllllllll{{traits_id}} type="radio" name={{_id}} value="5"> Strongly Agree</label><br />
                    <label><input id=4llllllllll{{_id}}llllllllll{{traits_id}} type="radio" name={{_id}} value="4"> Agree</label><br />
                    <label><input id=3llllllllll{{_id}}llllllllll{{traits_id}} type="radio" name={{_id}} value="3"> Neither Agree nor Disagree</label><br />
                    <label><input id=2llllllllll{{_id}}llllllllll{{traits_id}} type="radio" name={{_id}} value="2"> Disagree</label><br />
                    <label><input id=1llllllllll{{_id}}llllllllll{{traits_id}} type="radio" name={{_id}} value="1"> Strongly Disagree</label><br />
                </div>
                {{/if}}
            </div>
            {{/each}}
        </div>
        <div class="col-xs-12 bottom-20">
            <button type="submit" class="btn btn-primary pull-right" id="saveSurvey">Save</button>
        </div>
    </div>
</div>
