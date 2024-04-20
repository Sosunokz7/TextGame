using TextGame.Domain.Commands.Implementations;
using TextGame.Domain.Commands.Interfaces;
using TextGame.Domain.Factories.CommandChainFactories.Abstractions;
using TextGame.Domain.Locations.Abstractiosn;
using TextGame.Domain.Locations.Implementations;

namespace TextGame.Domain.Factories.CommandChainFactories.Implementations.ChainFactoryElements;

public class MoveToLocationCommandFactory : GameCommandAbstractFactory
{
	private GameCommandAbstractFactory? _nextFactory;

	public override IGameCommand Create(IReadOnlyCollection<string> command)
	{

		if (command.Count == 2 && command.First().Equals("идти",StringComparison.CurrentCultureIgnoreCase))
			return new MoveToLocationCommand(command.Last());
		
		_nextFactory ??= new TakeItemCommandFactory();
		return _nextFactory.Create(command);
	}
}