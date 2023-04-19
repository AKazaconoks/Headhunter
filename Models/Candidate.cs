namespace Headhunter.Models;

public class Candidate
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public List<SkillSet> SkillSets { get; set; }
}