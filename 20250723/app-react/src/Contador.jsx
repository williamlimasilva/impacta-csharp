import { useState } from "react";

function Contador() {
  const [contador, setContador] = useState(0);
  function manipularClique() {
    setContador(contador + 1);
  }
  return (
    <div>
      <h1>Contador: {contador}</h1>
      <button onClick={manipularClique}>Incrementar</button>
    </div>
  );
}

export default Contador;
