@ModelType IEnumerable(Of Doctourz.Questions)
@Code
    ViewData("Title") = "TakeSurvey"
    Layout = "~/Views/Shared/_UserLayout.vbhtml"
End Code


@Using Html.BeginForm("TakeSurvey", "Question", Nothing, FormMethod.Post, New With {.id="SurveyForm"})
    

@<div class="col-sm-6 col-sm-offset-3 no-padd">
    @If (ViewBag.message IsNot Nothing) Then
        @<div class="alert alert-success">
            @ViewBag.message
        </div>
    End If
     
    <div class="col-sm-12 bgwhite top-100">
        <div id="myTabContent" class="tab-content">
                @code
                    Dim b As Integer = 1
                    Dim c As Integer = 0
                    Dim d As Integer = 2
                    Dim conditionalClass As String = "in active"
                    Dim conditionalClass2  As String = "previous disabled"
                    Dim count As Integer = Model.Count
                @For Each question In Model
                    @<div class="col-xs-12 tab-pane fade  @If b =1 Then @conditionalClass End If" id="q_@b">
                        <h4>@question.question<label class="pull-right"></label> <b class="pull-right text-muted">@b of @count</b></h4>
                        <hr />
                        @If question.isNegative Then
                            @<div class="form-group">
                                <label><input id='1_@question.questionId' type="radio" name=@question.questionId value="1 @question.traitId"> Strongly Agree</label><br />
                                <label><input id='2_@question.questionId' type="radio" name=@question.questionId value="2 @question.traitId"> Agree</label><br />
                                <label><input id='3_@question.questionId' type="radio" name=@question.questionId value="3 @question.traitId"> Neither Agree nor Disagree</label><br />
                                <label><input id='4_@question.questionId' type="radio" name=@question.questionId value="4 @question.traitId"> Disagree</label><br />
                                <label><input id='5_@question.questionId' type="radio" name=@question.questionId value="5 @question.traitId"> Strongly Disagree</label><br />
                            </div>
                        Else
                            @<div class="form-group">
                                <label><input id='1_@question.questionId' type="radio" name=@question.questionId value="5 @question.traitId"> Strongly Agree</label><br />
                                <label><input id='2_@question.questionId' type="radio" name=@question.questionId value="4 @question.traitId"> Agree</label><br />
                                <label><input id='3_@question.questionId' type="radio" name=@question.questionId value="3 @question.traitId"> Neither Agree nor Disagree</label><br />
                                <label><input id='4_@question.questionId' type="radio" name=@question.questionId value="2 @question.traitId"> Disagree</label><br />
                                <label><input id='5_@question.questionId' type="radio" name=@question.questionId value="1 @question.traitId"> Strongly Disagree</label><br />
                            </div>
                        End If
                         <ul class="pager">
                             <li><a data-toggle="tab" href="#q_@c" class="@If b = 1 Then @conditionalClass2 End If">Previous</a></li>
                             <li><a data-toggle="tab" href="#q_@d" class="@If b = count Then @conditionalClass2  End If">Next</a></li>
                         </ul>
                         @If b >= count Then
                         @<div class="col-xs-12 bottom-20">
                             <button type="submit" class="btn btn-primary pull-right" id="saveSurvey">Save</button>
                         </div>
                         End If

                    </div>
                                     b = b + 1
                                     c = c + 1
                                     d = d + 1
                        
                    
                Next
                End Code
                <div class="btn-toolbar b bottom-20 pull-right">
                    <div class="btn-group">
                        @code
                            Dim a As Integer = 1
                            @For Each question In Model
                                @<a href="#q_@a" class="btn btn-default btn-sm" data-toggle="tab">@a</a>
                                a += 1
                            Next
                        End Code
                    </div>
                </div>
            </div>
    </div>
</div>

End Using