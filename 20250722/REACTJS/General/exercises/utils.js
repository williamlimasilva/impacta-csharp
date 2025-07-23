// Define e exporta um objeto de configuração.
export const CONFIG = {
  versao: "1.0",
  autor: "Meu App",
};

// Define e exporta uma função usando arrow function.
export const formatarUsuario = (usuario) => {
  // Usa desestruturação para pegar as propriedades do objeto usuario
  const { nome, idade } = usuario;
  // Usa template literals (outra feature do JS moderno, as crases ``) para montar a string
  return `Usuário: ${nome}, Idade: ${idade}`;
};
