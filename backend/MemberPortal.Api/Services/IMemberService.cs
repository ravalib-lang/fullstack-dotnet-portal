using MemberPortal.Api.Models;

namespace MemberPortal.Api.Services;

public interface IMemberService
{
    Task<Member?> GetMemberByIdAsync(int id);
}
