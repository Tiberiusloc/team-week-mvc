using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ForageMvc.Models;
using System.Threading.Tasks;
using ForageMvc.ViewModels;

namespace ForageMvc.Controllers
{
  public class UsersController : Controller
  {
    private readonly ForageMvcContext _db;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;


    public UsersController (UserManager<User> userManager, SignInManager<User> signInManager, ForageMvcContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager;
      _db = db;
    }

    public ActionResult Index()
    {
      return View();
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Register (RegisterViewModel model)
    {
      var user = new User { UserName = model.Email };
      IdentityResult result = await _userManager.CreateAsync(user, model.Password);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    public ActionResult Login()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Login(LoginViewModel model)
    {
      Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
      if (result.Succeeded)
      {
        return RedirectToAction("Index");
      }
      else
      {
        return View();
      }
    }

    [HttpPost]
    public async Task<ActionResult> LogOff()
    {
      await _signInManager.SignOutAsync();
      return RedirectToAction("Index");
    }
  }
}

//Integrating Score Further Expl


// private async Task LoadAsync(User user)
// {
//     var userName = await _userManager.GetUserNameAsync(user);
//     var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

//     Username = userName;

//     Input = new InputModel
//     {
//         PhoneNumber = phoneNumber,

//         Instagram=user.Instagram,

//         Location = user.Location
//     };
// }
// public async Task<IActionResult> OnPostAsync(int modelScore)
// {
//     var user = await _userManager.GetUserAsync(User);
    // if (user == null)
    // {
    //     return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
    // }

    // if (!ModelState.IsValid)
    // {
    //     await LoadAsync(user);
    //     return Page();
    // }

    // var Score = await _userManager.GetScoreAsync(user);

    // if (Input.PhoneNumber != phoneNumber)
    // {
    //     var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
    //     if (!setPhoneResult.Succeeded)
    //     {
    //         var userId = await _userManager.GetUserIdAsync(user);
    //         throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
    //     }
    // }
    // if (Input.Instagram != user.Instagram)
    // {
    //     user.Instagram = Input.Instagram;
    // }

    // if (Input.Location != user.Location)
    // {
    //     user.Location = Input.Location;
    // }
//     if (modelScore > 0)
//     {
//       user.Score += modelScore;
//     }

//     await _userManager.UpdateAsync(user);
//     await _signInManager.RefreshSignInAsync(user);
//     // StatusMessage = "Your profile has been updated";
//     return RedirectToAction("Details");
// }