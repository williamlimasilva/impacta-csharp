// Dentro de: src/ListaDeTarefas.jsx

import { useState } from "react";

let proximoId = 3;
const tarefasIniciais = [
  { id: 0, titulo: "Aprender React", concluida: true },
  { id: 1, titulo: "Praticar React useState", concluida: true },
  { id: 2, titulo: "Entender Imutabilidade", concluida: false },
];

function ListaDeTarefas() {
  const [tarefas, setTarefas] = useState(tarefasIniciais);
  const [texto, setTexto] = useState("");

  function manipularAdicao() {
    // Adicionando um item de forma IMUTÁVEL
    const novaTarefa = { id: proximoId++, titulo: texto, concluida: false };
    setTarefas([
      ...tarefas, // Copia todas as tarefas antigas
      novaTarefa, // Adiciona a nova tarefa no final
    ]);
    setTexto(""); // Limpa o campo de input
  }

  function manipularRemocao(idDaTarefa) {
    // Removendo um item de forma IMUTÁVEL
    setTarefas(tarefas.filter((t) => t.id !== idDaTarefa));
  }

  return (
    <>
      <h2>Minha Lista de Tarefas</h2>
      <input
        placeholder="Adicionar tarefa"
        value={texto}
        onChange={(e) => setTexto(e.target.value)}
      />
      <button onClick={manipularAdicao}>Adicionar</button>
      <ul>
        {tarefas.map((tarefa) => (
          <li key={tarefa.id}>
            {tarefa.titulo}{" "}
            <button onClick={() => manipularRemocao(tarefa.id)}>Remover</button>
          </li>
        ))}
      </ul>
    </>
  );
}

export default ListaDeTarefas;
