
// save as image
$(document).ready(function () {
    var element = $("#myForm"); // global variable
    var getCanvas; //global variable
    html2canvas(element, {
        onrendered: function (canvas) {
            getCanvas = canvas;
        }
    });

    $("#btn-Convert-Html2Image").on('click', function () {
        var imageData = getCanvas.toDataURL("image/png");
        //Now browser starts downloading it instead of just showing it
        var newData = imageData.replace(/^data:image\/png/, "data:application/octet-stream");
        $("#btn-Convert-Html2Image").attr("download", "your_image.png").attr("href", newData);
    });
});