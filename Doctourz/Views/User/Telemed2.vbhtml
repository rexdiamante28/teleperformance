@Imports Microsoft.AspNet.Identity
@Code
    Layout = "../Shared/_UserLayout.vbhtml"

    Dim db = New ApplicationDbContext
    Dim appUser As String = User.Identity.GetUserName
    Dim name = db.AppUsers.Where(Function(model) model.userName = appUser).First().name
    Dim avatar = db.AppUsers.Where(Function(model) model.userName = appUser).First().avatar

    ViewData("Name") = name
    ViewData("Avatar") = avatar

End Code
<input id="txtName" type="hidden" value="@ViewData("Name")" />
<input id="roomName" type="hidden" value="@ViewData("Room")" />

<div id="acceptCallBox">
    <div id="acceptCallLabel"></div>
    <div class="text-center top-30">
        <input type="button" id="callAcceptButton" class="btn btn-success btn-sm" value="Accept" /> <input type="button" id="callRejectButton" class="btn btn-danger btn-sm" value="Reject" />
    </div>
</div>


<div id="main-frame">
    <div id="video" class="publisherContainer">
        <div id="subscribers" class="subscribersContainer"></div>
        <div id="info" class="info-open">
            <div class="header">
                <text id="l1" class="fwhite _13 pull-right">INFO &nbsp;<i class="fa fa-file-text-o"></i></text>
                <i id="l2" class="pull-right fa fa-file-text-o fwhite opener" style="display:none;" onclick="ExpandInfo()"></i>
                <i id="l3" class="pull-left fa fa-minus fwhite" style="font-size:10px;margin-top:10px;" onclick="CompressInfo()"></i>
            </div>

            <ul class="list-group" id="patient-initial-info">
                <li class="list-group-item">
                    <text class="bold">PATIENT: </text><text>Patient Name</text>
                </li>
                <li class="list-group-item">
                    <text class="bold">VITALS: </text><text>Vitals Here</text>
                </li>
                <li class="list-group-item">
                    <text class="bold">AGE: </text><text>20 Years old</text>
                </li>
                <li class="list-group-item">
                    <text class="bold">SEX: </text><text>Male</text>
                </li>
                <li class="list-group-item">
                    <text class="bold">BP: </text><text>100/70</text>
                </li>
                <li class="list-group-item">
                    <div class="row">
                        <div class="col-xs-12">
                            <text class="bold">NOTES:</text><br />
                            <textarea class="form-control " style="height:200px;" placeholder="Write your notes here"></textarea>
                            <button class="btn btn-default pull-right top-10">Save</button>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
        <div id="myCamera" class="publisherContainer"></div>
        <div id="chat" class="chat-open">
            <div class="header">
                <div class="row">
                    <div class="col-xs-12">
                        <text id="r1" class="fwhite _13" style="margin-bottom:3px;"><i class="fa fa-comments"></i> CHAT</text>
                        <i id="r2" class="pull-left fa fa-comments fwhite opener" style="display:none;" onclick="ExpandChat()"></i>
                        <i id="r3" class=" fa fa-minus fwhite" style="font-size:10px;margin-left:200px;" onclick="CompressChat()"></i>
                    </div>
                </div>
            </div>
            <div id="messaging-controls" class="messaging-controls">
            </div>
            <div id="chatbox" class="padd-10" style="min-height:60vh;">

            </div>
            <div id="message-box" class="list-group-item">
                <div class="input-group">
                    <textarea type="text" id="chatMessage" style="max-height:53px;" class="form-control" placeholder="Type your message..."></textarea>
                    <span class="input-group-btn">
                        <button class="btn btn-primary" id="chatSendButton" type="button" style="height:53px;">Send</button>
                    </span>
                </div>
            </div>
        </div>
    </div>
    <div id="controls">
        <div class="row">
            <div class="col-xs-12">
                <div id="onlineusers">
                    <i class="fa fa-users"></i>
                </div>
                <div id="controls-frame" class="text-center">
                    <i class="fa fa-volume-down" onclick="countSubscriber()" style="margin-right:0px;" title="Adjust volume"></i>
                    <input type="number" class="slider" ondrag="TestAlert('sdg')" value="" style="width:50px;margin-top:0px;" data-slider-min="0" data-slider-max="100" data-slider-step="1" data-slider-value="70" data-slider-orientation="horizontal" data-slider-selection="after" data-slider-tooltip="show">
                    <i id="endCall" class="fa fa-phone"></i>
                    <a id="videoControl" onclick="HideElement(this.id), ShowElement('videoControlSlashed')" title="Disable video"><i class="fa fa-video-camera"></i></a>
                    <a id="videoControlSlashed" class="no-display" onclick="HideElement(this.id), ShowElement('videoControl')" title="Enable video"><i class="fa fa-eye-slash"></i></a>
                    <a id="audioControl" onclick="HideElement(this.id), ShowElement('audioControlSlashed')"><i class="fa fa-microphone" title="Disable audio"></i></a>
                    <a id="audioControlSlashed" onclick="HideElement(this.id), ShowElement('audioControl')" class="no-display" title="Enable audio"><i class="fa fa-microphone-slash"></i></a>
                    <a id="recordStart" style="color:red !important;" onclick="HideElement(this.id), ShowElement('recordStop')" class="fred1" title="Start recording"><i class="fa fa-stop fred1" style="color: red;"></i></a>
                    <a id="recordStop" style="color:red !important;" onclick="HideElement(this.id), ShowElement('recordStart')" class="no-display fred1" title="Stop recording"><i class="fa fa-play fred1" style="color: red;"></i></a>
                    <a id="selfVideo" onclick="HideElement(this.id), ShowElement('sefVideoHidden'), HideElement('myCamera')" class="" title="Enable audio"><i class="fa fa-compress" title="hide self video"></i></a>
                    <a id="sefVideoHidden" onclick="HideElement(this.id), ShowElement('selfVideo'), ShowElement('myCamera')" class="no-display" title="Enable audio"><i class="fa fa-expand" title="Show self video"></i></a>
                </div>
            </div>
        </div>
    </div>
