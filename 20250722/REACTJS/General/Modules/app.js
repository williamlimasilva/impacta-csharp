import { sum } from "./math.js";
import { subtract } from "./math.js"; // This will cause an error since subtract is not exported

const result = sum(5, 10);
console.log(result); // 15

const resultSubtract = subtract(10, 5); // This will cause an error since subtract is not exported
console.log(resultSubtract); // This line will not execute due to the error
