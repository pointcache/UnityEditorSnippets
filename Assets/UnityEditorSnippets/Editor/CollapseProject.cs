namespace UnityEditorSnippets {

    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;
    using System.Linq;

    public static class CollapseProject {

        [MenuItem("Edit/Collapse Project " + Hotkeys.COLLAPSE_PROJECT)] // shortcut key F5 to Play (and exit playmode also)
        static void collapseProject() {
            string assemblypath = UnityEditorInternal.InternalEditorUtility.GetEditorAssemblyPath();
            var assembly = System.Reflection.Assembly.LoadFrom(assemblypath);
            var type = assembly.GetType("UnityEditor.ProjectBrowser");
            var projectbrowserfield = type.GetField("s_LastInteractedProjectBrowser");
            var projectbrowser = projectbrowserfield.GetValue(type);
            var treestatefield = type.GetField("m_AssetTreeState", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var treestate = treestatefield.GetValue(projectbrowser);
            var expandedIdsField = treestate.GetType().GetProperty("expandedIDs", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public );
            UnityEditorInternal.InternalEditorUtility.expandedProjectWindowItems = new int[0];
            expandedIdsField.SetValue(treestate, new List<int>(), null);
            type.InvokeMember("OnProjectChanged", System.Reflection.BindingFlags.InvokeMethod | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, projectbrowser, null);
        }

    }
}