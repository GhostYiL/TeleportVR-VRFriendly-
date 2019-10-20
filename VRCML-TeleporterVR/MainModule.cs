using Mod.Teleport;
using System;
using VRCModLoader;


namespace SPS
{
    public class MainModule : VRCMod
    {
        public void Start()
        {
            try
            {

                MainModule.tpmodule.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
        }

        private static Teleport tpmodule = new Teleport();



        public static Teleport GetTeleport()
        {
            return MainModule.tpmodule;
        }
        
    }
}
