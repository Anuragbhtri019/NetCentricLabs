using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp5ByAnurag.Models;

public partial class Student
{
    [Required(ErrorMessage = "This  is required")]
    public int Id { get; set; }
    [Required(ErrorMessage = "This  is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "This  is required")]
    public int Age { get; set; }
    [Required(ErrorMessage = "This  is required")]
    public string Email { get; set; }
}
