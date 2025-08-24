# API de Livraria Online

Uma API RESTful simples para gerenciar uma coleção de livros. Desenvolvida como projeto para o curso de programação, a API permite realizar operações CRUD (Criar, Ler, Atualizar e Excluir) em um catálogo de livros.

## 🚀 Tecnologias Utilizadas

Este projeto foi construído com as seguintes tecnologias:

* **ASP.NET Core:** Framework web para construir APIs de alta performance.
* **C#:** Linguagem de programação robusta e orientada a objetos.

## ✨ Funcionalidades

A API oferece os seguintes endpoints para manipulação dos dados dos livros:

### Livros

* `GET /api/livros`: Retorna a lista completa de todos os livros.
* `GET /api/livros/{id}`: Retorna os detalhes de um livro específico, identificado pelo seu ID.
* `POST /api/livros`: Cria um novo livro.
* `PUT /api/livros/{id}`: Atualiza as informações de um livro existente.
* `DELETE /api/livros/{id}`: Exclui um livro do catálogo.

## 📦 Estrutura do Projeto

A arquitetura do projeto segue um padrão organizado, separando as responsabilidades em diferentes pastas:

* **`Controllers`**: Contém a lógica de roteamento e tratamento das requisições HTTP (`LivrosController.cs`).
* **`Models`**: Define a estrutura de dados para o objeto `Livro`.


## ▶️ Como Rodar a API

Para executar o projeto em sua máquina local, siga os passos abaixo:

1.  Clone este repositório para a sua máquina.
    `git clone <URL_DO_SEU_REPOSITORIO>`
2.  Abra o projeto no Visual Studio.
3.  Configure o perfil de inicialização para `https` ou `http`.
4.  Pressione `F5` ou o botão `Run` para iniciar a aplicação.

A API será executada em `https://localhost:PORTA`, e você poderá testar os endpoints usando ferramentas como [Postman](https://www.postman.com/) ou a interface [Swagger](https://swagger.io/) que o próprio ASP.NET Core gera.

## 📝 Documentação da API (Swagger)

A API possui uma documentação interativa integrada, acessível em:
`https://localhost:PORTA/swagger/index.html`

Nela, você pode ver todos os endpoints disponíveis e testá-los diretamente no navegador.
