const user = {
  name: "John Doe",
  level: "admin",
  email: "john.doe@example.com",
};

// Old Method
// const name = user.name;
// const level = user.level;
// const email = user.email;

// New Method
const { name, level, email } = user;
console.log(user); // { name: 'John Doe', level: 'admin', email: 'john.doe@example.com' }
// Using Array Destructuring
const colors = ["red", "green", "blue"];
const [firstColor, secondColor, thirdColor] = colors;
console.log(firstColor); // "red"
console.log(secondColor); // "green"
console.log(thirdColor); // "blue"
