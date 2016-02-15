//(function SideBarFunction() {
//    var $sidebar = $("#sidebar");
//    var $wrapper = $("#Wrapper");
//    var $icon = $("#sidebarToggle i.fa");

//    $("#sidebarToggle").on("click", function () {

//        $sidebar.toggleClass("hide-sidebar");

//        if ($sidebar.hasClass("hide-sidebar")) {
//            $sidebar.hide();
//            $(this).css('margin-left','5px');
//        }
//        else {
//            $sidebar.show()
//            //$(this).css('margin-left', '310px');
//        }
//        //else {
//        //    $icon.removeClass("fa-angle-right");
//        //    $icon.addClass("fa-angle-left");
//        //}
//    });
//}());

(function MenuHidden() {


        var mouseY = 0;
        var navbarHeight = $('#main_menu').outerHeight();

        document.addEventListener('mousemove', function(e) {
            mouseY = e.clientY || e.pageY;
            if(mouseY < navbarHeight) {
                $('#main_menu').show();
            }
        }, false);

        $('.navbar').mouseout(function() {
            if($(window).scrollTop() > navbarHeight) {
                $('#main_menu').hide();
            }
        });

      
}());
