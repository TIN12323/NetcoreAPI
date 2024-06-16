using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace DemoMvc.Models;
public class Movie
{
    public int Id { get ; set;}
    public string? Title {get; set;}
    [DataType(DataType.Date)]
    public DateTime ReleaseDate {get; set;}
    public string? Genre {get; set;}
    public decimal price {get; set;}
}