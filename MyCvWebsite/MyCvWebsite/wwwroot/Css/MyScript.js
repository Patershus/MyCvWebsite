

$(document).ready(function () {
    $("#serviceBild").mouseenter(
        function () {
            $(this).animate({ transform: "scale(1,1)" });
            //$(this).height('200px');


        });
    $("#serviceBild").mouseleave(
        function () {
            $(this).animate({ transform: "scale(1)" });
            //$(this).height('175px');
        });

   });

 function LoggedIn(){$("#loginButton").remove()}
