using ApiLivraria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLivraria.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LivrosController : ControllerBase
{
    private static List<Livro> livros = new List<Livro>
    {
        new Livro {Id = 1, Titulo = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", Genero = "Fantasia", Preco = 59.90m, Estoque = 10 },
        new Livro {Id = 2, Titulo = "Harry Potter e a Pedra Filosofal", Autor = "J.K. Rowling", Genero = "Fantasia", Preco = 39.90m, Estoque = 15 },
        new Livro {Id = 3, Titulo = "O Problema dos Três Corpos", Autor = "Liu Cixin", Genero = "Ficção Científica", Preco = 49.90m, Estoque = 8 }

    };

    [HttpGet]
    public ActionResult<IEnumerable<Livro>> Get()
    {
        return Ok(livros);
    }

    [HttpGet("{id}")]
    public ActionResult<Livro> Get(int id)
    {
        var livro = livros.FirstOrDefault(l => l.Id == id);
        if (livro == null)
        {
            return NotFound("ID não encontrado");
        }
        return Ok(livro);
    }

    [HttpPut("{id}")]
    public IActionResult PutLivro(int id, [FromBody] Livro livroAtualizado)
    {
        if (id != livroAtualizado.Id)
        {
            return BadRequest("ID do livro não corresponde ao ID da URL.");
        }

        var livroExistente = livros.FirstOrDefault(l => l.Id == id);
        if (livroExistente == null)
        {
            return NotFound("ID não encontrado");
        }

        livroExistente.Titulo = livroAtualizado.Titulo;
        livroExistente.Autor = livroAtualizado.Autor;
        livroExistente.Genero = livroAtualizado.Genero;
        livroExistente.Preco = livroAtualizado.Preco;
        livroExistente.Estoque = livroAtualizado.Estoque;

        return NoContent();

    }
}
