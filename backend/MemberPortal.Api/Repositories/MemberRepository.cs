using MemberPortal.Api.Models;

namespace MemberPortal.Api.Repositories;

public class MemberRepository : IMemberRepository
{
    private static readonly List<Member> Members =
    [
        new Member
        {
            Id = 1,
            FirstName = "John",
            LastName = "Smith",
            DateOfBirth = new DateTime(1988, 4, 12),
            Status = "Active"
        },
        new Member
        {
            Id = 2,
            FirstName = "Priya",
            LastName = "Patel",
            DateOfBirth = new DateTime(1992, 9, 3),
            Status = "Inactive"
        }
    ];

    public Task<Member?> GetByIdAsync(int id)
    {
        var member = Members.FirstOrDefault(member => member.Id == id);

        return Task.FromResult(member);
    }
}
