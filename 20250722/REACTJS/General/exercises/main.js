// Importing the CONFIG constant and formatarUsuario function from utils.js
import { CONFIG, formatarUsuario } from "./utils.js";

// Using the imported CONFIG constant
console.log(CONFIG);

// Using the imported formatarUsuario function
const usuario = { nome: "Alice", idade: 30 };
console.log(formatarUsuario(usuario));

console.log(`Rodando a versão ${CONFIG.versao} do ${CONFIG.autor}`);
