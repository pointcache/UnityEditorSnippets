namespace UnityEditorSnippets {
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;

    public class MoveToTop {
        [MenuItem("CONTEXT/Component/Move to top")]
        static void moveToTop(MenuCommand command) {
            for (int i = 0; i < 100; i++) {
                UnityEditorInternal.ComponentUtility.MoveComponentUp(command.context as Component);
            }
        }
    }
}