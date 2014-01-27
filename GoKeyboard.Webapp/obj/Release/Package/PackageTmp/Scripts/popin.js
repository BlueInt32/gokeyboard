$(function () {
    $(".showPopin").click(function (e) {
        e.preventDefault();
        ShowPopinBase();
        //ShowPopinWithUrl('popin.html');
    });
});
function ShowPopinWithUrl(url) {
    $("#popin").empty();
    $("#popin").load(url, function () {
        ShowPopinBase();
    });


}
function ShowPopinBase() {
    if ($("#mask").size() == 0) {
        var divMask = '<div id="mask"></div>';
        $("body").append(divMask);
    }
    $(".closePopin").add("#mask").click(function (e) {
        e.preventDefault();
        $("#popin").fadeOut(400);
        $("#mask").fadeOut(400);
        return false;
    });
    $("#mask").fadeIn(250);
    $("#popin").fadeIn();
}