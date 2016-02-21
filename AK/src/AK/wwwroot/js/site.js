(function RecoverMenuData() {

    var selected = sessionStorage.getItem('selectedMenu');

    if (selected && selected >= 0) {
        $("#navbar li").eq(selected).addClass('active').siblings().removeClass('active');
    }

}());

// Persisten selected menu item
(function selectedMenu() {
$("#navbar li").on("click", function () {
    $(this).addClass('active').siblings().removeClass('active');
    sessionStorage.setItem('selectedMenu', $(this).index());
});
}());

// Element activates map on List Event View
$("#source div").on("click", function () {

        var t = mod;
        var elId = $(this).attr("id");
        var modEl = mod[elId - 1];
        $("#detailsText").val(modEl.Details);
        Init(modEl.Latitude, modEl.Longitude);
 
        //$("textarea").val('');
        //$("#detailsText").attr("placeholder", "No loaded data");
    
});

$("#main_menu").click(function () {
    $("#main_menu").fadeOut("slow", function () {
        // Animation complete.
    });
});
