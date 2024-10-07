using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Validation1.Model;
using Validation1.Validator;

namespace Validation1.Controller;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] CreateUserModel model)
    {

        var validator = new RegistrationValidator();

        var result = validator.Validate(model);

        if (!result.IsValid)
            return BadRequest(result.Errors);

        // logic here
        return Ok("data");
    }
}