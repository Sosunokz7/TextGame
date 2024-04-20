using TextGame.Domain.Commands.Implementations;
using TextGame.Domain.Commands.Interfaces;

namespace TextGame.Domain.Mediator.Abstractions;

public abstract class MediatorAbstract
{
	public abstract void Send(IGameCommand gameCommand);

	protected void CommandHandler(UnknownCommand unknownCommand)
	{
		Console.WriteLine("Неизвестная команда.");
	}
}