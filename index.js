/*
This function takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.
Rewrite this function in C# console app and achieve the same outcome.

*/

function exampleJavaScript(arr) {
	let newArr = [];
  for(let i = 0; i < arr.length; i++){
    let largest = arr[i][0];
    for(let j = 0; j < arr[i].length; j++){
      if(arr[i][j] > largest) {
        largest = arr[i][j]
      }
    }
    newArr.push(largest)
  }
  return newArr
}

console.log(exampleJavaScript([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]])) // outcome [7, 90, 2]

// To run this function and check the outcome in JavaScript use VS code to execute the code with:
// node index.js
// Watch out for negative numbers.
