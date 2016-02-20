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

$("#target").bind("DOMSubtreeModified", function () {
    if ($('ul#target').children('li').length >= 1) {
        $("#detailsText").val("This is the map");    
    }
    else {
        $("textarea").val('');
        $("#detailsText").attr("placeholder", "No loaded data");
    }
});
