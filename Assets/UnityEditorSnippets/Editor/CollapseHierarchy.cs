namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using UnityEditor;
    using UnityEditor.SceneManagement;

    public static class CollapseHierarchy {
        [MenuItem("Edit/Collapse Hierarchy " + Hotkeys.COLLAPSE_HIERARCHY)]
        static void collapseHierarchy() {

            string assemblypath = UnityEditorInternal.InternalEditorUtility.GetEditorAssemblyPath();
            var assembly = System.Reflection.Assembly.LoadFrom(assemblypath);

            // Find static hierarchy window controller
            var type = assembly.GetType("UnityEditor.SceneHierarchyWindow");

            // Find last used hierarchy window
            var hierarchyfield = type.GetField("s_LastInteractedHierarchy", BindingFlags.NonPublic | BindingFlags.Static);
            var hierarchy = hierarchyfield.GetValue(type);

            // Find scene view inside hierarchy window
            var hierarchyType = hierarchy.GetType();
            var sceneviewfield = hierarchyType.GetField("m_SceneHierarchy", BindingFlags.NonPublic | BindingFlags.Instance);
            var sceneview = sceneviewfield.GetValue(hierarchy);
            var sceneviewType = sceneview.GetType();

            var treestatefield = sceneviewType.GetField("m_TreeViewState", BindingFlags.Instance | BindingFlags.NonPublic);
            var treestate = treestatefield.GetValue(sceneview);
            var expandedIdsField = treestate.GetType().GetField("m_ExpandedIDs", BindingFlags.Instance | BindingFlags.NonPublic);

            expandedIdsField.SetValue(treestate, new List<int>());

            List<string> openscenes = new List<string>();

            for (int i = 0; i < EditorSceneManager.sceneCount; i++) {
                openscenes.Add(EditorSceneManager.GetSceneAt(i).name);
            }

            var reloadneeded = sceneviewType.GetField("m_TreeViewReloadNeeded", BindingFlags.NonPublic | BindingFlags.Instance);

            sceneviewType.InvokeMember("SetScenesExpanded",
                BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                sceneview,
                new object[1] {openscenes });

            reloadneeded.SetValue(sceneview, true);

            sceneviewType.InvokeMember("SyncIfNeeded", BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic, null, sceneview, null);
            
        }
    }
}