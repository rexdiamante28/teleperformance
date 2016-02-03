function loadHealthProfile() {
    $.ajax({
        url: '/User/getAppUser',
        type: 'GET',
        dataType: 'json',
        success: function (d) {
            $("#fName").val(d.firstName);
            $("#lName").val(d.lastName);
            $("#UsrName").html(d.name);
            $("#UsrGender").html(d.gender);
            if (d.gender == "Male") {
                $("#male").click()
            } else if (d.gender == "Female") {
                $("#female").click()
            }
            $("#UsrLocation").html(d.location);
            $("#location").val(d.location);
            var bDate = new Date(parseInt(d.birthDate.replace("/Date(", "").replace(")/", ""), 10)).toDateString();
            $("#UsrBirthDate").html(bDate);
            $("#birthDate").val(new Date(parseInt(d.birthDate.replace("/Date(", "").replace(")/", ""), 10)).toLocaleDateString());
            $("#" + d.ethnicityId).click();
            var id = $("input[name='ethnicity']:checked").attr('value');
            $("#UsrEthnicity").html(id)
            $("#UsrHeight").html(d.height);
            var height = d.height
            var h = height.split("'");
            $("#height1").val(h[0]);
            $("#height2").val(h[1]);
            $("#UsrWeight").html(d.weight);
            var weight = d.weight
            weight = weight.replace("Kg", "");
            $("#weight").val(weight);
            $("#UsrBmi").html(d.bmi);

        },
        error: function (err) {
            console.log(err)
        }

    })
}

