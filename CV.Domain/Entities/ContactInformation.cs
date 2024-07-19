using CV.Domain.Entities.Base;

namespace CV.Domain.Entities;

public class ContactInformation : Entity
{
    
    public string SocialNetworkName { get; set; }
    public string SocialNetworkLink { get; set; }
    public string Icon { get; set; }
    
    protected override void ValidateEntity()
    {
        throw new NotImplementedException();
    }
}