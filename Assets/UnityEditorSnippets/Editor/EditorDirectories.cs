namespace UnityEditorSnippets
{
    using UnityEngine;
    using System;
    using System.Collections.Generic;
    using UnityEditor;
    using System.IO;
    using System.Diagnostics;

    public class EditorDirectories
    {
        [MenuItem("ProjectSettings/Directories/Script templates", false, -4)]
        static void openScriptTemplateDir()
        {
            string path = Directory.GetParent(EditorApplication.applicationPath) + "/Data/Resources/ScriptTemplates/";
            //UnityEngine.Debug.Log(path);
            Process.Start(path);
        }

        [MenuItem("ProjectSettings/Directories/Editor root", false, -4)]
        static void openEditorRoot()
        {
            Process.Start(Directory.GetParent(EditorApplication.applicationPath).ToString());
        }

        [MenuItem("ProjectSettings/Directories/Persistent data", false, -4)]
        static void openPersistentData()
        {
            Process.Start(Application.persistentDataPath);
        }
    }
}