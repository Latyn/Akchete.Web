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
$("#target").bind("DOMSubtreeModified", function () {
    if ($('ul#target').children('li').length >= 1) {
        var t = mod;
        var eventli = $('ul#target').children('li').first();
        var elId = eventli.attr("id");
        var modEl = mod[elId - 1];
        $("#detailsText").val(modEl.Details);
        Init(modEl.Latitude, modEl.Longitude);
    }
    else {
        $("textarea").val('');
        $("#detailsText").attr("placeholder", "No loaded data");
    }
});

