using TextGame.Domain.Items.Abstractions;

namespace TextGame.Domain.Locations.Abstractiosn;

public abstract class LocationAbstract
{
	protected LocationAbstract(string name)
	{
		Name = name;
		AvailableMoveToLocationsLazy = new List<Lazy<LocationAbstract>>();
		ItemsInCurrentLocation = new List<ItemAbstract>();
	}

	public string Name { get; }

	#region GetAvailableMoveToLocationByLocationName

	protected List<Lazy<LocationAbstract>> AvailableMoveToLocationsLazy { get; }

	protected IEnumerable<LocationAbstract> AvailableMoveToLocations
	{
		get => AvailableMoveToLocationsLazy.Select(s => s.Value);
	}

	public string AvailableMoveToLocationInformation
		=> $"Можно пройти - {string.Join(",",AvailableMoveToLocations.Select(s => s.Name))}";


	public LocationAbstract? GetAvailableMoveToLocationByLocationName(string locationName)
	{
		LocationAbstract? locationAbstract = AvailableMoveToLocations.FirstOrDefault(
				f => f.Name.Equals(locationName,StringComparison.CurrentCultureIgnoreCase)
				);

		if (locationAbstract is null)
		{
			Console.WriteLine($"Нет пути в {locationName}");
			return null;
		}

		return locationAbstract;
	}

	#endregion

	#region Items

	protected readonly List<ItemAbstract> ItemsInCurrentLocation;

	protected string ItemsInCurrentLocationInformation
		=> string.Join(", ",ItemsInCurrentLocation.Select(s => s.Name));


	public bool RemoveItem(ItemAbstract itemAbstract)
	{
		if (ItemsInCurrentLocation.All(all => all.Name != itemAbstract.Name))
		{
			Console.WriteLine($"Не удалось найти предмет {itemAbstract.Name} в комнате {Name}.");
			return false;
		}

		ItemsInCurrentLocation.Remove(itemAbstract);
		return true;
	}

	public ItemAbstract? FindItemByName(string itemName)
	{
		ItemAbstract? itemAbstract = ItemsInCurrentLocation.FirstOrDefault(
				f => f.Name.Equals(itemName,StringComparison.InvariantCultureIgnoreCase)
				);

		if (itemAbstract is not null)
			return itemAbstract;

		Console.WriteLine($"Не удалось найти предмет с имен {itemName} в локации {Name}.");
		return null;

	}

	#endregion


	public virtual string Information
	{
		get => $"Ничего интересного. {AvailableMoveToLocationInformation}";
		private set { }
	}
}