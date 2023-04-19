namespace Headhunter.Models;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Position> Positions { get; set; }
}