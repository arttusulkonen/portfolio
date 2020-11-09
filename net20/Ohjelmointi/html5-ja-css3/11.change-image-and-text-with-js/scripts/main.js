var myImage = document.querySelector('img');
var myHeading = document.querySelector('h1');


var myButton = document.querySelector('button');
var myHeading = document.querySelector('h1');
function setUserName() {
    var myName = prompt('Please enter your name.');
    localStorage.setItem('name', myName);
    myHeading.textContent = 'Mozilla is cool, ' + myName;
}
function setUserName() {
    var myName = prompt('Please enter your name.');
    localStorage.setItem('name', myName);
    myHeading.textContent = 'Mozilla is cool, ' + myName;
}
myButton.onclick = function() {
    setUserName();
}

myImage.onclick = function() {
    var mySrc = myImage.getAttribute('src');
    if(mySrc === 'img/firefox-icon.png') {
        myHeading.textContent = 'Is Brave even Cooler?';
        myImage.setAttribute ('src','img/brave.png');
        document.body.style.backgroundColor = 'white';
    } else {
      myImage.setAttribute ('src','img/firefox-icon.png');
      myHeading.textContent = 'Mozilla is cool';
      document.body.style.backgroundColor = '#FF9500';
    }
}
