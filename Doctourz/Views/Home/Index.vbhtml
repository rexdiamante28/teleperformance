@Code
    ViewData("Title") = "Home Page"
    Layout = "../Shared/_WebsiteLayout.vbhtml"
End Code



<div class="box-layout" >
    <div class="intro">
        <div class="intro-body">
            <div class="jumbotron half-opac text-center">
                <p style="color: #336799; font-size:80px; font-weight:900; line-height:60%;">Global Healthcare</p>
                <p style="color: #428BD8; font-size:70px; font-weight:900; text-indent:350px; line-height:60%;">Customized by YOU...</p>
                <text style="color: #336799; font-weight: bold; font-size: 17px; line-height:400%;">Let us match you with a Doctor today.</text>
                <div class="row">
                    <div class="col-xs-6 col-xs-offset-3">
                        <a href="#learn" class="btn btn-lg" style="width: 150px; border: 2px solid #336799;background-color: transparent !important;color: #336799"><strong>Learn more</strong></a>
                        <a href="/Account/Register" class="btn btn-lg btn-warning" style="width: 150px; background-color:#F26E23;"><strong>Sign up</strong></a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="col-xs-12 no-padd">
        <div class="" style="background-color: #336799;padding-bottom: 60px; padding-top:15px;">
            <div class="col-xs-12 col-sm-10 col-sm-offset-1">
                <form name="search-physician">
                    <div class=" text-center">
                        <div class="col-xs-3 padd-5 ">
                            <strong style="color: white;font-weight: bold;font-size: 20px">Find a Physician</strong>
                        </div>
                        <div class="col-xs-3  ">
                            <input type="text" name="location" placeholder="Specializing in..." class="form-control input-lg" />
                        </div>
                        <div class="col-xs-3 ">
                            <input type="text" name="specialization" placeholder="Located in..." class="form-control input-lg"  />
                        </div>
                        <div class="col-xs-3 ">
                            <button type="submit" class="btn btn-lg" style="background-color: #488DD0;color: white;width: 150px"><strong>Search</strong></button>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>

    <div class="row step-page" id="learn">
        <div class="col-xs-12 text-left top-50">
            <h1 style="font-weight: 600; color:#262626 ;font-size: 60px" class="text-center">We're here with you every step of the way</h1>
            <div style="background-image: url('../../Content/Images/Website/greenbar.png');height: 200px;background-position:center;background-repeat:no-repeat !important">
                <ul class="nav nav-pills round-pills text-center" role="tablist" style="margin-left:250px;">
                    <li class="active"><a href="#1" role="tab" data-toggle="tab">1</a><span class="step-text"><br/><br/><br/>PHYSICIAN SEARCH</span></li>
                    <li><a href="#2" role="tab" data-toggle="tab">2</a><span class="step-text"><br /><br /><br />NURSE CONCIERGE</span></li>
                    <li><a href="#3" role="tab" data-toggle="tab">3</a><span class="step-text"><br /><br /><br />TELEMED<br>CONSULTATION</span></li>
                    <li><a href="#4" role="tab" data-toggle="tab">4</a><span class="step-text"><br /><br /><br />FOLLOW-UP CARE</span></li>
                </ul>
            </div>
            <div class="tab-content">
                <div role="tabpanel" class="tab-pane active" id="1">
                    <div class="col-sm-8 col-sm-offset-2">
                        <div class="col-sm-7">
                            <p style="font-size:15px;" class="top-50">DOCTOURZ Matching Algorithm (DMA) is a state-of-the-art physician search engine built with a behavioral science algorithm that delivers real-time matching solutions.</p>
                        </div>
                        <div class="col-sm-5 no-padd">
                            <img src="~/Content/Images/Website/img1.png" class="col-xs-12" />
                        </div>
                    </div>
                </div>
                <div role="tabpanel" class="tab-pane" id="2">
                    <div class="col-sm-8 col-sm-offset-2">
                        <div class="col-sm-7">
                            <p style="font-size:15px;" class="top-50">Our 24/7 medical concierge staff is able and willing to assist yout with you every query you need. Anytime, anywhere at your convinience.</p>
                        </div>
                        <div class="col-sm-5 no-padd">
                            <img src="~/Content/Images/Website/123_2.png" class="col-xs-12" />
                        </div>
                    </div>
                </div>
                <div role="tabpanel" class="tab-pane" id="3">
                    <div class="col-sm-8 col-sm-offset-2">
                        <div class="col-sm-7">
                            <p style="font-size:15px;" class="top-50">Doctourz can facilitate hassle free patient-physician consults at the comfort of your own home.</p>
                        </div>
                        <div class="col-sm-5 no-padd">
                            <img src="~/Content/Images/Website/123_3.png" class="col-xs-12" />
                        </div>
                    </div>
                </div>
                <div role="tabpanel" class="tab-pane" id="4">
                    <div class="col-sm-8 col-sm-offset-2">
                        <div class="col-sm-7">
                            <p style="font-size:15px;" class="top-50">With the use of our wearable apps, it will allow trained medical staff to provide the best follow-up patient care.</p>
                        </div>
                        <div class="col-sm-5 no-padd">
                            <img src="~/Content/Images/Website/123_4.png" class="col-xs-12" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class="col-xs-12 no-padd">
        @*<div id="myCarousel" class="carousel slide" data-ride="carousel" data-interval="3000" data-pause="false">
            <!-- Indicators
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>
             -->
            <!-- Wrapper for slides -->
            <div class="carousel-inner" role="listbox">
                <div class="item active relative">
                    <img src="~/Content/Images/Website/Ad1.jpg"  class="col-xs-12 no-padd">
                    <div  style="position: absolute; right:15%; top:30vh; opacity: .8;">
                        <h1 class="bold text-center" style="font-size:120px; color:#46AADC; line-height:80%;">
                            Healthcare<br/>
                            For All.<br/>
                            Affordable.<br/>
                            Accessible.<br/>
                        </h1>
                    </div>
                </div>

                <div class="item relative">
                    <img src="~/Content/Images/Website/Ad2.jpg" class="col-xs-12 no-padd">
                    <div style="position: absolute; right:10%; top:30vh; opacity: .8;">
                        <h1 class="bold text-left" style="font-size:110px; color:#CA592D; line-height:80%;">
                            Matching<br />
                            your Medical<br />
                            needs with<br />
                            Top Physicians<br />
                            Globally<br />
                        </h1>
                    </div>
                </div>

                <div class="item relative">
                    <img src="~/Content/Images/Website/Ad3.jpg" class="col-xs-12 no-padd">
                    <div style="position: absolute; right:2%; top:20vh; opacity: .8;">
                        <h1 class="bold text-center" style="font-size:110px; color:#CA592D; line-height:95%;">
                            Saving Lives<br />
                            Empowering<br />
                            Nations.<br />
                        </h1>
                        <hr/>
                        <h4 style="font-size:30px;">
                            The health of the community is important<br/> to us. Donate a telemed session to a child<br/> in need.<br/><br/>
                            <button class="btn btn-warning" style="background-color: #F26E23 !important; height:60px; font-size:30px;">DONATE</button>
                        </h4>
                    </div>
                </div>

                <div class="item relative">
                    <img src="~/Content/Images/Website/Ad4.jpg" class="col-xs-12 no-padd">
                    <div style="position: absolute; right:2%; top:10vh; opacity: .8;">
                        <h1 class="bold text-center" style="font-size:110px; color:#CA592D; line-height: 80%;">
                            Be a part<br />
                            of the<br />
                            Healthcare<br />
                            Revolution<br />
                        </h1>
                        <hr />
                        <h4 style="font-size:30px;">
                            We want the best of the best, our services are<br />catered to maximize your practice<br /> in need.<br /><br />
                            <button class="btn btn-info" style="background-color: #32B7F8 !important;  height:60px; font-size:30px;">LEARN MORE</button>
                        </h4>
                    </div>
                </div>
            </div>
            <div>

            </div>

            <!-- Left and right controls
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
             -->
        </div>*@
        <div id="myCarousel" class="carousel slide" data-ride="carousel" data-interval="3000" data-pause="false">
            <div class="carousel-inner" role="listbox">
                <div class="item active relative">
                    <img src="~/Content/Images/Website/New/img1.png" class="col-xs-12 no-padd">
                </div>

                <div class="item relative">
                    <img src="~/Content/Images/Website/New/img2.png" class="col-xs-12 no-padd">
                </div>

                <div class="item relative">
                    <img src="~/Content/Images/Website/New/img3.png" class="col-xs-12 no-padd">
                </div>

                <div class="item relative">
                    <img src="~/Content/Images/Website/New/img4.png" class="col-xs-12 no-padd">
                </div>
            </div>
            <div>
            </div>
        </div>
    </div>
    <div class="col-xs-12 text-center padd-30">
        <h1 class="custom-fblue bold" style="font-size:60px;">Driving Worldclass Patient Experience</h1>
    </div>
    <img class="col-xs-12" src="~/Content/Images/Website/Section4.png" />

    <div class="col-xs-12 no-padd" style="background-image: url(../../Content/Images/Website/blueBG.png);background-size: cover;background-position:center;background-repeat: no-repeat">
        <div class="mybody-content text-center" id="registration">
            <h1 style="font-size:45px;" class="fwhite">The vision of DOCTOURZ is to make healthcare<br />personal and accessible. <br /> Join the Healthcare revolution</h1>
            <div class="col-xs-12 top-50" style="padding-bottom: 100px">
                <form class="form-inline" role="form">
                    <div class="form-group">
                        <select class="form-control input-lg" id="type">
                            <option>I am a...</option>
                            <option>I am a patient</option>
                            <option>I am a doctor</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <input type="email" class="form-control input-lg" placeholder="Email" id="email">
                    </div>
                    <button type="submit" class="btn btn-warning btn-lg" style="background-color:#F26E23;">Signup</button>
                </form>
            </div>
        </div>
    </div>
</div>