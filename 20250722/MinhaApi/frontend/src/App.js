import logo from "./logo.svg";
import "./App.css";
import { use, useEffect, useState } from "react";
import axios from "axios";
import ProdutoCard from "./components/produtoCard"; // Importando o componente ProdutoCard

function App() {
  const [produtos, setProdutos] = useState([]);
  const [status, setStatus] = useState("loading...");
  useEffect(() => {
    const apiUrl = "https://localhost:7114/api/Produtos";
    async function buscarProdutos() {
      try {
        const response = await axios.get(apiUrl);
        setProdutos(response.data);
        setStatus("Produtos carregados com sucesso!");
      } catch (error) {
        console.error("Erro ao buscar produtos:", error);
        if (error.code === "ERR_NETWORK") {
          setStatus("Erro de rede. Verifique sua conexão.");
        } else if (error.code === "ERR_BAD_REQUEST") {
          setStatus("Requisição inválida. Verifique a URL.");
        } else if (error.code === "ERR_BAD_RESPONSE") {
          setStatus("Resposta inválida do servidor.");
        } else if (error.code === "ERR_TIMEOUT") {
          setStatus("Tempo limite excedido. Tente novamente mais tarde.");
        } else if (error.code === "ERR_CANCELED") {
          setStatus("Requisição cancelada.");
        } else if (error.code === "ERR_NETWORK") {
          setStatus("Erro de rede. Verifique sua conexão.");
        } else {
          setStatus("Erro ao carregar produtos.");
        }
      }
    }
    buscarProdutos();
  }, []);

  return (
    <div className="app-container">
      <h1>Catálogo de Produtos</h1>

      {/* Exibe a mensagem de status se houver uma */}
      {status && <p className="status-message">{status}</p>}

      <div className="produtos-grid">
        {/* 2. Mapeia a lista de produtos para renderizar um card para cada um */}
        {produtos.map((produto) => (
          <ProdutoCard key={produto.id} produto={produto} />
        ))}
      </div>
    </div>
  );
}

export default App;
