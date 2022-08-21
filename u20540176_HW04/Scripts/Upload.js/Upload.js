$(document).ready(function () {

    $(".protein").show();
    $(".carbs").hide();
    $(".veg").hide();
    $(".fruit").hide();
    $(".dairy").hide();
    $("#foodGroup").on("change", function () {
        var val = $(this).val();
        if (val == "1") {
            $(".protein").show();
            $(".carbs").hide();
            $(".veg").hide();
            $(".fruit").hide();
            $(".dairy").hide();
        }
        if (val == "2") {
            $(".protein").hide();
            $(".carbs").show();
            $(".veg").hide();
            $(".fruit").hide();
            $(".dairy").hide();
        }
        if (val == "3") {
            $(".protein").hide();
            $(".carbs").hide();
            $(".veg").show();
            $(".fruit").hide();
            $(".dairy").hide();
        }
        if (val == "4") {
            $(".protein").hide();
            $(".carbs").hide();
            $(".veg").hide();
            $(".fruit").show();
            $(".dairy").hide();
        }
        if (val == "5") {
            $(".protein").hide();
            $(".carbs").hide();
            $(".veg").hide();
            $(".fruit").hide();
            $(".dairy").show();
        }

    });


})