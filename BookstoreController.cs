using BookstoreManager.Requests;
using BookstoreManager.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreManager.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookstoreController : ControllerBase
{

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult PostBook([FromBody] BookRegisterJson request)
    {
        var reponse = new ResponseRegisterBookJson
        {
            Id = 1,
            Title = request.Title
        };

        return Created(string.Empty, reponse);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateBook([FromRoute] int id,[FromBody] BookUpdateBookJson request)
    { 
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult DeleteBook([FromRoute] int id)
    {
        return NoContent(); 
    }

    [HttpGet]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    public IActionResult GetAllBooks()
    {
        var response = new List<Book>
        {
           new Book { Id = 1, Title = "Harry Potter - A Pedra Filosofal", Price = 150, QuantityInStock = 5, Gender = GenderBook.fiction},
           new Book { Id = 2, Title = "Harry Potter - O Cálice de Fogo", Price = 200, QuantityInStock = 20, Gender = GenderBook.fiction}
        };
        return Ok(response);
    }

    

    
}
