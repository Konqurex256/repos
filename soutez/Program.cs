namespace soutez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "SP[MVTUFOJN![QSBWZ!KTJ!QSPLB[BM![BKJNBWF!QSPHSBNBUPSTLF!EPWFEOPTUJ/!UP!KF!WTBL!UFQSWF![BDBUFL\"!EBMTJ!VLPMZ!OBKEFT!OB!BESFTF!QBSEVCJDLZ.IBDLFS/EFMUB.TLPMB/D[-![BMP[!TJ![EF!VDFU!B!QVTU!TF!EP!KFKJDI!SFTFOJ/!OB!DBTF![BMF[J\"\"\"!41!OFKMFQTJDI!QP[WFNF!EP!GJOBMF";
            char[] chars = {'!', '[', '"'};
            string slovo = msg.Trim(chars);
            Console.WriteLine(slovo);
        }
    }
}