namespace BlazorApp1.Data
{
	public class Checker
	{



		public int Row { get; set; }
		public int Column { get; set; }
		public CheckersDirection Direction { get; set; }
		public string? Color { get; set; }
	}
	public enum CheckersDirection
	{
		Down, Up, Both
	}
}
