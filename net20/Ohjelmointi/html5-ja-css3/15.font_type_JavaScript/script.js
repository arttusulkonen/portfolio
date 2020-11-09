var clicks = 0;
function change_font_type() {
  clicks += 1;
    if(clicks == 1){
      document.getElementById("section").style.fontFamily = "Roboto";
    } else if(clicks == 2){
      document.getElementById("section").style.fontFamily = "Mansalva";
    } else if(clicks == 3){
      document.getElementById("section").style.fontFamily = "Grenze";
    } else if(clicks == 4){
      document.getElementById("section").style.fontFamily = "Turret Road";
    } else if(clicks == 5){
      document.getElementById("section").style.fontFamily = "Courier New";
    } else {
      clicks = 0;
    }
}

