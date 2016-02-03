@Code
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
    
    Dim db As New ApplicationDbContext
    Dim spCategory = db.SpecializationCategory
    Dim degrees = db.Degree
    Dim searchKeyword As String = ""
    Dim searchFIlterLocation As String = ""
    If Not ViewBag.Keyword = "" Then
        searchKeyword = ViewBag.Keyword.ToString()
    End If
    If Not ViewBag.Location = "" Then
        searchFIlterLocation = ViewBag.Location.ToString()
    End If
End Code

<div class="col-xs-12 col-md-6 col-sm-offset-3">
    <div>
        <input id="SearchText" type="text" class="form-control" placeholder="Search answers, topics, doctors">
    </div>

    <div id="searchDoctor" style="display:none">
        <div class="col-sm-4 no-padd top-20">
            <ul class="list-group point" id="patient-initial-info">
                <li class="list-group-item">
                    <text class="bold">Filter Doctors</text>
                </li>
                <li class="list-group-item" onclick="ToggleElement('availability-option')">
                    <text class="custom-fblue">Availability</text>
                </li>
                <div class="row toggle-hide bggray5" id="availability-option">
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> Today</label><br />
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> This Week</label><br />
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> This Month</label><br />
                    </li>
                </div>

                <li class="list-group-item" onclick="ToggleElement('doctor-location')">
                    <text class="custom-fblue">Near City/ Town</text>
                </li>
                <div class="row toggle-hide bggray5" id="doctor-location">
                    <li class="list-group-item ">
                        @*<input id="FilterLocation" type="text" class="form-control" placeholder="Enter Location" value="@searchFIlterLocation" />*@
                        <input id="FilterLocation" type="text" class="form-control" placeholder="Enter Location" />
                    </li>
                </div>


                <li id="doctor-specialty-li" class="list-group-item" onclick="ToggleElement('doctor-specialty')">
                    <text class="custom-fblue">Specialty</text>
                </li>
                <div class="row toggle-hide bggray5" id="doctor-specialty">
                    @For Each item In spCategory
                        Dim sp As String = ""
                        If ViewBag.Specialty IsNot Nothing Then
                            sp = ViewBag.Specialty
                        End If
                        @<a href="#" class="specialty">
                            <li class="list-group-item ">
                                @*<label class="normal"><input id="category" type="checkbox" name="category" value="@item.id" @(If(sp.Contains(item.id), " checked=""checked""", "")) /> @item.name</label>*@
                                <label class="normal"><input id="category" type="checkbox" name="category" value="@item.id" /> @item.name</label>
                            </li>
                        </a>
                    Next
                </div>
                <input id="toggleSpecialty" type="hidden" />


                <li class="list-group-item" onclick="ToggleElement('language-spoken')">
                    <text class="custom-fblue">Language Spoken</text>
                </li>
                <div class="row toggle-hide bggray5" id="language-spoken">
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="availability" /> Language 1</label>
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="availability" /> Language 2</label>
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="availability" /> Language 3</label>
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="checkbox" name="availability" /> Language 4</label>
                    </li>
                </div>

                <li class="list-group-item" onclick="ToggleElement('doctor-gender')">
                    <text class="custom-fblue">Gender</text>
                </li>
                <div class="row toggle-hide bggray5" id="doctor-gender">
                    <a href="#" class="male">
                        <li class="list-group-item ">
                            @*<label class="normal"><input type="radio" id="male" name="gender" value="male"/> Male</label><br />*@
                            <label class="normal">@Html.RadioButton("gender", "male") Male</label><br />
                        </li>
                    </a>
                    <a href="#" class="female">
                        <li class="list-group-item ">
                            @*<label class="normal"><input type="radio" id="female" name="gender" value="female"/> Female</label><br />*@
                            <label class="normal">@Html.RadioButton("gender", "female") Female</label><br />
                        </li>
                    </a>
                </div>

                <li class="list-group-item" onclick="ToggleElement('doctor-score')">
                    <text class="custom-fblue">DocScore</text>
                </li>
                <div class="row toggle-hide bggray5" id="doctor-score">
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> 1 star or higher</label><br />
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> 2 star or higher</label><br />
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> 3 star or higher</label><br />
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> 4 star or higher</label><br />
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> 5 star</label><br />
                    </li>
                </div>

                <li class="list-group-item" onclick="ToggleElement('doctor-experience')">
                    <text class="custom-fblue">Years in practice</text>
                </li>
                <div class="row toggle-hide bggray5" id="doctor-experience">
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> 5+ years</label><br />
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> 10+ years</label><br />
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> 15+ years</label><br />
                    </li>
                    <li class="list-group-item ">
                        <label class="normal"><input type="radio" name="availability" /> 25+ years</label><br />
                    </li>
                </div>

                <li class="list-group-item" onclick="ToggleElement('doctor-degree')">
                    <text class="custom-fblue">Degrees</text>
                </li>
                <div class="row toggle-hide bggray5" id="doctor-degree">
                    @For Each item In degrees
                        Dim dg As String = ""
                        If ViewBag.Degree IsNot Nothing Then
                            dg = ViewBag.Degree
                        End If
                        @<a href="#" class="degree">
                            <li class="list-group-item ">
                                @*<label class="normal"><input type="checkbox" name="degree" value="@item.id" @(If(dg.Contains(item.id), " checked=""checked""", "")) /> @item.name</label>*@
                                <label class="normal"><input type="checkbox" name="degree" value="@item.id" /> @item.name</label>
                            </li>
                        </a>
                    Next

                </div>
            </ul>
        </div>

        <div id="doctors" class="col-sm-8 no-padd top-20" style="padding-left:20px;">

        </div>
    </div>

    <div id="searchOptions">
        <div class="top-30 bgwhite no-padd col-xs-12 radius-5">
            <div class="col-xs-6">
                <h4 class="fgray3  top-20"><i class="fa fa-stethoscope" style="font-size:30px;"></i> Conditions</h4>
            </div>
            <div class="col-xs-6 no-padd">
                <img src="~/Content/Images/User/search/searchimg1.png" class="col-xs-12 no-padd" />
            </div>
        </div>

        <div class="top-10 bgwhite no-padd col-xs-12 radius-5">
            <div class="col-xs-6">
                <h4 class="fgray3  top-20"><i class="fa fa-list-ol" style="font-size:30px;"></i> Symptoms</h4>
            </div>
            <div class="col-xs-6 no-padd">
                <img src="~/Content/Images/User/search/searchimg2.png" class="col-xs-12 no-padd" />
            </div>
        </div>

        <div class="top-10 bgwhite no-padd col-xs-12 radius-5">
            <div class="col-xs-6">
                <h4 class="fgray3  top-20"><i class="fa fa-user-md" style="font-size:30px;"></i> Doctors</h4>
            </div>
            <div class="col-xs-6 no-padd">
                <img src="~/Content/Images/User/search/searchimg3.png" class="col-xs-12 no-padd" />
            </div>
        </div>

        <div class="top-10 bgwhite no-padd col-xs-12 radius-5">
            <div class="col-xs-6">
                <h4 class="fgray3  top-20"><i class="fa fa-medkit" style="font-size:30px;"></i> Medications</h4>
            </div>
            <div class="col-xs-6 no-padd">
                <img src="~/Content/Images/User/search/searchimg4.png" class="col-xs-12 no-padd" />
            </div>
        </div>

        <div class="top-10 bgwhite no-padd col-xs-12 radius-5">
            <div class="col-xs-6">
                <h4 class="fgray3  top-20"><i class="fa fa-rotate-right" style="font-size:30px;"></i> Procedures</h4>
            </div>
            <div class="col-xs-6 no-padd">
                <img src="~/Content/Images/User/search/searchimg5.png" class="col-xs-12 no-padd" />
            </div>
        </div>

        <div class="top-10 bgwhite no-padd col-xs-12 radius-5">
            <div class="col-xs-6">
                <h4 class="fgray3  top-20"><i class="fa fa-mobile" style="font-size:30px;"></i> Health Apps</h4>
            </div>
            <div class="col-xs-6 no-padd">
                <img src="~/Content/Images/User/search/searchimg6.png" class="col-xs-12 no-padd" />
            </div>
        </div>
    </div>
    
