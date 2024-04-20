using TextGame.Domain.Commands.Interfaces;

namespace TextGame.Domain.Factories.CommandChainFactories.Abstractions;

public abstract class GameCommandAbstractFactory
{
	public abstract IGameCommand Create(IReadOnlyCollection<string> command);
}