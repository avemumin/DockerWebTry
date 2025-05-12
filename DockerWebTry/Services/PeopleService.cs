using DockerWebTry.Entity;
using DockerWebTry.Services.Interfaces;

namespace DockerWebTry.Services;

public class PeopleService : IPeopleService
{
  public async Task<IEnumerable<People>> GetAsync()
  {
    var peoples = Peoples(); ;

    return peoples;
  }

  private List<People> Peoples()
  {
    var people = new List<People>
    {
        new People { Id = 1, Name = "Jan", LastName = "Kowalski" },
        new People { Id = 2, Name = "Anna", LastName = "Nowak" },
        new People { Id = 3, Name = "Piotr", LastName = "Wiśniewski" },
        new People { Id = 4, Name = "Karolina", LastName = "Zielińska" },
        new People { Id = 5, Name = "Mateusz", LastName = "Dąbrowski" }
    };
    return people;
  }
}
