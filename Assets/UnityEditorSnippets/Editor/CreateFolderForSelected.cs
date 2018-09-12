namespace UnityEditorSnippets
{

    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;
    using System.Linq;
    using System.IO;

    public static class CreateFolderForSelected
    {

        [MenuItem("Assets/Make folder for")]
        static void createFolderForSelected()
        {

            var target = Selection.activeObject;

            string path = AssetDatabase.GetAssetOrScenePath(target);
            string ext = Path.GetExtension(path);
            string parentDir = path.Remove(path.LastIndexOf('/'));
            string newpath = path.Remove(path.LastIndexOf('.')) + "/" + target.name + ext;

            AssetDatabase.CreateFolder(parentDir, target.name);

            if (AssetDatabase.ValidateMoveAsset(path, newpath) == string.Empty)
            {
                AssetDatabase.MoveAsset(path, newpath);
                Debug.Log("Made folder for and moved asset:" + newpath);
            }

        }

    }
}