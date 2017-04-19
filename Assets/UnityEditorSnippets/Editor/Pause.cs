namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class Pause {
        [MenuItem("Edit/Run "+ Hotkeys.PAUSE)] // shortcut key F5 to Play (and exit playmode also)
        static void PauseGame() {
            EditorApplication.ExecuteMenuItem("Edit/Pause");
        }
    }
}