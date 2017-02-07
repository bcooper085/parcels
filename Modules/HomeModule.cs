using Nancy;
using Parcel.Objects;

namespace Parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/parcel_calc"] = _ => {
        ParcelVariables newCalc = new ParcelVariables();
        newCalc.SetLength(Request.Query["length"]);
        newCalc.SetWidth(Request.Query["width"]);
        newCalc.SetHeight(Request.Query["height"]);
        newCalc.SetWeight(Request.Query["weight"]);
        return View["checkout.cshtml", newCalc];
      };
    }
  }
}
