using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    // [Route("/")] /*Route to anything that is referenced (as example the "/journal")*/
    // public ActionResult Index() /*calls the index.cshtmlfile */
    // {
    //   return View();
    // }
    [Route("/")]
    public ActionResult Hello()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Eric");
myLetterVariable.SetSender("John");
return View(myLetterVariable);
    }
  }
}
