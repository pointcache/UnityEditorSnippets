namespace UnityEditorSnippets {
    using System.Collections;
    using System.Collections.Generic;
    using UnityEditor;
    using UnityEngine;

    public static class CreateParent {

        /// <summary>
        /// This method attempts to creat a parent for selected child, it is not perfect and can fail in some edge cases
        /// but is undoable in case of error, needs more work.
        /// </summary>
        [MenuItem(Hotkeys.SNIPPETS_ROOT_MENU + "CreateParent " + Hotkeys.CREATEPARENT)]
        public static void createParent() {
            var go = Selection.activeGameObject;
            if (go) {
                var parent = new GameObject(go.name + "_root");
                Undo.RegisterCreatedObjectUndo(parent, "Created parent");
                parent.transform.SetParent(go.transform.parent);
                var rect = go.GetComponent<RectTransform>();
                if (rect) {
                    var goparentrect = go.transform.parent.GetComponent<RectTransform>();
                    var parentCanvas = go.transform.parent.GetComponent<Canvas>();
                    var parentRect = parent.GetComponent<RectTransform>();
                    if (!parentRect)
                        parentRect = parent.AddComponent<RectTransform>();
                    if (!parentCanvas)
                        parentRect.position = goparentrect.transform.position;
                    else
                        parentRect.position = parentCanvas.transform.position;
                    parentRect.anchorMax = new Vector2(1f, 1f);
                    parentRect.anchorMin = Vector2.zero;
                    parentRect.offsetMax = Vector2.zero;
                    parentRect.offsetMin = Vector2.zero;
                }
                else {
                    parent.transform.position = go.transform.position;
                    parent.transform.rotation = go.transform.rotation;
                    go.transform.SetParent(parent.transform);
                }
                Undo.SetTransformParent(go.transform, parent.transform, "reparent");
            }
        }

    }
}