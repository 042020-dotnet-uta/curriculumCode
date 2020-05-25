'use strict';
const guesses = document.querySelector('.guesses');           //  Declares a constant and initilizes it as a document that is inserted 
const lastResult = document.querySelector('.lastResult');    //   where that class is called in the html.
const lowOrHi = document.querySelector('.lowOrHi');         //  
const guessSubmit = document.querySelector('.guessSubmit');//   
const guessField = document.querySelector('.guessField'); //     
const title = document.querySelector('.title');          //

guessField.addEventListener('keyup', function(e){ // Will trigger the 'checkGuess' function 
    if (e.keyCode === 13) {                      //  when the "Enter" button is pressed in the guess input field.
    checkGuess();                               // Keycode 13 is the "Enter" key.
  }                                            // https://teamtreehouse.com/community/how-to-add-enter-event-listener-aside-from-clicking-the-button
});

guessSubmit.addEventListener('click', checkGuess); // will trigger the 'checkGuess' function when the Submit button is 'click'ed

let randomNumber = Math.floor(Math.random()*100) +1; // creates a random number integer between 1 & 100

let guessCount = 1; //how many tries the user had.

function checkGuess(){ // checks the guess 
    let userGuess = Number(guessField.value); //get the number
    
    if(isNaN(userGuess)){ // isNaN checks to see if userGuess is "Not a Number"  https://www.w3schools.com/jsref/jsref_isnan.asp
        lastResult.textContent = "That was not a valid number";
        lowOrHi.textContent = ''; // erases last low or hi message
    }
    else {
        if(guessCount === 1){ // first guess
            guesses.textContent = 'Previous Guesses: '; // starts previous guess list
        }
        
        guesses.textContent += ' ' + userGuess; // adds a space between guesses

        if(userGuess === randomNumber){ // correct guess
            title.textContent = 'You guessed it!'; // changes the first heading on win
            lastResult.textContent = 'Congratulations! You win!';
            lastResult.style.color = 'green' // changes font color of win message
            lowOrHi.textContent = ''; // erases last low or hi message
            setGameOver() //ends game and creates reset button
        }
        else if(guessCount === 10){ // last guess
            lastResult.textContent = 'GAME OVER';
            setGameOver() //ends game and creates reset button
        }
        else{ // all wrong answers 
            lastResult.textContent = 'Wrong answer.';
            lastResult.style.color = 'red' // changes font color for Wrong message

            if(userGuess < randomNumber){ // userGuess is lower than the random number
                lowOrHi.textContent = 'That guess was too low';
            } 
            else if(userGuess > randomNumber){ // userGuess is lower than the random number
                lowOrHi.textContent = 'That guess was too high';
            }
        }
            guessCount++; //increment the number of turns taken
            guessField.value = ''; //empties the text box of the user's guess.
    }
}

function setGameOver() { // ends game and creates reset button
    guessField.disabled = true; // disables the input fields to sop further guesses
    guessSubmit.disabled = true; // disables the input fields to sop further guesses
    resetButton = document.createElement('button'); // creates reset button
    resetButton.textContent = 'Start new game'; // sets the label on the button
    document.body.append(resetButton); // adds button to the end of the document body
    resetButton.addEventListener('click', resetGame); // will trigger the 'resetGame' function when the reset button is 'click'ed
}

function resetGame() { // resets all the fields of the document back to their initial values, and generates a new random number
    guessCount = 1; // resets to first guess
  
    title.textContent = 'Number Guessing Game'; // resets the first heading after win message

    const resetParas = document.querySelectorAll('.resultParas p'); // selects all the paragraphs inside the 'resultParas' div
    for (let i = 0 ; i < resetParas.length ; i++) { // loops through all the paragraphs in the div
      resetParas[i].textContent = ''; // erases all the messages
    }
  
    resetButton.parentNode.removeChild(resetButton); // removes the reset button
  
    guessField.disabled = false; // reenables the input fields
    guessSubmit.disabled = false; // reenables the input fields
    guessField.value = ''; // clears the input field
    guessField.focus(); // moves the cursor into the input field
    
    randomNumber = Math.floor(Math.random() * 100) + 1; // creates new random number
}