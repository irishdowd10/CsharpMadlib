using Nancy;
using CsharpMadlib.Objects;

namespace CsharpMadlib
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
       Get["/story"] = _ => {
        WordVariables myWordVariables = new WordVariables();
        myWordVariables.SetName(Request.Query["name"]);
        myWordVariables.SetPlace(Request.Query["place"]);
        myWordVariables.SetAction(Request.Query["action"]);
        myWordVariables.SetAdjective(Request.Query["adjective"]);
        myWordVariables.SetAge(Request.Query["age"]);
        return View["story.cshtml", myWordVariables];
      };
      Get["/"] = _ => {
        return View["form.cshtml"];
      };
    }
  }
}
