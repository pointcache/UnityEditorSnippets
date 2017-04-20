namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class MoveUp {
        [MenuItem("GameObject/Move up", false, -4)]
        static void moveUp(MenuCommand command) {
            var go = command.context as GameObject;
            if (go.transform.parent) {
                Undo.RegisterFullObjectHierarchyUndo(go.transform.parent, "Move up");
                var index = go.transform.GetSiblingIndex();
                go.transform.SetSiblingIndex(index > 0 ? index - 1 : index);
            }
            else {
                var index = go.transform.GetSiblingIndex();
                go.transform.SetSiblingIndex(index > 0 ? index - 1 : index);
            }
        }
    }
}