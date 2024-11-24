namespace WebLab11.Models
{
    public class CalcDemonstrationViewModel
    {
        public int FirstNum {  get; set; }
        public int SecondNum {  get; set; }
        public int Addition 
        {
            get
            {
                return FirstNum + SecondNum;
            }
            private set
            {
                Addition = value;
            }
        }
        public float Division 
        {  
            get
            {
                if(SecondNum == 0)
                    return float.PositiveInfinity;
                return (float)FirstNum / (float)SecondNum;
            }
            private set
            {
                Division = value;
            }
        }
        public int Multiplication
        {  
            get
            {
                return FirstNum * SecondNum;
            }
            private set 
            {
                Multiplication = value;
            }
        }
        public int Subtraction 
        {  
            get
            {
                return FirstNum - SecondNum;
            }
            private set
            {
                Subtraction = value;
            }
        }
    }
}
