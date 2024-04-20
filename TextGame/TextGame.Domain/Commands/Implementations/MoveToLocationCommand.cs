using TextGame.Domain.Commands.Interfaces;

namespace TextGame.Domain.Commands.Implementations;

public class MoveToLocationCommand : IGameCommand
{
	public MoveToLocationCommand(string locationName)
	{
		LocationName = locationName;
	}

	public string LocationName { get; }
}