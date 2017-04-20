namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class MoveUpOneLevel {
        [MenuItem("GameObject/Move up one level", false, -4)]
        static void moveUpOneLevel(MenuCommand command) {
            var go = command.context as GameObject;
            Transform parent = go.transform.parent;
            if(parent != null) {
                 Undo.SetTransformParent(go.transform, parent.parent, "Move up one level");
            }
        }
    }
}