﻿ namespace XIVSlothComboPlugin.Combos
{
    internal static class All
    {
        public const byte JobID = 99;

        public const uint
            Swiftcast = 7561,
            Resurrection = 173,
            Verraise = 7523,
            Raise = 125,
            Reprisal = 7535,
            Ascend = 3603,
            Egeiro = 24287,
            SolidReason = 232,
            AgelessWords = 215,
            WiseToTheWorldMIN = 26521,
            WiseToTheWorldBTN = 26522,
            LowBlow = 7540,
            Interject = 7538,
            Feint = 7549,
            Addle = 7560;

        public static class Buffs
        {
            public const ushort
                Swiftcast = 167;
        }

        public static class Debuffs
        {
            public const ushort
                Reprisal = 1193,
                Feint = 1195,
                Addle = 1203;
        }

        public static class Levels
        {
            public const byte
                Feint = 22,
                Addle = 8,
                Raise = 12;
        }
    }
    /*internal class InterruptFeature : CustomCombo
    {
        protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.InterruptFeature;

        protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
        {
            if (actionID == All.LowBlow)
            {
                var interjectCD = GetCooldown(All.Interject);
                var lowBlowCD = GetCooldown(All.LowBlow);
                if (CanInterruptEnemy() && !interjectCD.IsCooldown)
                    return All.Interject;
            }

            return actionID;
        }
    }

    internal class DoMSwiftcastFeature : CustomCombo
    {
        protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.DoMSwiftcastFeature;

        protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
        {
            if (IsEnabled(CustomComboPreset.DoMSwiftcastFeature))
            {
                if (actionID == WHM.Raise || actionID == SMN.Resurrection || actionID == SGE.Egeiro || actionID == AST.Ascend || actionID == RDM.Verraise)
                {
                    var swiftCD = GetCooldown(All.Swiftcast);
                    if ((swiftCD.CooldownRemaining == 0 && !HasEffect(RDM.Buffs.Dualcast))
                        || level <= All.Levels.Raise
                        || (level <= RDM.Levels.Verraise && actionID == RDM.Verraise))
                        return All.Swiftcast;
                }
            }

            return actionID;
        }
    }

    internal class AllTankReprisalFeature : CustomCombo
    {
        protected override CustomComboPreset Preset => CustomComboPreset.AllTankReprisalFeature;

        protected override uint Invoke(uint actionID, uint lastComboMove, float comboTime, byte level)
        {
            if (actionID == All.Reprisal)
            {
                if (TargetHasEffectAny(All.Debuffs.Reprisal))
                    return WHM.Stone1;
            }

            return actionID;
        }
    }
    
      internal class AllMeleeFeintProtection : CustomCombo
    {
        protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.AllMeleeFeintProtection;

        protected override uint Invoke(uint actionID, uint lastComboActionID, float comboTime, byte level)
        {
            if (actionID is All.Feint)
            {
                if (TargetHasEffect(All.Debuffs.Feint) && IsOffCooldown(actionID: All.Feint))
                    return NIN.Rabbit;
             }

            return actionID;
            }
        }
        
           internal class AllCasterAddleProtection : CustomCombo
    {
        protected internal override CustomComboPreset Preset { get; } = CustomComboPreset.AllCasterAddleProtection;

        protected override uint Invoke(uint actionID, uint lastComboActionID, float comboTime, byte level)
        {
            if (actionID is All.Addle)
            {
                if (TargetHasEffect(All.Debuffs.Addle) && IsOffCooldown(actionID: All.Addle))
                    return WHM.Stone1;
             }

            return actionID;
            }
        }
    }
    */
}

