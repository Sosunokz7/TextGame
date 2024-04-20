using TextGame.Domain.Items.Abstractions;
using TextGame.Domain.Items.Implementations;
using TextGame.Domain.Locations.Abstractiosn;

namespace TextGame.Domain.Locations.Implementations;

public class RoomLocation : LocationAbstract
{
	private static RoomLocation? _roomLocation;

	private RoomLocation()
			: base("Комната")
	{
		AvailableMoveToLocationsLazy.Add(new Lazy<LocationAbstract>(HallwayLocation.Create));
		ItemsInCurrentLocation.AddRange(new ItemAbstract[]
		{
				new KeysItem(),
				new SynopsisItem(),
				new BackpackItem(),
		});

	}

	public override string Information
	{
		get
		{
			string itemsInCurrentLocationString = ItemsInCurrentLocationInformation;
			if (string.IsNullOrEmpty(itemsInCurrentLocationString))
				return base.Information;

			return $"На столе: {itemsInCurrentLocationString}.";
		}
	}


	public static RoomLocation Create()
	{
		_roomLocation ??= new RoomLocation();
		return _roomLocation;

	}
}