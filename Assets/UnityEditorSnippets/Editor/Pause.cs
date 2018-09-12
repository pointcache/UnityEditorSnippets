namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class Pause {
        [MenuItem("Edit/PauseHotkey "+ Hotkeys.PAUSE)] 
        static void PauseGame() {
            EditorApplication.ExecuteMenuItem("Edit/Pause");
        }
    }
}