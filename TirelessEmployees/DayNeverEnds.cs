using HarmonyLib;

#if IL2CPP
using Il2CppScheduleOne.GameTime;
#elif MONO
using ScheduleOne.GameTime;
#endif


namespace TirelessEmployees
{
    [HarmonyPatch(typeof(TimeManager))]
    public static class DayNeverEnds
    {
        [HarmonyPatch(nameof(TimeManager.IsEndOfDay), MethodType.Getter)]
        [HarmonyPrefix]
        public static bool IsEndOfDay(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}