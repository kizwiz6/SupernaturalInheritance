namespace SupernaturalInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pupil p = new Pupil("Kizil-Wizil");
            Storm windStorm = p.CastWindStorm();
            Console.WriteLine(windStorm.Announce());

            Mage m = new Mage("Gul'dan");
            Storm rainStorm = m.CastWindStorm();
            Console.WriteLine(rainStorm.Announce());

            Archmage a = new Archmage("Nielas Aran");
            Storm archmageRainStorm = a.CastRainStorm();
            Storm archmageLightning = a.CastLightningStorm();
            Console.WriteLine(archmageRainStorm.Announce());
            Console.WriteLine(archmageLightning.Announce());
        }
    }
}
