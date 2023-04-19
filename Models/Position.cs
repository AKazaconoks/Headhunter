namespace Headhunter.Models;

public class Position
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateOpened { get; set; }
    public int CompanyId { get; set; }
}