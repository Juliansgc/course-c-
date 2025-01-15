using backend_hector.DTOs;

namespace backend_hector.Services
{
    public interface IPostsService
    {
        public Task<IEnumerable<PostDTO>> Get();
    }
}
