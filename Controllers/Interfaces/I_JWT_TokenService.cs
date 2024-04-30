

using DTU_Bacakend_62597.Models;

namespace backend.Controllers.Interfaces
{
    public interface IJWT_TokenService
    {
        string GenerateJwtToken(User user);
    }
}