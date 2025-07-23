//URL base para as imgs do TMDB
const IMAGEM_URL_BASE = "https://image.tmdb.org/t/p/w500";

export default function FilmeCard({ filme }) {
  return (
    <div style={{ width: "200px", margin: "10px", textAlign: "center" }}>
      <img
        src={IMAGEM_URL_BASE + filme.poster_path}
        alt={"Pôster de " + filme.title}
        width="200"
      />
      <h4 style={{ marginTop: "5px" }}>{filme.title}</h4>
    </div>
  );
}
