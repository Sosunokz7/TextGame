using TextGame.Domain.Items.Abstractions;
using TextGame.Domain.Locations.Abstractiosn;

namespace TextGame.Domain.Persons;

public class Player
{
	private readonly List<ItemAbstract> _playerInventory;

	private LocationAbstract CurrentLocation { get; set; }

	public Player(LocationAbstract currentLocation)
	{
		CurrentLocation = currentLocation;
		_playerInventory = new List<ItemAbstract>();
	}

	public void MoveToLocation(string locationName)
	{
		LocationAbstract? locationAbstract = CurrentLocation.GetAvailableMoveToLocationByLocationName(locationName);
		if (locationAbstract is null)
			return;

		CurrentLocation = locationAbstract;
		Console.WriteLine(
				$"Ты находишся в {CurrentLocation.Name}. {CurrentLocation.AvailableMoveToLocationInformation}"
				);


	}

	public void LookAround()
	{
		Console.WriteLine($"Ты находишся в {CurrentLocation.Name}. {CurrentLocation.Information}");
	}

	public void TakeItem(string itemName)
	{
		ItemAbstract? itemAbstract = CurrentLocation.FindItemByName(itemName);

		_playerInventory.Add(itemAbstract);
		if (!CurrentLocation.RemoveItem(itemAbstract))
			_playerInventory.Remove(itemAbstract);

	}
}