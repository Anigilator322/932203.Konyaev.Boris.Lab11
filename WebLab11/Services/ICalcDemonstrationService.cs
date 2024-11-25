namespace WebLab11.Services
{
	public interface ICalcDemonstrationService
	{
		public int FirstNum { get; set; }
		public int SecondNum { get; set; }
		public float Division();
		public int Subtraction();
		public int Addition();
		public int Multiplication();
	}
}