using Microsoft.AspNetCore.Mvc;
using survey_model.Models;
//* renders the survey form
public class survey:Controller{
    [HttpGet("")]
    public IActionResult index(){

        return View("index");
    }
//*validates that the fields match then it takes you to the result page if not it reloads the same page
    [HttpPost("result")]
//! you are passing every information that you have on your Model
    public IActionResult result(info userInfo){


        if(ModelState.IsValid){
        return View("result",userInfo);
        }

        return index();
    }
}

