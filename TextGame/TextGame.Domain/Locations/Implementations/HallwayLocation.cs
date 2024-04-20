using TextGame.Domain.Locations.Abstractiosn;

namespace TextGame.Domain.Locations.Implementations;

public class HallwayLocation : LocationAbstract
{
	private static HallwayLocation? _hallwayLocation;

	private HallwayLocation()
			: base("Коридор")
	{
		AvailableMoveToLocationsLazy.AddRange(new[]
		{
				new Lazy<LocationAbstract>(KitchenLocation.Create),
				new Lazy<LocationAbstract>(RoomLocation.Create),
				new Lazy<LocationAbstract>(StreetLocation.Create),
		});

	}


	public static HallwayLocation Create()
	{
		_hallwayLocation ??= new HallwayLocation();

		return _hallwayLocation;
	}
}