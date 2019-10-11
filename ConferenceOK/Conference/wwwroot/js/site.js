// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var countDownDate = new Date("October 12, 2019").getTime();


var x = setInterval(function () {

    var now = new Date().getTime();

   
    var distance = countDownDate - now;

    var days = Math.floor(distance / (1000 * 60 * 60 * 24));
    var hours = Math.floor(distance / (1000 * 60 * 60));
    var minutes = Math.floor(distance / (1000 * 60 ));
    var seconds = Math.floor(distance / (1000));
    
    document.getElementById("demo").innerHTML = days + " Days OR "+hours+" Hours OR "+minutes+" Minute OR " +seconds+" Seconds To The EVENT";

   
    if (distance < 0) {
        clearInterval(x);
        document.getElementById("demo").innerHTML = "EXPIRED";
    }
}, 1000);

