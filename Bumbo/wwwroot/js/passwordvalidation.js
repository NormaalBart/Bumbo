var myInput = document.getElementById("password-validation");
var capital = document.getElementById("password-capital");
var number = document.getElementById("password-number");
var length = document.getElementById("password-length");

// When the user starts to type something inside the password field
  // Validate capital letters
  var upperCaseLetters = /[A-Z]/g;
  if(myInput.value.match(upperCaseLetters)) {
      capital.classList.remove("password-invalid");
      capital.classList.add("password-valid");
  } else {
      capital.classList.remove("password-valid");
      capital.classList.add("password-invalid");
  }

  // Validate numbers
  var numbers = /[0-9]/g;
  if(myInput.value.match(numbers)) {
      number.classList.remove("password-invalid");
      number.classList.add("password-valid");
  } else {
      number.classList.remove("password-valid");
      number.classList.add("password-invalid");
  }

  // Validate length
  if(myInput.value.length >= 6) {
      length.classList.remove("password-invalid");
      length.classList.add("password-valid");
  } else {
      length.classList.remove("password-valid");
      length.classList.add("password-invalid");
  }
}