using Microsoft.AspNetCore.Mvc;
using survey_model.Models;
public class survey:Controller{
    [HttpGet("")]
    public IActionResult index(){

        return View("index");
    }

    [HttpPost("result")]
    public IActionResult result(info userInfo){


        if(ModelState.IsValid){
        return View("result",userInfo);
        }

        return index();
    }
}

