namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class MakeFirstChild {
        [MenuItem("GameObject/Make first child", false, -5)]
        static void makeFirstChild(MenuCommand command) {
            var go = command.context as GameObject;
            if (go.transform.parent) {
                Undo.RegisterFullObjectHierarchyUndo(go.transform.parent, "Make first child");
                go.transform.SetAsFirstSibling();
            }
            else {
                go.transform.SetSiblingIndex(0);
            }
        }
    }
}