using System;



namespace MunApplikaatio

{

    class Auto

    {

        string merkki;

        string vari;

        int vuosi;



        static void Main(string[] args)

        {

            Auto ekaAutoni = new Auto();

            Auto tokaAutoni = new Auto();

            Auto vikaAutoni = new Auto();



            ekaAutoni.merkki = "Audi";

            ekaAutoni.vari = "punainen";

            ekaAutoni.vuosi = 2010;



            tokaAutoni.merkki = "Honda";

            tokaAutoni.vari = "vihreä";

            tokaAutoni.vuosi = 2018;



            vikaAutoni.merkki = "Volvo";

            vikaAutoni.vari = "keltainen";

            vikaAutoni.vuosi = 2020;

        }

    }

}