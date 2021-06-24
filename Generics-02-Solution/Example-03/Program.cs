using System;

namespace Example_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic Implementation
            Football<Messi> messiBro = new Football<Messi>(new Messi());
            Football<Ronaldo> ronaldoBro = new Football<Ronaldo>(new Ronaldo());
            Football<Angon> angonBro = new Football<Angon>(new Angon());
             
            messiBro.Play();
            ronaldoBro.Play();
            angonBro.Play();

            Messi trainMessi = messiBro.Bootcamp;
            Ronaldo trainRonaldo = ronaldoBro.Bootcamp;
            Angon trainAngon = angonBro.Bootcamp;
            #endregion

            #region Non-generic Implementation
            FootballOld messiOld = new FootballOld(new Messi());
            FootballOld ronaldoOld = new FootballOld(new Ronaldo());
            FootballOld angonOld = new FootballOld(new Angon());


            Messi trainOldMessi1 = (Messi)messiOld.Bootcamp;
            Ronaldo trainOldRonaldo1 = (Ronaldo)ronaldoOld.Bootcamp;
            Angon trainOldAngon1 = (Angon)angonOld.Bootcamp;

            //Another Way
            IStriker trainOldMessi2 = messiOld.Bootcamp;
            IStriker trainOldRonaldo2 = ronaldoOld.Bootcamp;
            IStriker trainOldAngon2 = angonOld.Bootcamp;
            #endregion

        }
    }
}
