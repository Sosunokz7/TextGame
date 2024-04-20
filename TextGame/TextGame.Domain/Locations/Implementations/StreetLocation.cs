using TextGame.Domain.Locations.Abstractiosn;

namespace TextGame.Domain.Locations.Implementations;

public class StreetLocation : LocationAbstract
{
	private static StreetLocation? _streetLocation;

	private StreetLocation()
			: base("Улица")
	{
		AvailableMoveToLocationsLazy.Add(new Lazy<LocationAbstract>(RoomLocation.Create));
	}

	public override string Information => $"На улице весна. {AvailableMoveToLocationInformation}";

	public static StreetLocation Create()
	{
		_streetLocation ??= new StreetLocation();


		return _streetLocation;
	}
}