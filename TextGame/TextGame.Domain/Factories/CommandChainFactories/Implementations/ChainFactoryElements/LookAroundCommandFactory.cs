using TextGame.Domain.Commands.Implementations;
using TextGame.Domain.Commands.Interfaces;
using TextGame.Domain.Factories.CommandChainFactories.Abstractions;

namespace TextGame.Domain.Factories.CommandChainFactories.Implementations.ChainFactoryElements;

public class LookAroundCommandFactory : GameCommandAbstractFactory
{
	private GameCommandAbstractFactory? _nextFactory;

	public override IGameCommand Create(IReadOnlyCollection<string> command)
	{
		if (command.First().Equals("осмотреться",StringComparison.CurrentCultureIgnoreCase))
			return new LookAroundCommand();

		_nextFactory ??= new MoveToLocationCommandFactory();
		return _nextFactory.Create(command);
	}
}