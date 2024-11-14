using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleFramework;
using VehicleFramework.VehicleTypes;
using Aquaworks.Core;
using UnityEngine;
using VehicleFramework.VehicleParts;
using VehicleFramework.Assets;

namespace Aquaworks.AtlanticExplorer
{
    public class AtlanticExplorer : Submersible
    {
        public override GameObject VehicleModel
        {
            get
            {
                return transform.Find("model").gameObject;
            }
        }

        public override GameObject CollisionModel
        {
            get
            {
                return transform.Find("CollisionModel").gameObject;
            }
        }
        public override GameObject StorageRootObject
        {
            get
            {
                return transform.Find("StorageRoot").gameObject;
            }
        }

        public override GameObject ModulesRootObject
        {
            get
            {
                return transform.Find("ModulesRoot").gameObject;
            }
        }

        public override GameObject BoundingBox
        {
            get
            {
                return transform.Find("BoundingBox").gameObject;
            }
        }

        public override List<GameObject> WaterClipProxies
        {
            get
            {
                var list = new List<GameObject>();
                foreach(Transform child in transform.Find("WaterClipProxies"))
                {
                    list.Add(child.gameObject);
                }
                return list;
                
            }
        }
        
        public override List<GameObject> CanopyWindows
        {
            get
            {
                var list = new List<GameObject>();
                list.Add(transform.Find("model/Transparency.002").gameObject);
                return list;
            }
        }

        public override List<VehicleStorage> InnateStorages
        {
            get
            {
                var list = new List<VehicleFramework.VehicleParts.VehicleStorage>();
                VehicleFramework.VehicleParts.VehicleStorage thisVS = new VehicleFramework.VehicleParts.VehicleStorage();
                Transform thisStorage = transform.Find("Storage/pack1");
                thisVS.Container = thisStorage.gameObject;
                thisVS.Height = 8;
                thisVS.Width = 6;
                list.Add(thisVS);
                return list;
            }
        }

        public override List<VehicleUpgrades> Upgrades
        {
            get
            {
                var list = new List<VehicleFramework.VehicleParts.VehicleUpgrades>();
                VehicleFramework.VehicleParts.VehicleUpgrades vu = new VehicleFramework.VehicleParts.VehicleUpgrades();
                Transform thisStorage = transform.Find("Storage/pack1");
                vu.Interface = transform.Find("UpgradesInterface").gameObject;
                vu.Flap = vu.Interface;
                list.Add(vu);
                return list;
            }
        }
        
        public override List<VehicleBattery> Batteries
        {
            get
            {
                var list = new List<VehicleFramework.VehicleParts.VehicleBattery>();
                
                VehicleFramework.VehicleParts.VehicleBattery vB1 = new VehicleFramework.VehicleParts.VehicleBattery();
                vB1.BatterySlot = transform.Find("Batteries/Battery 1").gameObject;
                list.Add(vB1);
                
                VehicleFramework.VehicleParts.VehicleBattery vB2 = new VehicleFramework.VehicleParts.VehicleBattery();
                vB2.BatterySlot = transform.Find("Batteries/Battery 2").gameObject;
                list.Add(vB2);

                return list;
            }
        }

