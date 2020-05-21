let randomNumber = Math.floor(Math.random() * 100) + 1; //gets a random number

const guesses = document.querySelector('.guesses');//select any element that has the class "quesses"
const lastResult = document.querySelector('.lastResult');//select any element that class the class "lastResult"
const lowOrHi = document.querySelector('.lowOrHi');//select any element that has the class "lowOrHi"

const guessSubmit = document.querySelector('.guessSubmit');//select any element that has the class "guessSubmit"
const guessField = document.querySelector('.guessField');//select any element that has the class "guessField"

let guessCount = 1;// how many guesses they've made.
let resetButton;//variable for the reset button.

guessSubmit.addEventListener('click', checkGuess);

function checkGuess() {
    let userGuess = Number(guessField.value);//gets the number unputted by the user
    if (guessCount === 1) {
      guesses.textContent = 'Previous guesses: ';// add text to the <p> of class guesses
    }
    guesses.textContent += userGuess + ' ';//add the number to the textcontent of the <p> of class guesses
   
    if (userGuess === randomNumber) {
      lastResult.textContent = 'Congratulations! You got it right!';//add text the <p>
      lastResult.style.backgroundColor = 'green';//change background color to green
      lowOrHi.textContent = '';//add a space to the text of this <p>
      setGameOver();
    } else if (guessCount === 10) {//check if teh user is out of guesses.
      lastResult.textContent = '!!!GAME OVER!!!';//change text to indicate the game is over.
      setGameOver();//call the game over function
    } else {
      lastResult.textContent = 'Wrong!';//tell the user that thdy were wrong
      lastResult.style.backgroundColor = 'red';//change the background color
      if(userGuess < randomNumber) {//check if the users guess was too low
        lowOrHi.textContent = 'Last guess was too low!';//tell them
      } else if(userGuess > randomNumber) {//check if the users guess wa too high
        lowOrHi.textContent = 'Last guess was too high!';//tell them
      }
    }
   
    guessCount++;//increment the users turn
    guessField.value = '';//make the guess value empty
    guessField.focus();//change the focus to the guessfield.
  }

  function setGameOver() {
    guessField.disabled = true; //makes you unable to select a field
    guessSubmit.disabled = true;// you can't click the 
    resetButton = document.createElement('button');
    resetButton.textContent = 'Start new game';
    document.body.append(resetButton);
    resetButton.addEventListener('click', resetGame);
  }

  function resetGame() {
    guessCount = 1;
  
    const resetParas = document.querySelectorAll('.resultParas p');
    for (let i = 0 ; i < resetParas.length ; i++) {
      resetParas[i].textContent = '';
    }
  
    resetButton.parentNode.removeChild(resetButton);
  
    guessField.disabled = false;
    guessSubmit.disabled = false;
    guessField.value = '';
    guessField.focus();
  
    lastResult.style.backgroundColor = 'white';
  
    randomNumber = Math.floor(Math.random() * 100) + 1;
  }

  // 1. a) add validation to the number input so that only numbers 1-100 are allowed
//    b) add a text warning field saying "That was not a valid number" to tell the user that their input was invalid. Do not increment the turn.
//    c) on input of the next valid number, remove the text warning field.
// 2. add code to make it possible for a number to be entered by pressing 'enter' on the keyboard instead of having to click the submit button.
// 3. On successful game completion, change the element with "Number Guessing Game" to "You guessed it!". 
// 4. On starting a new game, change the "You guessed it!" back to "Number Guessing Game".