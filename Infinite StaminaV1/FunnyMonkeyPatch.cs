using HarmonyLib;

namespace Infinite_StaminaV1
{
    class FunnyMonkeyFramework : PluginFramework.Plugin
    {
        public Harmony Harmony;

        public override void OnDisable()
        {
        }

        public override void OnEnable()
        {
            Harmony = new Harmony("Monkey");
            Harmony.PatchAll();
        }
    }


}
