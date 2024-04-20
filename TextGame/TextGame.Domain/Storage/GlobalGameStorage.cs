using TextGame.Domain.Persons;

namespace TextGame.Domain.Storage;

public static class GlobalGameStorage
{
	public static Player? Player { get; set; }
}