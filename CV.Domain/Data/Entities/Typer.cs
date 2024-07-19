using CV.Domain.Data.Entities.Base;

namespace CV.Domain.Data.Entities;

public class Typer : Entity
{
    public IEnumerable<string> TyperPhrase { get; set; }
    
    public int TyperOrder { get; set; }
    
    protected override void ValidateEntity()
    {
        throw new NotImplementedException();
    }
}