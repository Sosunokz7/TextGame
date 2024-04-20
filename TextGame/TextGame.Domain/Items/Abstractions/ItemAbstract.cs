namespace TextGame.Domain.Items.Abstractions;

public abstract class ItemAbstract
{
	protected ItemAbstract(string name)
	{
		Name = name;
	}

	public string Name { get; }
}