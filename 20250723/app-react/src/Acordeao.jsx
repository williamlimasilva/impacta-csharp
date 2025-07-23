import { useState } from "react";
import Painel from "./Painel";

export default function Acordeao() {
  const [activeIndex, setActiveIndex] = useState(0);

  return (
    <>
      <h2>Almaty, Cazaquistão</h2>
      <Painel
        titulo="Sobre"
        isActive={activeIndex === 0}
        onShow={() => setActiveIndex(0)}
      >
        Com uma população de cerca de 2 milhões de pessoas, Almaty é a maior
        cidade do Cazaquistão.
      </Painel>

      <Painel
        titulo="Etimologia"
        isActive={activeIndex === 1}
        onShow={() => setActiveIndex(1)}
      >
        O nome vem de <span lang="kk-KZ">алма</span>, a palavra cazaque para
        "maçã", e é frequentemente traduzido como "cheio de maçãs".
      </Painel>
    </>
  );
}
