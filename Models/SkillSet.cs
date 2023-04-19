namespace Headhunter.Models;

public class SkillSet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Level { get; set; }
    public int CandidateId { get; set; }
}