using DockerWebTry.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DockerWebTry.Controllers;

[ApiController]
[Route("api/[controller]")]

public class PeopleController : ControllerBase
{
  private readonly IPeopleService _peopleService;

  public PeopleController(IPeopleService peopleService)
  {
    _peopleService = peopleService;
  }


  [HttpGet]
  public async Task<IActionResult> Get()
  {
    var result = await _peopleService.GetAsync();
    return Ok(result);
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetById([FromRoute]int id)
  {
    var result = await _peopleService.GetByIdAsync(id);
    return Ok(result);
  }
}
