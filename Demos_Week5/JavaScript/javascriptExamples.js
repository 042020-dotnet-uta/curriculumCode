"use strict"
let user = {user:'jerry', age:65};

console.log(user.age);

const fred = 25;
let freddy = 26
console.log(fred);
console.log(freddy);

//fred = 35;
console.log(fred);
freddy = "start";
console.log(freddy);

let str1 = "there";
let str2 = "tiger"
console.log(`Hey ${str1} ${str2}`);

let x;
console.log(x);
 //let john = User();
 let user1 = {
     name:"John",
     age:30
 };

 console.log(user1.name);

 console.log(user1);
 console.log(typeof(str1));

let id = Symbol("id");
let q = Symbol("id");

console.log(str1+ ' ' +str2);
console.log("hello"+ ' ' + 4);

let four = 4;
let five = 5;
let sum = four + five++;
console.log(sum);
sum = four + ++five;
console.log(sum);

let diff = four-five--;
console.log(diff);
diff = four-five;
console.log(diff);
diff = four- --five;
console.log(diff);

four += 5;
console.log(four);

if(42)
{
    console.log("it's " + Date.now() + " and true");
}else{
    console.log("it's falsy");
}

console.log(Math.ceil(Math.random()*100));

let four1 = 4;
function shadowFour(four1){
    console.log(`The value of four outside the function is ${four1}`);
    var four1 = 5;
    console.log(`The value of four shadowed inside the function is ${four1}`);
    //return console.log("early");
}

shadowFour(four1);
console.log(`The value of four outside the function is ${four1}`);

let sayHi = function(var1, var2){
    if(var2 === undefined){
        console.log(`The only variable is ${var1}.`);
    }else{
    console.log(`I'm a ${var1} function expression, ${var2}`);
    }
}

sayHi("dang");
let sayBye = sayHi;
sayBye("darn", "yee-haw");

let sun = (var1, var2) => console.log(`The sun is made of ${var1} and ${var2}.`);

sun("hydrogen","helium");
sun("hydrogen");

let func1 = function(var1, var2){
    console.log(`Var1 is ${var1}.`);
    var2("h2", "O");
}

func1(5, sun);

let func2 = function(var1, var2)
{
    console.log(`I' the outer function = ${var1}!`);
    var2();
}

func2("I'm a teapot", () => {
    console.log("this is the $ function")
});

(function () 
{
    console.log("I am immediately invoked!!"); 
})();

var name = (function () 
{
    console.log("I have a pen!")
    return "I have a pencil";
})();
 console.log(name);


 function sayHiBye(fname, lname){
    function getFullName(){
        return fname + " " + lname;
    }
    console.log("Hello " + getFullName());
}

sayHiBye("Mark", "Moore");

function makeAdder(x){
    return function(y){
        return x+y;
    };
}

var add5 = makeAdder(5);
var add10 = makeAdder(10);

console.log(add5(2));
console.log(add10(100));

let myName = "Mark";
let six = 6;

console.log(String(six));
console.log(Number(myName));
console.log(Number(5>10));
console.log(Number(null));
console.log(Boolean(null));
console.log(Boolean(0));
console.log(Boolean(""));
console.log(Boolean("25"));
alert("I'm stuck!");
prompt("prompt", 3);



