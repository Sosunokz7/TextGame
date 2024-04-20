using TextGame.Domain.Locations.Implementations;
using TextGame.Domain.Persons;
using TextGame.Domain.Storage;

namespace TextGame;

public static class InitialGame
{
	public static void InitGame()
	{
		GlobalGameStorage.Player = new Player(KitchenLocation.Create());
	}
}