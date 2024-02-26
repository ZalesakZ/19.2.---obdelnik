namespace Model
{
    public class Obdelnik2
{
        private int stranaA;
        private int stranaB;

        public int StranaA
        {
            get => stranaA; 
            set
            {
                if (stranaA != value)
                {
                    if(value < 0)
                        stranaA = 0;    
                    else
                        stranaA = value;    
                }
            }
        }
        public int StranaB
        {
            get => stranaB; 
            set
            {
                if (stranaB != value)
                {
                    if (value < 0)
                        stranaB = 0;
                    else
                        stranaB = value;
                }
            }
        }
        public int Obvod => 2 * (stranaA + stranaB);   
        public int Obsah => stranaA * stranaB; 
        public double Uhlopricka => Math.Sqrt(StranaA * StranaA + Math.Pow(StranaB, 2));
    }
}
