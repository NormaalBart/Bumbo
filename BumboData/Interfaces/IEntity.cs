namespace BumboData.Interfaces;

public interface IEntity : IEntity<int>
{
}

public interface IEntity<T>
{
    public T Id { get; set; }
}