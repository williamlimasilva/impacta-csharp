// We are exporting a function named sum that another can to use in their code.
export const sum = (a, b) => {
  return a + b;
};

// We can't export a function named subtract, because it is not used in the code.
const subtract = (a, b) => {
  return a - b;
};
