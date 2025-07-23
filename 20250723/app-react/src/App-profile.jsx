import "./App.css";
import Profile from "./Profile";

function App() {
  const cientistas = [
    {
      nome: "Maria Skłodowska-Curie",
      imagemURL: "https://i.imgur.com/szV5sdG.jpg",
    },
    {
      nome: "Katsuko Saruhashi",
      imagemURL: "https://i.imgur.com/YfeOqp2.jpg",
    },
  ];
  return (
    <div>
      <h1>Mulheres na Ciência</h1>
      {cientistas.map((cientista, index) => (
        <Profile
          key={index}
          nome={cientista.nome}
          imagemURL={cientista.imagemURL}
        />
      ))}
    </div>
  );
}

export default App;
