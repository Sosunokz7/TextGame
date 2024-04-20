using TextGame.Domain.Commands.Interfaces;
using TextGame.Domain.Factories.CommandChainFactories.Abstractions;
using TextGame.Domain.Factories.CommandChainFactories.Implementations.ChainFactoryElements;

namespace TextGame.Domain.Factories.CommandChainFactories.Implementations;

public class StartChainCommandFactory
{
	private GameCommandAbstractFactory? _nextFactory;

	public IGameCommand Create(string command)
	{
		_nextFactory ??= new LookAroundCommandFactory();
		return _nextFactory.Create(command.Split(" "));
	}
}