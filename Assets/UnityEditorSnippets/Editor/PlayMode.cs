namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class PlayMode {
        [MenuItem("Edit/Run " + Hotkeys.PLAYMODE)] 
        static void playMode() {
            EditorApplication.ExecuteMenuItem("Edit/Play");
        }
    }
}