# UnityEditorSnippets
Collection of different editor things that help with productivity


## Structure
Every snippet is in separate file.
All hotkeys are in Hotkey.cs file.

## Contents

**Editor**
* **Play** - quick play mode hotkey
* **Pause** 
* **Collapse Project** - collapses all contents of the project window
* **Collapse Hierarchy** - collapses hierarchy (scenes become uncollapsed, whoever works with multiscene fix this)

**GameObject** (found in gameobject context menu)
* **Create Parent** - creates parent for the selected gameobject in scene.
* **Make first child** - moves to the top of hierarchy under current parent
* **Make las child** - moves to the bottom of hierarchy under current parent
* **Move up one level** - parents to the parent of the parent.

**Component** (found in component context menu - gear icon)
* **Move to top** - moves the component to the top
* **Move to bottom** - moves the component to the bottom

More to come, feel free to add yours, just follow the same structure.

## FAQ
Q:

Correct me if I'm wrong, but how does this differer from the standard methods?
Play (CTRL-P) Pause (CTRL-SHIFT-P) Collapse (ALT-Click arrow) Create Parent (select objects, then Game Object/Make Parent)
Seems like this allready exists by default.

A:
1. Play and pause exist yes, however mine allows you to set hotkeys, like F1, F5, which are much more convenient than breaking your hands  with default hotkeys.
2. Collapse that you say requires you to click on a specific folder or and object, and doesnt collapse everything (everything). My hotkeys allow you to collapse completely all objects in Hierarchy, or all folders in Project window.
3. Make parent simply makes one object parent of another (try it yourself), mine creates a new object, places it at the same position as selected, and parents selected to it. 
