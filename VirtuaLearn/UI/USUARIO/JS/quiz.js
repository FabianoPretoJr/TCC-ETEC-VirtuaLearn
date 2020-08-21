$(document).ready(function(){
  var checkmark = "<span class='checkmark'>&#x2713;</span>";
  
  $(".answer").click(function() {
    $(this).siblings(".answer").removeClass("active").children("span").remove();
    $(this).addClass("active").append(checkmark);
  });
  
  $("button").click(function() {
    if($(".active").length) {
      if($(".active").index() === 1) {
        alert("Well done!");
      } else {
        alert("Wrong answer!");
      }
    } else {
      alert("Por favor, selecione uma alternativa!");
    }
  });
});