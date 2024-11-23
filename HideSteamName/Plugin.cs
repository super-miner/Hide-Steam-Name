using System.Linq;
using BepInEx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HideSteamName {
    [BepInPlugin(PluginInfo.PLUGIN_ID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin {
        private void Awake() {
            SceneManager.activeSceneChanged += (from, to) => {
                if (to.name == "Title Screen") {
                    HideSteamName(to);
                }
            };
        }

        private void HideSteamName(Scene titleScreenScene) {
            Transform titleScreenTransform = GetTransformByName("Title Screen", titleScreenScene.GetRootGameObjects());
            Transform uiTransform = GetChildByName("UI", titleScreenTransform);
            Transform steamNameTransform = GetChildByName("Steam Name", uiTransform);
            
            steamNameTransform.gameObject.SetActive(false);
        }

        private Transform GetTransformByName(string name, GameObject[] objects) {
            return objects.First(gameObject => gameObject.name == name).transform;
        }

        private Transform GetChildByName(string name, Transform parent) {
            for (int i = 0; i < parent.childCount; i++) {
                Transform child = parent.GetChild(i);

                if (child.name == name) {
                    return child;
                }
            }

            return null;
        }
    }
}