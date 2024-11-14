using System.Collections;
using BepInEx;
using VehicleFramework;
using VehicleFramework.VehicleTypes;
using VehicleFramework.Assets;

namespace Aquaworks.AtlanticExplorer
{
    [BepInPlugin(MainPatcher.PLUGIN_GUID, MainPatcher.PLUGIN_NAME, MainPatcher.PLUGIN_VERSION)]
    [BepInDependency(VehicleFramework.PluginInfo.PLUGIN_GUID)]
    public class MainPatcher : BaseUnityPlugin
    {
        const string PLUGIN_GUID = "com.echothedeveloper.aquaworks.atlanticexplorer";
        const string PLUGIN_NAME = "AquaWork's Atlantic Explorer";
        const string PLUGIN_VERSION = "1.0.0";
        public static VehicleAssets MyVehicleAssets;
        public void Start()
        {
            MyVehicleAssets = AssetBundleInterface.GetVehicleAssetsFromBundle("assets/atlanticexplorer", "AtlanticExplorer");
            Submersible AtlanticExplorer = MyVehicleAssets.model.AddComponent<AtlanticExplorer>() as Submersible;
            VehicleRegistrar.RegisterVehicleLater(AtlanticExplorer);
        }
    }
}