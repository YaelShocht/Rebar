using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Rebar.Controllers;

public class MenuController
{
    //readonly MenuDataAccess
    readonly Menu menu;
    public MenuController()
    {
        menu = new Menu();
    }

    //[HttpGet]
    //public async ActionResult<List<ShakeModel>> GetAll()
    //{
    //    var result = menu.ShowMenu();
    //    if (result.Count == 0)
    //    {
    //        return await Task.FromResult(NoContent());
    //    }
    //    return await Task.FromResult(result);
    //}
}
