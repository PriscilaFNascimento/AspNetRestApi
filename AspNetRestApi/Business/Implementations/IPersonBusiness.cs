using System.Collections.Generic;
using AspNetRestApi.Model;
namespace AspNetRestApi.Business.Implementations
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
