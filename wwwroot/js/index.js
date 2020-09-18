$(document).ready(function (){
    console.log("Hello pluralsight!")

    //var theForm = document.getElementById("theForm");
    // $ alias of the jQuery
    var theForm = $("#theForm");
    //theForm.hidden = true;
    theForm.hide();

    //var button = document.getElementById("buyButton");
    var button = $("#buyButton");

    //passing anonimous function
    //button.addEventListener("click", function () {
    //    console.log("Buying item")
    //});
    button.on("click", function () {
        console.log("Buying item")
    });

    //var productInfo = document.getElementsByClassName(".product-props");
    var productInfo = $(".product-props li");
    //var listItems = productInfo.item[0].children;
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });

    //jQuery objects
    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        // show if hidden and vice versa. 1000 msec is toggle time 
        $popupForm.fadeToggle(1000);
    });
});