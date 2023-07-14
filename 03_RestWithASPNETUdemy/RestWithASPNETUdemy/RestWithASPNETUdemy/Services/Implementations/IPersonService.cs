using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);

        Person Update(Person person);
        List<Person> FindAll();

        void Delete(long id);

    }
}
