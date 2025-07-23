function BotaoAlerta() {
  // 1. Esta é a nossa função "manipuladora de evento"
  function manipularClique() {
    alert("Você clicou no botão!");
  }

  // 2. Nós passamos a função para a prop onClick do botão
  return <button onClick={manipularClique}>Clique em mim!</button>;
}

export default BotaoAlerta;
