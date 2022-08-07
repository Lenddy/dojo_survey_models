using Microsoft.AspNetCore.Mvc;
using survey_model.Models;
public class survey:Controller{
    [HttpGet("")]
    public IActionResult index(){
        return View("index");
    }

    [HttpPost("result")]
    public IActionResult result(string name, string location, string language, string comment){
        info  submit = new info(){
            Name = name,
            Location = location,
            Language = language,
            Comment = comment
        };
        return View("result",submit);
    }
}

