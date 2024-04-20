// See https://aka.ms/new-console-template for more information


using TextGame;
using TextGame.Domain.Commands.Interfaces;
using TextGame.Domain.Factories.CommandChainFactories.Implementations;
using TextGame.Domain.Mediator.Implementaions;

InitialGame.InitGame();

PlayerMediator playerMediator = new PlayerMediator();
StartChainCommandFactory lookAroundCommandFactory = new StartChainCommandFactory();


while (true)
{
	string command = Console.ReadLine()!;
	IGameCommand gameCommand = lookAroundCommandFactory.Create(command.ToLower());
	playerMediator.Send(gameCommand);

}