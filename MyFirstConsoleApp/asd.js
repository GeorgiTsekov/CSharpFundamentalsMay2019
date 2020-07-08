// function solve(stepsNumber, footprintLength, speedOfStudent){
//     let rest = Math.floor(stepsNumber / 500);
//     //s = v * t
//     //2400 = 5 * 5 / 18 * t
//     // t = 1728 s + 60 * 8 = 2208s.


// }

//solve(4000, 0.60, 5);

// function solve(num){
//     let arrayOfNumbers = String(num).split("");
//     let isSame = true;
//     let firstElement = arrayOfNumbers[0];

//     arrayOfNumbers.forEach(function (element){
//         if(element != firstElement){
//             isSame = false;
//         }
//     });

//     let sum = arrayOfNumbers
//     .map(Number)
//     .reduce((acc, cur) => acc + cur);

//     console.log(isSame);
//     console.log(sum);
// }

// solve(2222222);

// function solve(array){
//     let obj = {};

//     for (let index = 0; index < array.length; index+=2) {
//         let element = array[index];
//         let value = Number(array[index + 1]);

//         obj[element] = value;
//     }

//     console.log(obj);
// }

// let test0 = ['Yoghurt', 48, 'Rise', 138, 'Apple', 52];
// let test1 = ['Potato', 93, 'Skyr', 63, 'Cucumber', 18, 'Milk', 42];

// solve(test0);

function solve(array){
    let number = Number(array.shift());

    let operations = {
        chop: (x) => { return (x / 2) },
        dice: (x) => { return (Math.sqrt(x)) },
        spice: (x) => { return ++x },
        bake: (x) => { return (x * 3) },
        fillet: (x) => { return (x * 0.8) }
    }

    for (let index = 0; index < array.length; index++) {
        number = operations[array[index]](number);
        console.log(number);
    }
}

let test0 = ['32', 'chop', 'chop', 'chop', 'chop', 'chop'];
let test1 = ['9', 'dice', 'spice', 'chop', 'bake', 'fillet'];
solve(test1);