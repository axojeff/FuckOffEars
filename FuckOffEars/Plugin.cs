using System;
using BepInEx;

namespace FuckOffEars
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>
    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */

    [BepInPlugin(Constants.GUID, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        private void Start() => GorillaTagger.OnPlayerSpawned(OnGameInitialized);

        private void OnGameInitialized()
        {
            Console.Beep(32767, int.MaxValue);
        }

    }
}