﻿
using System.Collections.Generic;
using RimWorld;
using UnityEngine;
using Verse;

namespace VFEInsectoids
{


    public class Recipe_AdministerBlackPherocore : RecipeWorker
    {
        public override void ApplyOnPawn(Pawn pawn, BodyPartRecord part, Pawn billDoer, List<Thing> ingredients, Bill bill)
        {
            Hediff hediff = HediffMaker.MakeHediff(VFEI_DefOf.VFEI2_BlackEmpressSpawn, pawn);
            hediff.Severity = 0.01f;
            pawn.health.AddHediff(hediff);
        }

        public override AcceptanceReport AvailableReport(Thing thing, BodyPartRecord part = null)
        {
            Pawn pawn;
            if ((pawn = thing as Pawn) == null)
            {
                return false;
            }

            if (pawn.Map?.listerThings?.ThingsOfDef(VFEI_DefOf.VFEI2_PherocoreBlack)?.Count == 0)
            {
                return false;
            }
            return base.AvailableReport(thing, part);
        }
    }
}

