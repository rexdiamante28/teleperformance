@ModelType AppUsers
@Imports Microsoft.AspNet.Identity
<script>
    $(document).ready(function () {
        loadHealthProfile();
    })
</script>

<ul class="nav nav-pills">
    <li class="dropdown pull-right">
        <a class="dropdown-toggle bggray5 pull-right" data-toggle="dropdown" href="#">
            <span class="caret"></span>
        </a>
        <ul class="dropdown-menu">
            <li><a href="#basicinfomation" data-toggle="tab">Basic Information</a></li>
            <li class="divider"></li>
            <li><a href="#conditions" data-toggle="tab">Conditions and Symptoms</a></li>
            <li class="divider"></li>
            <li><a href="#allergies" data-toggle="tab">Allergies</a></li>
            <li class="divider"></li>
            <li><a href="#medicalrecords" data-toggle="tab">Treatments</a></li>
        </ul>
    </li>
</ul>
<div id="myTabContent" class="tab-content">
    <div class="tab-pane fade active in" id="basicinfomation">
        <ul class="list-group top-20">
            <li class="list-group-item">
                <b class="_17 normal">About</b>
            </li>
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Name</b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('name_edit')"></i>
                        <b class="pull-right normal bluefont"><span id="UsrName"></span></b>
                    </div>
                </div>

            </li>
            <li class="list-group-item bggray5 no-display" id="name_edit">
                What is your name?
                @Using Html.BeginForm("UpdateName", "User", FormMethod.Post, New With {.role = "form", .id = "UpdateNameForm"})
                    @Html.AntiForgeryToken()
                    @Html.ValidationSummary("", New With {.class = "text-danger"})

                    @Html.TextBoxFor(Function(model) model.firstName, New With {.class = "form-control bottom-10", .id = "fName"})
                    @Html.TextBoxFor(Function(model) model.lastName, New With {.class = "form-control bottom-10", .id = "lName"})
                    @<button class="btn" type="button" onclick="toggleElement('name_edit')">Cancel</button>
                    @<button class="btn btn-primary savename" type="submit">Save</button>
                End Using

            </li>


            <li class="list-group-item">
                <b class="normal">Gender</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('gender_edit')"></i>
                <b class="pull-right normal bluefont"><span id="UsrGender"></span></b>
            </li>
            <li class="list-group-item no-display bggray5" id="gender_edit">
                What gender are you?<br /><br />
                @Using Html.BeginForm("UpdateGender", "User", FormMethod.Post, New With {.role = "form", .id = "UpdateGenderForm"})
                    @Html.AntiForgeryToken()
                    @Html.ValidationSummary("", New With {.class = "text-danger"})
                    @Html.HiddenFor(Function(model) model.gender, New With {.id = "genderType"})

                    @<label class="normal point"><input type="radio" name="gender" id="male" onclick="$('#genderType').val('Male')" /> Male</label>@<br />
                    @<label class="normal point"><input type="radio" name="gender" id="female" onclick="$('#genderType').val('Female')" /> Female</label>@<br />

                    @<button class="btn" type="button" onclick="toggleElement('gender_edit')">Cancel</button>
                    @<button class="btn btn-primary savegender" type="submit">Save</button>
                End Using
            </li>


            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Location</b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('location_edit')"></i>
                        <b class="pull-right normal bluefont"><span id="UsrLocation"></span></b>
                    </div>
                </div>
            </li>
            <li class="list-group-item bggray5 no-display" id="location_edit">
                Where are you located?
                @Using Html.BeginForm("UpdateLocation", "User", FormMethod.Post, New With {.role = "form", .id = "UpdateLocationForm"})
                    @Html.AntiForgeryToken()
                    @Html.ValidationSummary("", New With {.class = "text-danger"})

                    @Html.TextBoxFor(Function(model) model.location, New With {.class = "form-control bottom-10", .id = "location"})

                    @<button class="btn" type="button" onclick="toggleElement('location_edit')">Cancel</button>
                    @<button class="btn btn-primary savelocation" type="submit">Save</button>
                End Using
            </li>


            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Date of Birth</b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('birthdate_edit')"></i>
                        <b class="pull-right normal bluefont"><span id="UsrBirthDate"></span></b>
                    </div>
                </div>
            </li>
            <li class="list-group-item bggray5 no-display" id="birthdate_edit">
                What is your birth date?
                @Using Html.BeginForm("UpdateBirthDate", "User", FormMethod.Post, New With {.role = "form", .id = "UpdateBirthForm"})
                    @Html.AntiForgeryToken()
                    @Html.ValidationSummary("", New With {.class = "text-danger"})

                    @Html.TextBoxFor(Function(model) model.birthDate, New With {.class = "form-control bottom-10", .id = "birthDate", .type = "Date"})

                    @<button class="btn" type="button" onclick="toggleElement('birthdate_edit')">Cancel</button>
                    @<button class="btn btn-primary savebirthdate" type="submit">Save</button>
                End Using
            </li>


            <li class="list-group-item">
                <b class="normal">Ethnicity</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('ethnicity_edit')"></i>
                <b class="pull-right normal bluefont"><span id="UsrEthnicity"></span></b>
            </li>
            <li class="list-group-item no-display bggray5" id="ethnicity_edit">
                What is your ethnicity?<br /><br />

                @Code
                    @Using Html.BeginForm("UpdateEthnicity", "User", Nothing, FormMethod.Post, New With {.id = "UpdateEthForm", .role = "form"})
                        @Html.AntiForgeryToken()

                        @Html.HiddenFor(Function(model) model.ethnicityId, New With {.id = "ethType"})

                        Dim db = New ApplicationDbContext

                        Dim ethnicities = db.Ethnicities

                        For Each i In ethnicities
                        @<label class="normal point"><input type="radio" name="ethnicity" onclick="$('#ethType').val(this.id)" id="@i.ethnicityId" value="@i.name" class="pretty-radio"> @i.name</label>@<br />
                        Next

                        @<button class="btn" type="button" onclick="toggleElement('ethnicity_edit')">Cancel</button>
                        @<button class="btn btn-primary saveethnicity" type="submit">Save</button>

                    End Using

                End Code

            </li>

            <li class="list-group-item">
                <b class="normal">Height</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('height_edit')"></i>
                <b class="pull-right normal bluefont"><span id="UsrHeight"></span></b>
            </li>
            <li class="list-group-item bggray5 no-display" id="height_edit">
                <div class="row">
                    <div class="col-xs-12">
                        What is your height?

                        @Using Html.BeginForm("UpdateHeight", "User", Nothing, FormMethod.Post, New With {.id = "UpdateHeightForm", .role = "form"})
                            @Html.AntiForgeryToken()

                            @Html.HiddenFor(Function(model) model.height, New With {.id = "heightVal"})
                            @<div class="row">
                                <div class="col-xs-6">
                                    <input type="number" id="height1" placeholder="feet" class="form-control bottom-10" min="1" max="8">
                                </div>
                                <div class="col-xs-6">
                                    <input type="number" id="height2" placeholder="inches" class="form-control bottom-10" min="0" max="11">
                                </div>
                            </div>
                            @<button class="btn" type="button" onclick="toggleElement('height_edit')">Cancel</button>
                            @<button class="btn btn-primary saveheight" type="submit">Save</button>
                        End Using

                    </div>
                </div>

            </li>

            <li class="list-group-item">
                <b class="normal">Weight</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('weight_edit')"></i>
                <b class="pull-right normal bluefont"><span id="UsrWeight"></span></b>
            </li>
            <li class="list-group-item bggray5 no-display" id="weight_edit">
                <div class="row">
                    <div class="col-xs-12">
                        What is your weight (Kilogram)?
                        @Using Html.BeginForm("UpdateWeight", "User", Nothing, FormMethod.Post, New With {.id = "UpdateWeightForm", .role = "form"})
                            @Html.AntiForgeryToken()

                            @Html.HiddenFor(Function(model) model.weight, New With {.id = "weightVal"})
                            @<div class="row">
                                <div class="col-xs-12">
                                    <input type="number" id="weight" placeholder="Kilogram" class="form-control bottom-10" min="1" max="200">
                                </div>
                            </div>
                            @<button class="btn" type="button" onclick="toggleElement('weight_edit')">Cancel</button>
                            @<button class="btn btn-primary saveweight" type="submit">Save</button>
                        End Using

                    </div>
                </div>
            </li>


            <li class="list-group-item">
                <b class="normal">BMI</b>
                <i class="fa fa-pencil-square-o pull-right"></i>
                <b class="pull-right normal bluefont"><span id="UsrBmi"></span></b>
            </li>
        </ul>


        <ul class="list-group">
            <li class="list-group-item">
                <b class="_17 normal">Family History</b>
            </li>
            <li class="list-group-item">
                <small>
                    Conditions that caused a close relative to pass away before the age of 60:
                    <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_history1')"></i>
                </small>
            </li>
            <li>
                <ul class="appendnewhistory list-group-item">
                    @For Each x In ViewBag.history1
                        @<li class="list-group-item">
                            @x.symptom<label class="normal fgray4">(@x.whoHadIt)</label>
                            <i class="fa fa-remove pull-right removeHs" id="@x.historyId"></i>
                        </li>
                    Next
                </ul>
            </li>

            <li class="list-group-item bggray5 no-display" id="edit_history1">
                <div class="row">
                    <div class="col-xs-12">
                        @Using Html.BeginForm("AddHistory1", "User", FormMethod.Post, New With {.role = "form", .id = "AddHistory1"})
                            @Html.AntiForgeryToken()

                            @<div class="form-group">
                                <label class="normal">Condition or Symptom</label>
                                <input type="text" id="condition1" class="form-control">
                            </div>
                            @<div class="form-group">
                                <label class="normal">Who had it?</label>
                                <select class="form-control" id="relative1">
                                    <option>Mother</option>
                                    <option>Father</option>
                                    <option>Sister</option>
                                    <option>Brother</option>
                                    <option>Grandmother</option>
                                    <option>Grandfather</option>
                                </select>
                            </div>
                            @<div class="form-group">
                                <label class="normal">How old is he/she?</label>
                                <input type="number" id="age1" min="1" max="200" class="form-control">
                            </div>
                            @<div class="form-group">
                                <button class="btn btn-primary savehistory1 pull-right" type="submit">Save</button>
                            </div>
                        End Using

                    </div>
                </div>
            </li>

            <li class="list-group-item">
                <small>
                    Do your grandparents, parents or siblings have any major medical conditions (life-threatening or otherwise?)
                    <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_history2')"></i>
                </small>
            </li>
            <li>
                <ul class="appendnewhistory2 list-group-item">
                    @For Each x In ViewBag.history2
                        @<li class="list-group-item">
                            @x.symptom<label class="normal fgray4">(@x.whoHadIt)</label>
                            <i class="fa fa-remove pull-right removeHs" id="@x.historyId"></i>
                        </li>
                    Next
                </ul>
            </li>
            <li class="list-group-item bggray5 no-display" id="edit_history2">
                <div class="row">
                    <div class="col-xs-12">
                        @Using Html.BeginForm("AddHistory2", "User", FormMethod.Post, New With {.role = "form", .id = "AddHistory2"})
                            @Html.AntiForgeryToken()

                            @<div class="form-group">
                                <label class="normal">Condition or Symptom</label>
                                <input type="text" id="condition2" class="form-control">
                            </div>
                            @<div class="form-group">
                                <label class="normal">Who had it?</label>
                                <select class="form-control" id="relative2">
                                    <option>Mother</option>
                                    <option>Father</option>
                                    <option>Sister</option>
                                    <option>Brother</option>
                                    <option>Grandmother</option>
                                    <option>Grandfather</option>
                                </select>
                            </div>
                            @<div class="form-group">
                                <label class="normal">How old is he/she?</label>
                                <input type="number" id="age2" min="1" max="200" class="form-control">
                            </div>
                            @<div class="form-group">
                                <button class="btn btn-primary savehistory1 pull-right" type="submit">Save</button>
                            </div>
                        End Using
                    </div>
                </div>
            </li>
        </ul>


        <ul class="list-group">
            <li class="list-group-item">
                <b class="_17 normal">Lifestyle</b>
            </li>
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Dietary Restrictions</b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_diet')"></i>
                        <b class="pull-right normal bluefont">{{data.diet}}</b>
                    </div>
                </div>
            </li>
            <li class="list-group-item no-display" id="edit_diet">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Do you have any dietary restrictions? (Choose all that apply)</b><br />
                        <div class="form-group">
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Ovo-Vegetarian">
                                Ovo-Vegetarian<br />
                                <small>eat eggs, but not dairy</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Lacto-Vegetarian">
                                Lacto-Vegetarian<br />
                                <small>eat dairy, but not eggs</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Vegetarian">
                                Vegetarian<br />
                                <small>eat both dairy and eggs</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Vegan">
                                Vegan<br />
                                <small>No meat or animal products</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Pescatarian">
                                Pescatarian<br />
                                <small>No meat, except fish</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Gluten-free">
                                Gluten-free<br />
                                <small>No wheat,barley, or rye</small>
                            </label><br />
                            <label class="normal point">
                                <input type="checkbox" class="pretty-radio" name="diet" value="Lactose Intolerant">
                                Lactose Intolerant<br />
                                <small>Lactose-free dairy</small>
                            </label><br />
                        </div>
                        <div class="forn-group">
                            <button class="btn btn-primary savediet pull-right">Save</button>
                        </div>
                    </div>
                </div>
            </li>


            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">Alcohol</b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_alcohol')"></i>
                        <b class="pull-right normal bluefont">{{data.alcohol}}</b>
                    </div>
                </div>
            </li>
            <li class="list-group-item no-display bggray5" id="edit_alcohol">
                <div class="row">
                    <div class="col-xs-12">
                        How would you classify your consumption of alcohol?<br /><br />
                        <label class="normal point"><input type="radio" name="alcohol" value="Social Drinker" class="pretty-radio"> Social Drinker<br /> <small>(0-7 drinks/week)</small></label><br />
                        <label class="normal point"><input type="radio" name="alcohol" class="pretty-radio" value="Moderate Drinker"> Moderate Drinker<br /> <small>(8-14 drinks/week)</small></label><br />
                        <label class="normal point"><input type="radio" name="alcohol" class="pretty-radio" value="Heavy Drinker"> Heavy Drinker<br /> <small>(15+ drinks/week)</small></label><br />
                        <label class="normal point"><input type="radio" name="alcohol" class="pretty-radio" value="Not a Drinker"> Not a Drinker</label><br />

                        <button class="btn btn-primary savealcohol pull-right">Save</button>
                    </div>
                </div>
            </li>


            <li class="list-group-item">
                <b class="normal">Tobacco</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_tobacco')"></i>
                <b class="pull-right normal bluefont">{{data.tobacco}}</b>
            </li>
            <li class="list-group-item no-display bggray5" id="edit_tobacco">
                <div class="row">
                    <div class="col-xs-12">
                        Do you smoke or chew tobacco or recently quit?<br /><br />
                        <label class="normal point"><input type="radio" name="tobacco" value="Never smoke or chewed" class="pretty-radio"> Never smoke or chewed</label><br />
                        <label class="normal point"><input type="radio" name="tobacco" class="pretty-radio" value="Yes, 0-2 packs a month"> Yes, 0-2 packs a month</label><br />
                        <label class="normal point"><input type="radio" name="tobacco" class="pretty-radio" value="Yes, 0-2 packs a week"> Yes, 0-2 packs a week</label><br />
                        <label class="normal point"><input type="radio" name="tobacco" class="pretty-radio" value="Yes, 0-2 packs a day"> Yes, 0-2 packs a day</label><br />
                        <label class="normal point"><input type="radio" name="tobacco" class="pretty-radio" value="Yes, more than 2 packs a day"> Yes, more than 2 packs a day</label><br />
                        <label class="normal point"><input type="radio" name="tobacco" class="pretty-radio" value="Yes, chewing tobacco"> Yes, chewing tobacco</label><br />

                        <button class="btn btn-primary savetobacco pull-right">Save</button>
                    </div>
                </div>
            </li>


            <li class="list-group-item">
                <b class="normal">Sexually Active</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_sex')"></i>
                <b class="pull-right normal bluefont">{{data.sexual}}</b>
            </li>
            <li class="list-group-item no-display bggray5" id="edit_sex">
                <div class="row">
                    <div class="col-xs-12">
                        Have you ever had sexual intercourse with men, women, or both?<br /><br />
                        <label class="normal point"><input type="radio" name="sex" value="Not Sexually active" class="pretty-radio"> Not Sexually active</label><br />
                        <label class="normal point"><input type="radio" name="sex" class="pretty-radio" value="Men"> Men</label><br />
                        <label class="normal point"><input type="radio" name="sex" class="pretty-radio" value="Women"> Women</label><br />
                        <label class="normal point"><input type="radio" name="sex" class="pretty-radio" value="Both"> Both</label><br />

                        <button class="btn btn-primary savesex pull-right">Save</button>
                    </div>
                </div>
            </li>


            <li class="list-group-item">
                <b class="normal">Recreational Drugs</b>
                <i class="fa fa-pencil-square-o pull-right"></i>
                <b class="pull-right normal bluefont">--</b>
            </li>
        </ul>

        <ul class="list-group">
            <li class="list-group-item">
                <b class="_17 normal">Contact Information</b>
            </li>
            <li class="list-group-item">
                <b class="normal">Mobile Number</b>
                <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('edit_mobile')"></i>
                <b class="pull-right normal bluefont">{{data.mobile}}</b>
            </li>
            <li class="list-group-item no-display bggray5" id="edit_mobile">
                <div class="row">
                    <div class="col-xs-12">
                        What is your mobile number?<br /><br />
                        <input type="text" class="form-control" id="mobile" value={{data.mobile}}>
                        <button class="btn btn-primary pull-right top-20 savemobile">Save</button>
                    </div>
                </div>
            </li>

            <li class="list-group-item">
                <b class="normal">Mailing Address</b>
                <i class="fa fa-pencil-square-o pull-right"></i>
                <b class="pull-right normal bluefont">--</b>
            </li>
        </ul>

        <ul class="list-group">
            <li class="list-group-item">
                <b class="_17 normal">Insurance</b>
            </li>
            <li class="list-group-item">
                <b class="normal">How are you insured?</b>
                <i class="fa fa-pencil-square-o pull-right"></i>
                <b class="pull-right normal bluefont">--</b>
            </li>
        </ul>

    </div>
    <div class="tab-pane fade" id="conditions">
        <ul class="list-group top-20">
            <li class="list-group-item">
                <b class="_17 normal">Medical Conditions</b>
            </li>
            {{#each record}}
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal" title={{description}}>{{condition}}<br /><small>({{medications}})</small></b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('name_edit')"></i>
                        <i class="fa fa-remove pull-right delete" id={{_id}}></i>
                    </div>
                </div>
            </li>
            {{/each}}
        </ul>

        <div class="col-xs-12 no-padd">
            <div class="col-sm-12 no-padd">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        New Medical Condition
                        <i class="fa fa-plus pull-right" onclick="toggleElement('add_condition')"></i>
                    </div>
                    <div class="panel-body no-display" id="add_condition">
                        <form>
                            <div id="errorDiv"></div>
                            <input type="text" class="hidden" id="patientId" value={{sessionId}}>
                            <div class="form-group">
                                <label>Medical Condition</label>
                                <input type="text" class="form-control " id="condition">
                            </div>
                            <div class="form-group">
                                <label>Short Description</label>
                                <textarea class="form-control " id="description"></textarea>
                            </div>
                            <div class="form-group">
                                <label>Medications</label><small style="color:red;">list all medications for this condition sepatated by comma (,)</small>
                                <textarea class="form-control " id="medications"></textarea>
                            </div>
                            <a class="btn btn-default" href="edit">Back</a>
                            <button type="submit" class="btn btn-primary">Save</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="tab-pane fade" id="allergies">
        <ul class="list-group top-20">
            <li class="list-group-item">
                <b class="_17 normal">Medical Conditions</b>
            </li>
            {{#each record}}
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal">{{particular}}<br /><small>({{type}})</small></b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('name_edit')"></i>
                        <i class="fa fa-remove pull-right delete" id={{_id}}></i>
                    </div>
                </div>
            </li>
            {{/each}}
        </ul>

        <div class="col-xs-12 no-padd">
            <div class="col-sm-12 no-padd">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        New Allergy details
                        <i class="fa fa-plus pull-right" onclick="toggleElement('add_allergy')"></i>
                    </div>
                    <div class="panel-body no-display" id="add_allergy">
                        <form>
                            <div id="errorDiv"></div>
                            <input type="text" class="hidden" id="patientId" value={{sessionId}}>
                            <div class="form-group">
                                <label>Type</label>
                                <select type="text" class="form-control " id="type">
                                    <option value="food">Food</option>
                                    <option value="drugs">Drugs</option>
                                </select>
                            </div>
                            <div class="form-group">
                                <label>Particular</label>
                                <input class="form-control " id="particular" type="text">
                            </div>
                            <a class="btn btn-default" href="edit">Back</a>
                            <button type="submit" class="btn btn-primary">Save</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <div class="tab-pane fade" id="medicalrecords">
        <ul class="list-group top-20">
            <li class="list-group-item">
                <b class="_17 normal">Medical Records</b>
            </li>
            {{#each record}}
            <li class="list-group-item">
                <div class="row">
                    <div class="col-xs-12">
                        <b class="normal" title={{description}}>{{reason}}<br /><small>({{hospital}})<br />[{{formatDate datefrom  }} - {{formatDate dateTo}}]</small></b>
                        <i class="fa fa-pencil-square-o pull-right" onclick="toggleElement('name_edit')"></i>
                        <i class="fa fa-remove pull-right delete" id={{_id}}></i>
                    </div>
                </div>
            </li>
            {{/each}}
        </ul>

        <div class="col-xs-12 no-padd">
            <div class="col-sm-12 no-padd">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Add New Medical Record
                        <i class="fa fa-plus pull-right" onclick="toggleElement('add_record')"></i>
                    </div>
                    <div class="panel-body no-display" id="add_record">
                        <form>
                            <div id="errorDiv"></div>
                            <input type="text" class="hidden" id="patientId" value={{sessionId}}>
                            <div class="form-group">
                                <label>From</label>
                                <input type="date" class="form-control " id="dateFrom">
                            </div>
                            <div class="form-group">
                                <label>To</label>
                                <input type="date" class="form-control " id="dateTo">
                            </div>
                            <div class="form-group">
                                <label>Reason/Description</label>
                                <textarea class="form-control " id="reason"></textarea>
                            </div>
                            <div class="form-group">
                                <label>Hospital</label>
                                <input type="text" class="form-control " id="hostipal">
                            </div>
                            <div class="form-group">
                                <a class="btn btn-default" href="edit">Back</a>
                                <button class="btn btn-primary pull-right" type="submit">Save</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script type="text/javascript">

    $("#UpdateNameForm").submit(function (e) {
        e.preventDefault();

        if ($("#fName").val().trim() == '' ||
            $("#lName").val().trim() == '') {

            alert('Fields Cannot be empty');
            return false
        }

        var name = {
            firstName: $("#fName").val().trim(),
            lastName: $("#lName").val().trim()
        }

        $.ajax({
            url: '/User/UpdateName',
            type: 'POST',
            data: name,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
                toggleElement('name_edit')
            }
        });
    })

    $("#UpdateGenderForm").submit(function (e) {
        e.preventDefault();

        var user = {
            gender: $("#genderType").val().trim()
        }

        $.ajax({
            url: '/User/UpdateGender',
            type: 'POST',
            data: User,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
                toggleElement('gender_edit')
            }
        });
    })

    $("#UpdateBirthForm").submit(function (e) {
        e.preventDefault();

        var user = {
            birthDate: $("#birthDate").val().trim()
        }

        $.ajax({
            url: '/User/UpdateBirthDate',
            type: 'POST',
            data: User,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
                toggleElement('birthdate_edit')
            }
        });
    })

    $("#UpdateLocationForm").submit(function (e) {
        e.preventDefault();

        var user = {
            location: $("#location").val().trim()
        }

        $.ajax({
            url: '/User/UpdateLocation',
            type: 'POST',
            data: User,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
                toggleElement('location_edit')
            }
        });
    })

    $("#UpdateEthForm").submit(function (e) {
        e.preventDefault();

        var user = {
            ethnicityId: $("#ethType").val()
        }

        $.ajax({
            url: '/User/UpdateEthnicity',
            type: 'POST',
            data: User,
            DataType: 'json',
            success: function (data) {
                var id = $("input[name='ethnicity']:checked").attr('value');
                $("#UsrEthnicity").html(id);
                toggleElement('ethnicity_edit')
            }
        });
    })

    $("#UpdateHeightForm").submit(function (e) {
        e.preventDefault();
        var h1 = $("#height1").val();
        var h2 = $("#height2").val();
        var concat;

        if (isNaN(h1) || isNaN(h2)) {
            Return
        } else {
            concat = h1 + "'" + h2 + "''"
            $("#heightVal").val(concat)
        }

        var bmi;
        height = $("#UsrHeight").html().split("'");
        weight = $("#weight").val();

        var h = (parseInt(height[0]) * 0.3048) + (parseInt(height[1]) * 0.0254)
        h *= h;
        bmi = weight / h

        var user = {
            height: $("#heightVal").val(),
            bmi: bmi.toFixed(2)
        }

        $.ajax({
            url: '/User/UpdateHeight',
            type: 'POST',
            data: User,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
                toggleElement('height_edit')
            }
        });
    })

    $("#UpdateWeightForm").submit(function (e) {
        e.preventDefault();
        var w = $("#weight").val();

        if (isNaN(w)) {
            Return
        } else {
            w += "Kg"
            $("#weightVal").val(w);
        }

        var bmi;
        height = $("#UsrHeight").html().split("'");
        weight = $("#weight").val();

        var h = (parseInt(height[0]) * 0.3048) + (parseInt(height[1]) * 0.0254)
        h *= h;
        bmi = weight / h

        var user = {
            weight: w,
            bmi: bmi.toFixed(2)
        }

        $.ajax({
            url: '/User/UpdateWeight',
            type: 'POST',
            data: User,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
                toggleElement('weight_edit')
            }
        });
    })

    $("#AddHistory1").submit(function (e) {
        e.preventDefault();

        var user = {
            symptom: $("#condition1").val().trim(),
            whoHadIt: $("#relative1").val().trim(),
            age: $("#age1").val().trim()
        }

        $.ajax({
            url: '/User/AddHistory1',
            type: 'POST',
            data: user,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
                toggleElement('edit_history1')
                $(".appendnewhistory").append('<li class="list-group-item">' +
               $("#condition1").val() + '<label class="normal fgray4">(' + $("#relative1").val() + ')</label><i class="fa fa-remove pull-right removeHs" id="' + data.hsId + '" onclick="removeHs(this);"></i></li>');
            }
        });
    })

    $("#AddHistory2").submit(function (e) {
        e.preventDefault();

        var user = {
            symptom: $("#condition2").val().trim(),
            whoHadIt: $("#relative2").val().trim(),
            age: $("#age2").val().trim()
        }

        $.ajax({
            url: '/User/AddHistory2',
            type: 'POST',
            data: user,
            DataType: 'json',
            success: function (data) {
                loadHealthProfile();
                toggleElement('edit_history2')
                $(".appendnewhistory2").append('<li class="list-group-item">' +
               $("#condition2").val() + '<label class="normal fgray4">(' + $("#relative2").val() + ')</label><i class="fa fa-remove pull-right removeHs" id="' + data.hsId + '" onclick="removeHs(this);"></i></li>');
            }
        });
    })

    function removeHs(e) {
        //alert('removing..')
        e.parentNode.remove();
        var hs = {
            historyId: e.id
        }
        $.ajax({
            url: '/User/removeHistory1',
            type: 'POST',
            data: hs,
            DataType: 'json',
            success: function () {
                console.log("Deleted")
            }
        })
    }

    $(".removeHs").click(function (e) {
        e.currentTarget.parentNode.remove();
        var hs = {
            historyId: e.currentTarget.id
        }
        $.ajax({
            url: '/User/removeHistory1',
            type: 'POST',
            data: hs,
            DataType: 'json',
            success: function () {
                console.log("Deleted")
            }
        })
    });
</script>
