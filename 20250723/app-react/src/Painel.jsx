export default function Painel({ titulo, children, isActive, onShow }) {
  return (
    <section style={{ border: "1px solid #ccc", margin: "10px" }}>
      <h3>{titulo}</h3>
      {isActive ? <p>{children}</p> : <button onClick={onShow}>Mostrar</button>}
    </section>
  );
}
