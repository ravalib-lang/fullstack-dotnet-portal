using MemberPortal.Api.Models;

namespace MemberPortal.Api.Repositories;

public interface IMemberRepository
{
    Task<Member?> GetByIdAsync(int id);
}
