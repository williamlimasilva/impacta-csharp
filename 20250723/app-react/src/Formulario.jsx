import { useState } from "react";

function Formulario() {
  const [pessoa, setPessoa] = useState({
    nome: "Myrella",
    sobrenome: "Graziela",
    email: "myrellagraziela@email.com",
  });

  function manipulaMudanca(e) {
    setPessoa({
      ...pessoa,
      [e.target.name]: e.target.value,
    });
  }

  return (
    <>
      <label>Nome: </label>
      <input name="nome" value={pessoa.nome} onChange={manipulaMudanca} />

      <label>SobreNome: </label>
      <input
        name="sobrenome"
        value={pessoa.sobrenome}
        onChange={manipulaMudanca}
      />

      <label>Email: </label>
      <input name="email" value={pessoa.email} onChange={manipulaMudanca} />

      <p>
        <b>
          {" "}
          {pessoa.nome} {pessoa.sobrenome}
        </b>{" "}
        {pessoa.email}
      </p>
    </>
  );
}
export default Formulario;
