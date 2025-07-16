# Objetivo

Criar uma Web API para gerenciar uma biblioteca de livros e seus respectivos autores.

## Requisitos

- A solução deve ser um projeto **ASP.NET Core Web API**.
- Deve haver duas entidades principais: **Author** (Autor) e **Book** (Livro).
- Um **Book** deve estar associado a um **Author**.
- O **Padrão de Repositório** deve ser usado para abstrair o acesso a dados para ambas as entidades.
- Usaremos o **Entity Framework**.
- A API deve ter endpoints separados para gerenciar:
  - Autores: `/api/authors`
  - Livros: `/api/books`
