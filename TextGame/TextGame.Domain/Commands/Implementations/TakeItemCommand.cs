using TextGame.Domain.Commands.Interfaces;

namespace TextGame.Domain.Commands.Implementations;

public class TakeItemCommand : IGameCommand
{
	public TakeItemCommand(string itemName)
	{
		ItemName = itemName;
	}

	public string ItemName { get; }
}