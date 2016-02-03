<div class="col-xs-12">
    <ul class="list-group ">
        <li class="list-group-item ">
            <div class="row">
                <div class="col-xs-12">
                    <label class="fgray3">HISTORY:&nbsp;&nbsp;&nbsp;&nbsp;</label><b class="normal fgray3" id="patient_name"></b>
                    <table class="table table-striped table-hover ">
                        <thead>
                            <tr>
                                <th>From</th>
                                <th>To</th>
                                <th>Reason</th>
                                <th>Hospital</th>
                            </tr>
                        </thead>
                        <tbody>
                            {{#each history}}
                            <tr>
                                <td>{{formatDate datefrom}}</td>
                                <td>{{formatDate dateTo}}</td>
                                <td>{{reason}}</td>
                                <td>{{hospital}}</td>
                            </tr>
                            {{/each}}
                        </tbody>
                    </table>

                </div>
            </div>
        </li>
        <li class="list-group-item ">
            <div class="row">
                <div class="col-xs-12">
                    <label class="fgray3">MEDICATIONS:&nbsp;&nbsp;&nbsp;&nbsp;</label><b class="normal fgray3" id="patient_vitals"></b>
                    <table class="table table-striped table-hover ">
                        <thead>
                            <tr>
                                <th>Condition</th>
                                <th>Description</th>
                                <th>Medications</th>
                            </tr>
                        </thead>
                        <tbody>
                            {{#each conditions}}
                            <tr>
                                <td>{{condition}}</td>
                                <td>{{description}}</td>
                                <td>{{medications}}</td>
                            </tr>
                            {{/each}}
                        </tbody>
                    </table>
                </div>
            </div>
        </li>
        <li class="list-group-item ">
            <div class="row">
                <div class="col-xs-12">
                    <label class="fgray3">ALLERGIES:&nbsp;&nbsp;&nbsp;&nbsp;</label><b class="normal fgray3" id="patient_age"></b>
                    <table class="table table-striped table-hover ">
                        <thead>
                            <tr>
                                <th>Type</th>
                                <th>Particular</th>
                            </tr>
                        </thead>
                        <tbody>
                            {{#each allergies}}
                            <tr>
                                <td>{{type}}</td>
                                <td>{{particular}}</td>
                            </tr>
                            {{/each}}
                        </tbody>
                    </table>
                </div>
            </div>
        </li>
        <li class="list-group-item ">
            <div class="row">
                <div class="col-xs-12">
                    <label class="fgray3">PREVIOUS PHYSICIANS:&nbsp;&nbsp;&nbsp;&nbsp;</label><b class="normal fgray3" id="patient_age"></b>
                </div>
            </div>
        </li>
        <li class="list-group-item ">
            <div class="row">
                <div class="col-xs-12">
                    <label class="fgray3">NAME:&nbsp;&nbsp;&nbsp;&nbsp;</label><b class="normal fgray3" id="patient_age"></b>
                    <label class="fgray3">TELEPHONE:&nbsp;&nbsp;&nbsp;&nbsp;</label><b class="normal fgray3" id="patient_age"></b>
                    <label class="fgray3">EMAIL:&nbsp;&nbsp;&nbsp;&nbsp;</label><b class="normal fgray3" id="patient_age"></b>
                </div>
            </div>
        </li>

        <li class="list-group-item  top-20">
            <div class="row">
                <div class="col-xs-12 padd-10">
                    <label class="fgray3">X-RAYS,EKGS, ETC.:&nbsp;&nbsp;&nbsp;&nbsp;</label><b class="normal fgray3" id="patient_age"></b><br />
                    <div class="col-sm-3">
                        <div class="file-thumbnail">

                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="file-thumbnail">

                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="file-thumbnail">

                        </div>
                    </div>
                    <div class="col-sm-3">
                        <div class="file-thumbnail">

                        </div>
                    </div>
                </div>
            </div>
        </li>

    </ul>
</div>