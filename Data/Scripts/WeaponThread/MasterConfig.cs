namespace WeaponThread
{
    partial class Weapons
    {
        internal Weapons()
        {
            // file convention: Name.cs - See Example.cs file for weapon property details.
            //
            // Enable your config files using the follow syntax, don't include the ".cs" extension:
            // ConfigFiles(Your1stConfigFile, Your2ndConfigFile, Your3rdConfigFile);

            ConfigFiles(
                        XB3PulseBattery,
                        XB3BeamBattery,
                        XB1PulseBattery,
                        XB1BeamBattery,
                        EX1BeamCannon,
                        XP1LaserTurret,
                        //EX1BeamCannonExtra
                        //XP1LaserTurret,
                        EX1PointDefense
                        );//XB1BeamBattery, XB3BeamBattery,
        }
    }
}
