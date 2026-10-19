using MemberPortal.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace MemberPortal.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    private readonly IMemberService _memberService;

    public MembersController(IMemberService memberService)
    {
        _memberService = memberService;
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetMemberById(int id)
    {
        var member = await _memberService.GetMemberByIdAsync(id);

        if (member is null)
        {
            return NotFound();
        }

        return Ok(member);
    }
}
