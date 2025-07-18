using System.Collections.Generic;
using FluentAssertions;
using GerenciadorDeProjetos.Controllers;
using GerenciadorDeProjetos.DTOs;
using GerenciadorDeProjetos.Models;
using GerenciadorDeProjetos.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace GerenciadorDeProjetos.Tests;

public class ProdutosControllerTests
{
    [Fact]
    // Padrão de Nomenclatura: MetodoTestado_Cenario_ComportamentoEsperado
    public async Task ListarTodosProdutos_QuandoExistemProdutos_DeveRetornarOkComListaDeProdutosDto()
    {
        // --- ARRANGE (Organizar) ---
        // Aqui nós preparamos tudo o que o teste precisa: mocks, dados falsos, etc.

        // 1. Criar dados falsos (uma lista de entidades 'Produto')
        var produtosFalsos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Produto A", Preco = 10, CategoriaId = 1 },
            new Produto { Id = 2, Nome = "Produto B", Preco = 20, CategoriaId = 1 }
        };

        // 2. Criar os Mocks das nossas dependências
        var mockProdutoRepo = new Mock<IProdutoRepository>();
        var mockUoW = new Mock<IUnitOfWork>();

        // 3. Configurar o comportamento dos Mocks
        //    "Quando o método GetAllAsync do mockProdutoRepo for chamado,
        //     retorne a nossa lista de produtos falsos."
        mockProdutoRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(produtosFalsos);

        //    "Quando a propriedade ProdutoRepository do mockUoW for acessada,
        //     retorne o nosso mock de repositório de produtos."
        mockUoW.Setup(uow => uow.ProdutoRepository).Returns(mockProdutoRepo.Object);

        // 4. Instanciar o Controller, injetando o nosso Mock do Unit of Work.
        //    O controller vai pensar que está falando com o UoW de verdade, mas está
        //    falando com o nosso objeto falso e controlado.
        var controller = new ProdutosController(mockUoW.Object);

        // --- ACT (Agir) ---
        // Aqui nós executamos a ação que queremos testar.
        var resultado = await controller.ListarTodosProdutos();

        // --- ASSERT (Verificar) ---
        // Aqui nós verificamos se o resultado da ação foi o esperado.

        // 1. O resultado deve ser do tipo 'OkObjectResult' (que corresponde ao status 200 OK)
        resultado.Should().BeOfType<OkObjectResult>();
        var okResult = resultado as OkObjectResult;

        // 2. O valor dentro do resultado não deve ser nulo
        okResult.Value.Should().NotBeNull();

        // 3. O valor deve ser uma coleção de 'ProdutoDto'
        okResult.Value.Should().BeAssignableTo<IEnumerable<ProdutoDto>>();
        var listaDeDtos = okResult.Value as IEnumerable<ProdutoDto>;

        // 4. A lista de DTOs deve ter a mesma quantidade de itens que nossa lista falsa
        listaDeDtos.Should().HaveCount(produtosFalsos.Count);

        // 5. O mapeamento de Entidade para DTO deve estar correto
        listaDeDtos.First().Nome.Should().Be(produtosFalsos.First().Nome);
        listaDeDtos.First().Preco.Should().Be(produtosFalsos.First().Preco);
    }
}