</div>

<audio id="rigning" style="display :none" loop>
    <source src="~/media/ringing .mp3" type="audio/mpeg">
</audio>

@Section scripts
    <script src="~/Scripts/opentok.min.js" type="text/javascript" charset="utf-8"></script>
    <script src="@Url.Content("~/Scripts/opentok2.2.js")" type="text/javascript" charset="utf-8"></script>
    <script src="~/Scripts/jquery.signalR-2.2.0.min.js"></script>
    <script src="~/signalr/hubs"></script>



    <script>
        // This optional function html-encodes messages for display in the page.
        function htmlEncode(value) {
            var encodedValue = $('<div />').text(value).html();
            return encodedValue;
        }

        function getCaret(el) {
            if (el.selectionStart) {
                return el.selectionStart;
            } else if (document.selection) {
                el.focus();
                var r = document.selection.createRange();
                if (r == null) {
                    return 0;
                }
                var re = el.createTextRange(), rc = re.duplicate();
                re.moveToBookmark(r.getBookmark());
                rc.setEndPoint('EndToStart', re);
                return rc.text.length;
            }
            return 0;
        }

        $('#chatMessage').keyup(function (event) {
            if (event.keyCode == 13) {
                var content = this.value;
                var caret = getCaret(this);
                if (event.shiftKey) {
                    this.value = content.substring(0, caret - 1) + "\n" + content.substring(caret, content.length);
                    event.stopPropagation();
                } else {
                    this.value = content.substring(0, caret - 1) + content.substring(caret, content.length);
                    $('#chatSendButton').click();

                }
            }
        });


        function countSubscriber() {
            var a = $('.callSubscriber');
            var b = parseInt(a.length);

            if (b == 1) {
                a.css({ "width": "100%", "height": "73vh" });
                $('#subscribers').css({ "width": "100%", "top": "0px", "left": "0px" });
                $('#opentok_publisher').css({ "width": "100", "height": "75px" });
                $('#myCamera').css({ "bottom": "0px", "left": "46%", "width": "108px" });
            }
            else if (b == 2) {
                a.css({ "width": "49%", "height": "38vh" });
                $('#subscribers').css({ "width": "50%", "top": "100px", "left": "25%" });
                $('#opentok_publisher').css({ "width": "170", "height": "120px" });
                $('#myCamera').css({ "bottom": "20px", "left": "43.5%", "width": "178px" });
            }
            else {
                a.css({ "width": "32%", "height": "35vh" });
                $('#subscribers').css({ "width": "80%", "top": "120px", "left": "10%" });
                $('#opentok_publisher').css({ "width": "170", "height": "120px" });
                $('#myCamera').css({ "bottom": "20px", "left": "43.5%", "width": "178px" });
            }
            setTimeout(countSubscriber, 1000);
        }

        countSubscriber();

        CompressInfo();
        CompressChat();

        document.getElementById('topbar0').setAttribute("class", "bggray5");


        $(function () {

            var rtc = $.connection.rTCHub;
            var name = document.getElementById("txtName").value;
            var avatar = document.getElementById('myAvatar').getAttribute("src");
            var user;



            var selfuser, caller;


            rtc.client.addNewMessageToPage = function (name, message, senderAvatar) {
                // Add the message to the page.
                var chat = document.getElementById('chat');
                var chatStatus = chat.getAttribute("class");

                if (chatStatus != "chat-open") {
                    $('#r2').css("color", "red");
                }

                $('#chatbox').append("" +
                        '<div class="col-xs-12 bgwhite padd-10 top-10">' +
                            '<img src="' + senderAvatar + '"  class="img-circle chatAvatar" style="width:30px;"/>' +
                           '<text class="custom-fblue bold">&nbsp;' + name + '</text>' +
                            '<p class="fgray3">' + message + '</p>' +
                        '</div>'
                );


                $("#chatbox").animate({ scrollTop: $("#chatbox")[0].scrollHeight }, 500);


            };

            function show(id) {
                document.getElementById(id).style.display = 'inline-block';
            }

            function hide(id) {
                document.getElementById(id).style.display = 'none';
            }

            rtc.client.getOnlineUsers = function (users) {

                $.each(users, function (key, user) {
                    if (user.Name != $('#txtName').val()) {
                        OnlineUsers.addButton(user);
                    }
                    else {
                        selfuser = user;
                    }
                });

            }


            rtc.client.getNewOnlineUser = function (user) {
                var room = document.getElementById('roomName').value;
                OnlineUsers.addButton(user);
                //server.sendMessage("TeleMed", user.Name + " has joined the chat.", "", user.Opentok.SessionId,room);


            };
            rtc.client.disconnected = function (user) {
                var room = document.getElementById('roomName').value;
                OnlineUsers.removeButton(user);
                ///rtc.server.sendMessage("TeleMed", user.Name + " has disconnected from chat.", "", user.Opentok.SessionId,room);
            }

            rtc.client.notifybeginCall = function (touser, caller_user) {

                acceptCallBox.show();
                acceptCallBox.message('Incoming call from ' + caller_user.Name);
                caller = caller_user;
                ringing.play();
            }




            rtc.client.notifyCallend = function (self, caller) {

                if (acceptCallBox.IsVisible()) {

                    acceptCallBox.hide();
                    ringing.mute();

                }
                else {

                    btn = document.getElementById("btn_" + caller.ConnectionId);

                    if (btn) {
                        endCall(btn, "Call " + caller.Name);
                        Opentok.disconnect();
                        Opentok.connect(self.Opentok);

                    }


                }

            }

            rtc.client.notifyCallrejected = function (message, calleruser) {
                alert(message);
                var btn = document.getElementById("btn_" + calleruser.ConnectionId);
                if (btn.value == "")
                    endCall();
                ringing.mute();
            }


            document.getElementById('callAcceptButton').onclick = function () {

                _btn = document.getElementById('btn_' + caller.ConnectionId);
                beginCall(_btn);
                Opentok.disconnect();
                Opentok.connect(caller.Opentok);
                ringing.mute();
                acceptCallBox.hide();




            }
            document.getElementById('callRejectButton').onclick = function () {
                acceptCallBox.hide();
                ringing.mute();

                rtc.server.callRejectedSignal(caller.ConnectionId);
            }


            $(document).ready(function () {

                $('.slider').slider();

                $.connection.hub.start().done(function () {
                    var room = document.getElementById('roomName').value;



                    rtc.server.getConnected(name, avatar, 'http://localhost:13624', room).done(function (thisUser) {
                        Opentok.connect(thisUser.Opentok);
                        user = thisUser;
                    });


                    $('#chatSendButton').click(function () {
                        // Call the Send method on the hub.
                        var room = document.getElementById('roomName').value;
                        var myAvatar = document.getElementById('myAvatar').getAttribute("src");
                        rtc.server.sendMessage($('#userFullName').html(), $('#chatMessage').val(), myAvatar, user.Opentok.SessionId, room);
                        // Clear text box and reset focus for next comment.
                        $('#chatMessage').val('').focus();
                    });

                });


            });

            $('#disconnectLink').click(function () {
                rtc.server.getDisConnected().done(function () {
                    Opentok.disconnect();
                    OnlineUsers.removeAllButtons();
                });
            });


        })


        $('#r2').click(function () {
            $('#r2').css("color", "white");
        });

        $('#videoControl').click(function () {
            publisher.publishVideo(false);
        });

        $('#videoControlSlashed').click(function () {
            publisher.publishVideo(true);
        });

        $('#audioControl').click(function () {
            publisher.publishAudio(false);
        });

        $('#audioControlSlashed').click(function () {
            publisher.publishAudio(true);
        });
        $('#endCall').click(function () {
            window.location.reload(false);
        })

    </script>

<script>
    document.getElementById('topbar2').setAttribute("class", "bggray5");

    var width = window.innerWidth;

    if (width < 768) {
        window.location = "/User/mobiletelemed?room=room1";
    }

</script>

End Section


