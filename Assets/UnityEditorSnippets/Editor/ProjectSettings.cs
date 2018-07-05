namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class ProjectSettings {
        [MenuItem("ProjectSettings/Input")] 
        static void input() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Input");
        }

        [MenuItem("ProjectSettings/Tags and Layers")] 
        static void tags() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Tags and Layers");
        }

        [MenuItem("ProjectSettings/Audio")] 
        static void audio() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Audio");
        }

        [MenuItem("ProjectSettings/Time")] 
        static void time() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Time");
        }
         
        [MenuItem("ProjectSettings/Player")] 
        static void player() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Player");
        }

        [MenuItem("ProjectSettings/Physics")] 
        static void physics() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Physics");
        }

        [MenuItem("ProjectSettings/Physics 2D")] 
        static void physics2d() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Physics 2D");
        }

        [MenuItem("ProjectSettings/Quality")] 
        static void quality() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Quality");
        }

        [MenuItem("ProjectSettings/Graphics")] 
        static void graphics() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Graphics");
        }

        [MenuItem("ProjectSettings/Network")] 
        static void network() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Network");
        }

        [MenuItem("ProjectSettings/Editor")] 
        static void editor() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Editor");
        }

        [MenuItem("ProjectSettings/Script Execution Order")] 
        static void seo() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Script Execution Order");
        }

        [MenuItem("ProjectSettings/Preset Manager")] 
        static void presets() {
            EditorApplication.ExecuteMenuItem("Edit/Project Settings/Preset Manager");
        }

    }
}