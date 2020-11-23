var clicks = 0;
function change_font_size() {
  clicks++;
    if(clicks == 1){
      document.getElementById("section").style.fontSize = "20px";
    } else if(clicks == 2){
      document.getElementById("section").style.fontSize = "24px";
    } else if(clicks == 3){
      document.getElementById("section").style.fontSize = "28px";
    } else if(clicks == 4){
      document.getElementById("section").style.fontSize = "32px";
    } else if(clicks == 5){
      document.getElementById("section").style.fontSize = "20px";
    } else {
      clicks = 0;
    }
}


