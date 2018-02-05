$(document).ready(function () {
    console.log("JavaScript Is here");
    var $theFormDisplay = $("#theForm");
    console.log("Form is created");
    $theFormDisplay.hide();

    var $theFormDisplayNew = $("#theForm1");
    console.log("Form1 is created");

    var $button = $("#submitTheForm1");
    $button.on("click", function (e) {
        e.preventDefault();
        $theFormDisplay.toggle()
    });

});