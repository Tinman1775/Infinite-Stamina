using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using VirtualBrightPlayz.SCP_ET.Player.Effects;

namespace Infinite_StaminaV1.Patches_Monke_
{
    [HarmonyPatch(typeof(MultiplierEffect), nameof(MultiplierEffect.StopEffect))]
    class MonkeMultStop
    {
        public static void Postfix(MultiplierEffect __instance)
        {

            __instance.player.stats.SprintDecayMultiplier = 0;

        }
    }
}
