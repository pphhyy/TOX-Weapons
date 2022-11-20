using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;
using UnityEditor;
using Mono.Unix.Native;

namespace ToxWeapons
{
    public class Hediff_ToxicCysts : HediffWithComps
    {
        public override void Notify_PawnKilled()
        {
            base.Notify_PawnKilled();
            GasUtility.AddGas(pawn.PositionHeld, pawn.MapHeld, GasType.ToxGas, 4f * Severity);
        }

        public override void Notify_KilledPawn(Pawn victim, DamageInfo? dinfo)
        {
            base.Notify_KilledPawn(victim, dinfo);
        }
    }
}