</div>

<script>
    document.getElementById('topbar3').setAttribute("class","bggray5");
</script>

@Section scripts
   <script>
       //SEARCH DOCTOR
        $('#SearchText').keypress(function (e) {
            var code = (e.keyCode ? e.keyCode : e.which);
            if (code == 13) {
                search()
            }
        });

       //MAIN SEARCH FUNCTION
        function search() {

            document.getElementById("searchOptions").style.display = "none";
            document.getElementById("searchDoctor").style.display = "block";

            //KEYWORD
            var keyword = $('input[id=SearchText]').val();
            keyword = keyword.replace(/\s+/g, ',');
            //alert(keyword)

            //GENDER
            var gender = $('input[name=gender]:checked').val();
            if (gender == undefined) {
                gender = ""
            }

            //LOCATION
            var location = document.getElementById('FilterLocation').value;

            //SPECIALTY
            var specialty = [];
            $.each($("input[name='category']:checked"), function () {
                specialty.push($(this).val());
            });

            //DEGREE
            var degree = [];
            $.each($("input[name='degree']:checked"), function () {
                degree.push($(this).val());
            });

            var url = "/User/SearchDoctor?keyword=" + keyword + "&location=" + location + "&specialty=" + specialty + "&gender=" + gender + "&degree=" + degree;
            $('#doctors').load(url)
            //window.location.href = url;
        }

        //FILTER DOCTOR BY GENDER -- MALE
        $(".male").click(function (event) {
            search()
        })

        //FILTER DOCTOR BY GENDER -- FEMALE 
        $(".female").click(function (event) {
            search()
        })

        //FILTER DOCTOR BY LOCATION
        $('#FilterLocation').keypress(function (e) {
            var code = (e.keyCode ? e.keyCode : e.which);
            if (code == 13) {
                search()
            }
        });

        //FILTER DOCTOR BY SPECIALTY
        $(".specialty").click(function (event) {
            search()
        })

        //FILTER DOCTOR BY DEGREES
        $(".degree").click(function (event) {
            search()
        })

        $("#doctor-specialty-li").click(function (event) {
            if ($('#toggleSpecialty').val() == "") {
                $('#toggleSpecialty').val("1");
                $.cookie('toggle') = "1";
            } else {
                if ($('#toggleSpecialty').val() == "0") {
                    $('#toggleSpecialty').val("1");
                    $.cookie('toggle') = "1";
                } else {
                    $('#toggleSpecialty').val("0");
                    $.cookie('toggle') = "0";
                }
            }
        })

    </script>

End Section