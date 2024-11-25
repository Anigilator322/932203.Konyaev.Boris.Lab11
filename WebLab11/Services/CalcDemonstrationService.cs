namespace WebLab11.Services
{
	public class CalcDemonstrationService : ICalcDemonstrationService
	{
		public int FirstNum { get; set ; }
		public int SecondNum { get ; set ; }

		public CalcDemonstrationService()
		{
			Random random = new Random();
			FirstNum = random.Next(11);
			SecondNum = random.Next(11);
		}

		public int Addition()
		{
			return FirstNum + SecondNum;
		}

		public float Division()
		{
			if(SecondNum!=0)
			{
				return (float)FirstNum / (float)SecondNum;
			}
			else return float.PositiveInfinity;
		}

		public int Multiplication()
		{
			return FirstNum * SecondNum;
		}

		public int Subtraction()
		{
			return SecondNum - FirstNum;
		}
	}
}
