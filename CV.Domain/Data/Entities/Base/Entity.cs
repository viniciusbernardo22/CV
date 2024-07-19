namespace CV.Domain.Data.Entities.Base;

public abstract class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    protected abstract void ValidateEntity();
}