"use strict";
//console.log("Welcome to TypeScrpt!");
function randomNum() {
    return Math.floor(Math.random() * 3);
}
function assignChoiceWord(p) {
    if (p.choice == 0) {
        p.choiceWord = "ROCK";
    }
    if (p.choice == 1) {
        p.choiceWord = "PAPER";
    }
    if (p.choice == 2) {
        p.choiceWord = "SCISSORS";
    }
    return p;
}
function decideWinner(p1, p2) {
    //check if is a tie
    if (p1.choiceWord == p2.choiceWord) {
        return p1.Name + "'s " + p1.choiceWord + " ties " + p2.Name + "'s " + p2.choiceWord;
    }
    else {
        //check all p1 choices to see if p1 wins.
        switch (p1.choiceWord) {
            case "ROCK":
                if (p2.choiceWord == "SCISSORS") {
                    return p1.Name + "'s " + p1.choiceWord + " beats " + p2.Name + "'s " + p2.choiceWord;
                }
                break;
            case "PAPER":
                if (p2.choiceWord == "ROCK") {
                    return p1.Name + "'s " + p1.choiceWord + " beats " + p2.Name + "'s " + p2.choiceWord;
                }
                break;
            case "SCISSORS":
                if (p2.choiceWord == "PAPER") {
                    return p1.Name + "'s " + p1.choiceWord + " beats " + p2.Name + "'s " + p2.choiceWord;
                }
                break;
            default:
                return "Something happened...";
        }
    }
    return p2.Name + "'s " + p2.choiceWord + " beats " + p1.Name + "'s " + p1.choiceWord;
}
var p1 = {
    Name: "Slippin Jimmy",
    choice: 0,
    choiceWord: "null"
};
var p2 = {
    Name: "Gus Fring",
    choice: 0,
    choiceWord: "null"
};
//get a randone number between 0, 1, or 2
p1.choice = randomNum();
p2.choice = randomNum();
// assign the corresponding word for the random number.
p1 = assignChoiceWord(p1);
p2 = assignChoiceWord(p2);
// 0 = rock
// 1 = paper
// 2 = scissors
var UltimateChampion = decideWinner(p1, p2);
console.log(UltimateChampion);
