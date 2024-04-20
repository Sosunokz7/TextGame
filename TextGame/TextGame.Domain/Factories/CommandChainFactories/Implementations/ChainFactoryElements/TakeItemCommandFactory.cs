using TextGame.Domain.Commands.Implementations;
using TextGame.Domain.Commands.Interfaces;
using TextGame.Domain.Factories.CommandChainFactories.Abstractions;

namespace TextGame.Domain.Factories.CommandChainFactories.Implementations.ChainFactoryElements;

public class TakeItemCommandFactory : GameCommandAbstractFactory
{
	public override IGameCommand Create(IReadOnlyCollection<string> command)
	{
		if (command.Count ==2 && command.First().Equals("взять",StringComparison.CurrentCultureIgnoreCase))
		{
			return new TakeItemCommand(command.Last());
		}

		return new UnknownCommand();
	}
}