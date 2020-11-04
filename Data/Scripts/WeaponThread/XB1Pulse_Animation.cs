using System.Collections.Generic;
using static WeaponThread.WeaponStructure;
using static WeaponThread.WeaponStructure.WeaponDefinition;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.RelMove.MoveType;
using static WeaponThread.WeaponStructure.WeaponDefinition.AnimationDef.RelMove;


namespace WeaponThread
{ // Don't edit above this line
    partial class Weapons
    {
        private AnimationDef XB1Pulse_Animation => new AnimationDef
        {
            Emissives = new []
            {

                Emissive(
                    EmissiveName: "TurnOn",
                    Colors: new []
                    {
                        Color(red:0, green: 0, blue:0, alpha: 1),//will transitions form one color to the next if more than one
                        Color(red:0, green: .1f, blue:.1f, alpha: .1f),

                    },
                    IntensityFrom:0, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:1,
                    CycleEmissiveParts: false,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: true,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive3"
                    }),

                Emissive(
                    EmissiveName: "TurnOff",
                    Colors: new []
                    {
                        Color(red:0, green: .1f, blue:.1f, alpha: .1f),//will transitions form one color to the next if more than one
                        Color(red:0, green: 0, blue: 0, alpha: 1),//will transitions form one color to the next if more than one
                        

                    },
                    IntensityFrom:1, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:0,
                    CycleEmissiveParts: false,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: true,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive3"
                    }),




                Emissive(
                    EmissiveName: "PowerUp", 
                    Colors: new []
                    {
                        Color(red:0, green: .1f, blue:.1f, alpha: .1f),//will transitions form one color to the next if more than one
                        Color(red:0, green: 1, blue:1, alpha: 1),
                        
                    }, 
                    IntensityFrom:0, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:1, 
                    CycleEmissiveParts: false,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: true,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive3"
                    }),

                Emissive(
                    EmissiveName: "ShootPulse",
                    Colors: new []
                    {

                        
                        Color(red:0, green: 2, blue: 2, alpha: 1),

                    },
                    IntensityFrom:1, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:2,
                    CycleEmissiveParts: false,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: true,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive3"
                    }),
                Emissive(
                    EmissiveName: "PowerDown",
                    Colors: new []
                    {

                        Color(red:0, green: 2, blue:2, alpha: 1),
                        Color(red:0, green: .1f, blue:.1f, alpha: .1f),

                    },
                    IntensityFrom:2, //starting intensity, can be 0.0-1.0 or 1.0-0.0, setting both from and to, to the same value will stay at that value
                    IntensityTo:1,
                    CycleEmissiveParts: false,//whether to cycle from one part to the next, while also following the Intensity Range, or set all parts at the same time to the same value
                    LeavePreviousOn: true,//true will leave last part at the last setting until end of animation, used with cycleEmissiveParts
                    EmissivePartNames: new []
                    {
                        "Emissive3"
                    }),

            },
            WeaponAnimationSets = new[]
            {
                new PartAnimationSetDef()
                {
                    SubpartId = Names("MissileTurretBarrels"),
                    BarrelId = "Any", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 60,
                    AnimationDelays = Delays(FiringDelay : 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(),
                    ResetEmissives = Events(),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        

                        [TurnOn] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 60, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay,
                                     EmissiveName = "TurnOn",//name of defined emissive
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                        [TurnOff] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 60, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay,
                                     EmissiveName = "TurnOff",//name of defined emissive
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },



                        
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay,
                                     EmissiveName = "ShootPulse",//name of defined emissive
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                                
                            },
                        [StopFiring] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 60, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay,
                                     EmissiveName = "PowerDown",//name of defined emissive
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                        //[BurstReload] =
                        //    new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                        //    {

                        //        new RelMove
                        //        {
                        //            CenterEmpty = "",
                        //            TicksToMove = 60, //number of ticks to complete motion, 60 = 1 second
                        //            MovementType = Delay,
                        //             EmissiveName = "PowerDown",//name of defined emissive
                        //            LinearPoints = new XYZ[0],
                        //            Rotation = Transformation(0, 0, 0), //degrees
                        //            RotAroundCenter = Transformation(0, 0, 0), //degrees
                        //        },
                        //    },

                    }
                },
               
            }
        };
    }
}
