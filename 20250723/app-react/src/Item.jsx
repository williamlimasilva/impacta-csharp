function Item({ nome, comprado }) {
  let conteudo = nome; //Se não foi comprado, exibe apenas o nome
  if (comprado) {
    conteudo = <del>{nome + " ✔"}</del>;
  }
  return <li>{conteudo}</li>;
}
export default Item;
