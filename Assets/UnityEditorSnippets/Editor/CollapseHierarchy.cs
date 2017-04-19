namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;
    using UnityEditor.SceneManagement;

    public static class CollapseHierarchy {
        [MenuItem("Edit/Collapse Hierarchy " + Hotkeys.COLLAPSE_HIERARCHY)]
        static void collapseHierarchy() {

            string assemblypath = UnityEditorInternal.InternalEditorUtility.GetEditorAssemblyPath();
            var assembly = System.Reflection.Assembly.LoadFrom(assemblypath);
            var type = assembly.GetType("UnityEditor.SceneHierarchyWindow");
            var browserfield = type.GetField("s_LastInteractedHierarchy", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static);
            var browser = browserfield.GetValue(type);
            var treestatefield = type.GetField("m_TreeViewState", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var treestate = treestatefield.GetValue(browser);
            var expandedIdsField = treestate.GetType().GetField("m_ExpandedIDs", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);

            expandedIdsField.SetValue(treestate, new List<int>());
            List<string> openscenes = new List<string>();
            for (int i = 0; i < EditorSceneManager.sceneCount; i++) {
                openscenes.Add(EditorSceneManager.GetSceneAt(i).name);
            }


            var reloadneeded = type.GetField("m_TreeViewReloadNeeded", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            type.InvokeMember("SetScenesExpanded", System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, browser, new object[1] {openscenes });
            reloadneeded.SetValue(browser, true);
            type.InvokeMember("SyncIfNeeded", System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, browser, null);


        }
    }
}