using VirtualBrightPlayz.SCP_ET.Player;
using HarmonyLib;

namespace Infinite_StaminaV1
{
    [HarmonyPatch(typeof(PlayerStats), nameof(PlayerStats.ClientChangeClass))]
    public class Base
    {
        public static void Postfix(PlayerStats __instance)
        {

            __instance.SprintDecayMultiplier = 0;
            
        }

    }
}
