// model of student entity
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

public class Student
{
    [Required]
    public int Id { set; get; }
    [Required]
    public string Name { set; get; } 
    [Required]
    public string Major { set; get; }
}