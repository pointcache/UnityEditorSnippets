namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class MakeLastChild {
        [MenuItem("GameObject/Make last child", false, -5)]
        static void makeLastChild(MenuCommand command) {
            var go = command.context as GameObject;
            Undo.RegisterFullObjectHierarchyUndo(go.transform.parent, "Make last child");
            go.transform.SetAsLastSibling();
        }
    }
}