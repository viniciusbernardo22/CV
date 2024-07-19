namespace CV.Domain.Entities.Base;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    protected abstract void ValidateEntity();
}