import { useEffect, useState } from "react";
import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";
import "./App.css";
import FilmeCard from "./FilmeCard";

const API_KEY = "14fe53f590671a429b93d04a5a8e8dd5";
const API_URL_POPULARES = `https://api.themoviedb.org/3/movie/popular?api_key=${API_KEY}&language=pt-BR&page=1`;
function App() {
  const [filmes, setFilmes] = useState([]);

  useEffect(() => {
    async function fetchFilmes() {
      try {
        const response = await fetch(API_URL_POPULARES);
        const data = await response.json();
        setFilmes(data.results);
      } catch (error) {
        console.error("Erro ao buscar filmes:", error);
      }
    }
    fetchFilmes();
  }, []);

  return (
    <div>
      <h1>Buscador de Filmes</h1>
      <div
        style={{ display: "flex", flexWrap: "wrap", justifyContent: "center" }}
      >
        {filmes.map((filme) => (
          <FilmeCard key={filme.id} filme={filme} />
        ))}
      </div>
    </div>
  );
}

export default App;
