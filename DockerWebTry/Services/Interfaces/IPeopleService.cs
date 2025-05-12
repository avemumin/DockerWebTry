using DockerWebTry.Entity;

namespace DockerWebTry.Services.Interfaces;

public interface IPeopleService
{
  Task<IEnumerable<People>> GetAsync();
  Task<People> GetByIdAsync(int id);
}
