namespace OPAKOVANI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region zaklady

            Console.WriteLine(); //vypise do konzole s novym radkem
            Console.Write(""); //vypise do konzole bez noveho radkem
            Console.ReadLine(); //precze input
            string s = ""; //promenna vyuzivana na slova
            int i = 0; //promenna vyuzivana na cisla
            bool b = true; //promenna ktzera ma dve hodnoty, bud True nebo False
            double d = 1.1; //int promenna s moznosti pro destine cislo
            Convert.ToInt32 (d); //preveze na int hodnotu
            if (d > i) //pokud
            {

            }
            else if (d < i) //nebo pokud
            {

            }
            else //jinak 
            {

            }
            
            do //udelej 
            {

            }
            while (b); //kdyz (prvbe se vykonna a pak zkontroluje podminku)

            while (b) //prvne zkotroluje podminku a popripadne se pak vykona
            {

            }

            for (int ii = 1; ii <= 10; ii++) //while loop na steroidech ; ukazka vypssani cisel od 1 do 10
            {
                Console.WriteLine(ii);
            }

            #endregion

        }
    }
}