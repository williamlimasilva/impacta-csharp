function somarTradicional(a, b) {
  return a + b;
}

function somarComSeta(a, b) {
  return (a, b) => a + b;
}

function somarSimplificado(a, b) {
  return a + b;
}

console.log(somarTradicional(5, 3)); // Saída: 8
console.log(somarComSeta(5, 3)); // Saída: 8
console.log(somarSimplificado(5, 3)); // Saída: 8
