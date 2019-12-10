namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class ProjectSettings {
        [MenuItem("ProjectSettings/Settings")] 
        static void settings() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings...");
        }

        [MenuItem("ProjectSettings/Preferences")] 
        static void preferences() {
            EditorApplication.ExecuteMenuItem("Edit/Preferences...");
        }

        [MenuItem("ProjectSettings/Shortcuts")]
        static void shortcuts()
        {
            EditorApplication.ExecuteMenuItem("Edit/Shortcuts...");
        }

        [MenuItem("ProjectSettings/Snap Settings")]
        static void snap()
        {
            EditorApplication.ExecuteMenuItem("Edit/Grid and Snap Settings...");
        }

        [MenuItem("ProjectSettings/Package Manager")]
        static void packages()
        {
            EditorApplication.ExecuteMenuItem("Window/Package Manager");
        }

        [MenuItem("ProjectSettings/Lighting")]
        static void lighting()
        {
            EditorApplication.ExecuteMenuItem("Window/Rendering/Lighting Settings");
        }

        [MenuItem("ProjectSettings/Profiler")]
        static void profiler()
        {
            EditorApplication.ExecuteMenuItem("Window/Analysis/Profiler");
        }

        [MenuItem("ProjectSettings/Navmesh")]
        static void navmesh()
        {
            EditorApplication.ExecuteMenuItem("Window/AI/Navigation");
        }

    }
}