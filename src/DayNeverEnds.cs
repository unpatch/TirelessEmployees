using HarmonyLib;
using Il2CppScheduleOne.GameTime;

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