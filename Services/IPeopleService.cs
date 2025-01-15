using backend_hector.Controllers;

namespace backend_hector.Services
{
    public interface IPeopleService
    {
        bool Validate(People people);
    }
}
