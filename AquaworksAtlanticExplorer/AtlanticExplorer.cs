﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VehicleFramework;
using VehicleFramework.VehicleParts;
using VehicleFramework.VehicleTypes;
using System.IO;
using System.Reflection;
using UnityEngine.U2D;
using System.Collections;
using UWE;
using static Nautilus.Assets.PrefabTemplates.FabricatorTemplate;
using UnityEngine.Assertions;
using VehicleFramework.Assets;
using VehicleFramework.Engines;

namespace Aquaworks.AtlanticExplorer
{
    public class AtlanticExplorer : Submarine
    {
        public override GameObject VehicleModel
        {
            get
            {
                return transform.Find("model").parent.gameObject;
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

        public override BoxCollider BoundingBoxCollider
        {
            get
            {
                return transform.Find("BoundingBox").gameObject.GetComponent<BoxCollider>();
            }
        }

        public override List<GameObject> WaterClipProxies
        {
            get
            {
                var list = new List<GameObject>();
                foreach(Transform child in transform.Find("WaterClipProxy"))
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
                        Light = transform.Find("lights_parent/Headlight").gameObject,
                        Angle = 50,
                        Color = Color.cyan,
                        Intensity = 0.8f,
                        Range = 120f
                    };
                list.Add(vl1);

                VehicleFramework.VehicleParts.VehicleFloodLight vl2 =
                    new VehicleFramework.VehicleParts.VehicleFloodLight
                    {
                        Light = transform.Find("lights_parent/Headlight (1)").gameObject,
                        Angle = 50,
                        Color = Color.cyan,
                        Intensity = 0.8f,
                        Range = 120f
                    };
                list.Add(vl2);

                return list;
            }
        }

        public override List<VehiclePilotSeat> PilotSeats
        {
            get
            {
                var list = new List<VehicleFramework.VehicleParts.VehiclePilotSeat>();
                VehicleFramework.VehicleParts.VehiclePilotSeat vps = new VehicleFramework.VehicleParts.VehiclePilotSeat();
                Transform mainSeat = transform.Find("PilotSeat");
                vps.Seat = mainSeat.gameObject;
                vps.SitLocation = mainSeat.Find("Sit").gameObject;
                vps.LeftHandLocation = mainSeat;
                vps.RightHandLocation = mainSeat;
                vps.ExitLocation = mainSeat.Find("Exit");
                list.Add(vps);
                return list;
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
                top_vhs.EntryLocation = intHatch.Find("EntryLocation");
                list.Add(top_vhs);
                
                VehicleFramework.VehicleParts.VehicleHatchStruct bottom_vhs = new VehicleFramework.VehicleParts.VehicleHatchStruct();
                Transform intHatch2 = transform.Find("Hatch (1)");
                bottom_vhs.Hatch = intHatch2.gameObject;
                bottom_vhs.ExitLocation = intHatch2.Find("ExitLocation");
                bottom_vhs.SurfaceExitLocation = intHatch2.Find("ExitLocation");
                bottom_vhs.EntryLocation = intHatch2.Find("EntryLocation");
                list.Add(bottom_vhs);

                return list;
            }
        }

        public override List<GameObject> TetherSources
        {
            get
            {
                var list = new List<GameObject>();
                foreach (Transform child in transform.Find("Tether-Sources"))
                {
                    list.Add(child.gameObject);
                }
                return list;
            }
        }

        public override GameObject Fabricator
        {
            get
            {
                return transform.Find("Fabricator-Location").gameObject;
            }
        }
        
        public override List<Light> InteriorLights
        {
            get
            {
                return null;
            }
        }

        public override GameObject ControlPanel
        {
            get
            {
                return null;
            }
        }

        public override GameObject ColorPicker
        {
            get
            {
                return null;
            }
        }

        public override bool HasArms => false;
        public override int NumModules => 4;
        public override int Mass => 250;
        public override int MaxHealth => 300;
        public override int BaseCrushDepth => 400;
        public override int CrushDepthUpgrade1 => 500;
        public override int CrushDepthUpgrade2 => 500;
        public override int CrushDepthUpgrade3 => 850;
        public override string Description => "Explore the deep with the Atlantic Explorer - modified to explore 4546b";
        public override string EncyclopediaEntry => "The Atlantic Explorer made by Aquaworks Industries for Alterra for the exploration of Planet 6886d in the undiscovered Julie Regions of the galaxy.\n" +
                                                    "Designed to be a tank to explore the depths of your words - Brought to you by Aquaworks\n" +
                                                    "This version of the Atlantic Explorer has been modified to explore 4546b\n" +
                                                    "\nNote: Alterra taxes AquaWorks at 5 credits per second of use - This tax will be payed by you.";

        public override Sprite EncyclopediaImage =>
            VehicleFramework.Assets.SpriteHelper.GetSpriteRaw("assets/encyclopedia_image.png");
        
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
                recipe.Add(TechType.AdvancedWiringKit, 1);
                recipe.Add(TechType.TitaniumIngot, 2);
                recipe.Add(TechType.Copper, 2);
                recipe.Add(TechType.Glass, 1);
                recipe.Add(TechType.Silver, 1);

                return recipe;
            }
        }
    }
}