namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class ProjectSettings {
        [MenuItem("ProjectSettings/Settings")] 
        static void settings() {
            EditorApplication.ExecuteMenuItem("Edit/Settings");
        }

        [MenuItem("ProjectSettings/Preferences")] 
        static void preferences() {
            EditorApplication.ExecuteMenuItem("Edit/Preferences");
        }

        [MenuItem("ProjectSettings/Modules")] 
        static void modules() {
            EditorApplication.ExecuteMenuItem("Edit/Modules...");
        }

        [MenuItem("ProjectSettings/Snap Settings")] 
        static void snap() {
            EditorApplication.ExecuteMenuItem("Edit/Snap Settings...");
        }

        [MenuItem("ProjectSettings/Package Manager")] 
        static void packages() {
            EditorApplication.ExecuteMenuItem("Window/Package Manager");
        }
         
    }
}