import { useState } from "react";
import "./App.css";

function App() {
  const [contador, setContador] = useState(0);
  function incrementar() {
    setContador(contador + 1);
  }
  function decrementar() {
    setContador(contador - 1);
  }
  return (
    <div>
      <h1>Numero de clicks {contador}</h1>
      <button onClick={decrementar}>-</button>
      <button onClick={incrementar}>+</button>
    </div>
  );
}

export default App;
