using CV.Domain.Entities.Base;

namespace CV.Domain.Entities;

public class Project : Entity
{
    public string Title { get; set; }
    public string Url { get; set; }
    public string Image { get; set; }
    
    protected override void ValidateEntity()
    {
        throw new NotImplementedException();
    }
}