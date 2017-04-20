namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class MoveDown {
        [MenuItem("GameObject/Move down", false, -4)]
        static void moveDown(MenuCommand command) {
            var go = command.context as GameObject;
            if (go.transform.parent) {
                Undo.RegisterFullObjectHierarchyUndo(go.transform.parent, "Move down");
                var index = go.transform.GetSiblingIndex();
                go.transform.SetSiblingIndex(index < go.transform.parent.childCount ? index + 1 : index);
            }
            else {
                var index = go.transform.GetSiblingIndex();
                go.transform.SetSiblingIndex(index + 1);
            }
        }
    }
}