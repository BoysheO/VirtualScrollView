using System;
using UnityEditor;
using UnityEditor.Experimental;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Scripts_Normal.UGUIExtern.VirtualScrollView.Editor
{
    public static class VirtualScrollViewMenu
    {
        private const string PrefabPath = "VitualScrollView";

        [MenuItem("GameObject/UI/Virtual Scroll View", priority = 0)]
        private static void AddComponent()
        {
            var activeTransform = Selection.activeTransform;
            var obj = Resources.Load<GameObject>(PrefabPath);
            if (obj == null) throw new Exception($"missing prefab {PrefabPath}");
            var clone = activeTransform == null ? Object.Instantiate(obj) : Object.Instantiate(obj, activeTransform);
            clone.name = obj.name;
            Selection.activeObject = clone;
        }
    }
}