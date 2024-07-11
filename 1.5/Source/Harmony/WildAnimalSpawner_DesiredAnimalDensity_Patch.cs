﻿using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using Verse;

namespace VFEInsectoids
{
    [HotSwappable]
    [HarmonyPatch(typeof(WildAnimalSpawner), "DesiredAnimalDensity", MethodType.Getter)]
    public static class WildAnimalSpawner_DesiredAnimalDensity_Patch
    {
        public static void Postfix(ref float __result, WildAnimalSpawner __instance)
        {
            if (__instance.map.IsInfested())// && __instance.map.Parent is Settlement settlement && settlement.Faction == Faction.OfInsects)
            {
                __result /= 4f;
            }
        }
    }
}