        public override List<VehicleFloodLight> HeadLights
        {
            get
            {
                var list = new List<VehicleFramework.VehicleParts.VehicleFloodLight>();

                VehicleFramework.VehicleParts.VehicleFloodLight vl1 =
                    new VehicleFramework.VehicleParts.VehicleFloodLight
                    {
                        Light = transform.Find("lighs_parent/Headlight").gameObject,
                        Angle = 70,
                        Color = Color.white,
                        Intensity = 0.6f,
                        Range = 80f
                    };
                list.Add(vl1);

                VehicleFramework.VehicleParts.VehicleFloodLight vl2 =
                    new VehicleFramework.VehicleParts.VehicleFloodLight
                    {
                        Light = transform.Find("lighs_parent/Headlight (1)").gameObject,
                        Angle = 70,
                        Color = Color.white,
                        Intensity = 0.6f,
                        Range = 80f
                    };
                list.Add(vl2);
                
                VehicleFramework.VehicleParts.VehicleFloodLight vl3 =
                    new VehicleFramework.VehicleParts.VehicleFloodLight
                    {
                        Light = transform.Find("lighs_parent/Headlight (2)").gameObject,
                        Angle = 70,
                        Color = Color.white,
                        Intensity = 0.7f,
                        Range = 70f
                    };
                list.Add(vl3);
                
                VehicleFramework.VehicleParts.VehicleFloodLight vl4 =
                    new VehicleFramework.VehicleParts.VehicleFloodLight
                    {
                        Light = transform.Find("lighs_parent/Headlight (3)").gameObject,
                        Angle = 70,
                        Color = Color.white,
                        Intensity = 0.7f,
                        Range = 70f
                    };
                list.Add(vl4);
                
                VehicleFramework.VehicleParts.VehicleFloodLight vl5 =
                    new VehicleFramework.VehicleParts.VehicleFloodLight
                    {
                        Light = transform.Find("lighs_parent/Headlight (4)").gameObject,
                        Angle = 70,
                        Color = Color.white,
                        Intensity = 0.6f,
                        Range = 70f
                    };
                list.Add(vl5);
                
                VehicleFramework.VehicleParts.VehicleFloodLight vl6 =
                    new VehicleFramework.VehicleParts.VehicleFloodLight
                    {
                        Light = transform.Find("lighs_parent/Headlight (5)").gameObject,
                        Angle = 70,
                        Color = Color.white,
                        Intensity = 0.6f,
                        Range = 70f
                    };
                list.Add(vl6);

                return list;
            }
        }

        public override VehiclePilotSeat PilotSeat
        {
            get
            {
                VehicleFramework.VehicleParts.VehiclePilotSeat vps = new VehicleFramework.VehicleParts.VehiclePilotSeat();
                Transform mainSeat = transform.Find("PilotSeat");
                vps.Seat = mainSeat.gameObject;
                vps.SitLocation = mainSeat.gameObject;
                vps.LeftHandLocation = mainSeat;
                vps.RightHandLocation = mainSeat;
                return vps;
            }
        }

        public override List<VehicleHatchStruct> Hatches
        {
            get
            {
                var list = new List<VehicleFramework.VehicleParts.VehicleHatchStruct>();
                
                VehicleFramework.VehicleParts.VehicleHatchStruct top_vhs = new VehicleFramework.VehicleParts.VehicleHatchStruct();
                Transform intHatch = transform.Find("Hatch");
                top_vhs.Hatch = intHatch.gameObject;
                top_vhs.ExitLocation = intHatch.Find("ExitLocation");
                top_vhs.SurfaceExitLocation = intHatch.Find("ExitLocation");
                list.Add(top_vhs);

                return list;
            }
        }

        public override bool HasArms => false;
        public override int NumModules => 3;
        public override int Mass => 250;
        public override int MaxHealth => 300;
        public override int BaseCrushDepth => 400;
        public override int CrushDepthUpgrade1 => 800;
        public override int CrushDepthUpgrade2 => 1000;
        public override int CrushDepthUpgrade3 => 1500;
        public override string Description => "Explore the deep with the Atlantic Explorer - modified to explore 4546b";
        public override string EncyclopediaEntry => "The Atlantic Explorer made by Aquaworks Industries for Alterra for the exploration of Planet 6886d in the undiscovered Julie Regions of the galaxy." +
                                                    "Designed to be a tank to explore the depths of your words - Brought to you by Aquaworks" +
                                                    "This version of the Atlantic Explorer has been modified to explroe 4546b";

        public override TechType UnlockedWith => TechType.Cyclops;
        public override Atlas.Sprite PingSprite => null;

        public override Dictionary<TechType, int> Recipe
        {
            get
            {
                Dictionary<TechType, int> recipe = new Dictionary<TechType, int>();
                recipe.Add(TechType.PlasteelIngot, 3);
                recipe.Add(TechType.ComputerChip, 1);
                recipe.Add(TechType.Lubricant, 1);
                recipe.Add(TechType.Lead, 2);
                recipe.Add(TechType.PowerCell, 2);
                recipe.Add(TechType.Battery, 1);
                recipe.Add(TechType.TitaniumIngot, 5);
                recipe.Add(TechType.Copper, 2);
                recipe.Add(TechType.Glass, 1);
                recipe.Add(TechType.Silver, 1);

                return recipe;
            }
        }
    }
}