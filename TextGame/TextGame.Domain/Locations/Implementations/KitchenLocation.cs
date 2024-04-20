using TextGame.Domain.Locations.Abstractiosn;

namespace TextGame.Domain.Locations.Implementations;

public class KitchenLocation : LocationAbstract
{
	private static KitchenLocation? _kitchenLocation;

	private KitchenLocation()
			: base("Кухня")
	{
		AvailableMoveToLocationsLazy.Add(new Lazy<LocationAbstract>(HallwayLocation.Create));
	}


	public static KitchenLocation Create()
	{
		_kitchenLocation ??= new KitchenLocation();
		return _kitchenLocation;
	}
}