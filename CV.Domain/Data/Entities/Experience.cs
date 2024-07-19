using CV.Domain.Data.Entities.Base;

namespace CV.Domain.Data.Entities;

public class Experience : Entity
{
    public string Role { get; set; }
    public string Company { get; set; }
    public string? EnterpriseLogo { get; set; }
    public DateTime Admission { get; set; }
    public DateTime ExitDate { get; set; }
    public string Location { get; set; }
    public string WorkMethod { get; set; }
    public string TimeInRole { get; set; }
    public IEnumerable<string> Responsabilities { get; set; }
    public IEnumerable<string>? MainResults { get; set; }
    
    protected override void ValidateEntity()
    {
        throw new NotImplementedException();
    }
}