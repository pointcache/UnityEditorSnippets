namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class MoveToBottom {
        [MenuItem("CONTEXT/Component/Move to bottom")]
        static void moveToBottom(MenuCommand command) {
            for (int i = 0; i < 100; i++) {
                UnityEditorInternal.ComponentUtility.MoveComponentDown(command.context as Component);
            }
        }
    }
}