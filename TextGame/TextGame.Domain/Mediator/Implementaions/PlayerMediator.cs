using TextGame.Domain.Commands.Implementations;
using TextGame.Domain.Commands.Interfaces;
using TextGame.Domain.Mediator.Abstractions;
using TextGame.Domain.Storage;

namespace TextGame.Domain.Mediator.Implementaions;

public class PlayerMediator : MediatorAbstract
{
	public override void Send(IGameCommand gameCommand)
	{
		CommandHandler((dynamic)gameCommand);
	}


	private void CommandHandler(MoveToLocationCommand moveToLocationCommand)
	{
		GlobalGameStorage.Player.MoveToLocation(moveToLocationCommand.LocationName);
	}

	private void CommandHandler(LookAroundCommand lookAroundCommand)
	{
		GlobalGameStorage.Player.LookAround();
	}

	private void CommandHandler(TakeItemCommand takeItemCommand)
	{
		GlobalGameStorage.Player.TakeItem(takeItemCommand.ItemName);

	}
}