using UnityEngine;
using UnityEditor;
using System.Collections;

public class MakePrefab : MonoBehaviour {
	
	[MenuItem ("Project Tools/Make Prefab")]
	static void CreatePrefab(){
		
		GameObject [] selectedObjects = Selection.gameObjects;
		
		foreach (GameObject go in selectedObjects){
			string name = go.name;
			string localPath = "Assets/"+name+".prefab";
			if(AssetDatabase.LoadAssetAtPath(localPath, typeof(GameObject))){ 
				if (EditorUtility.DisplayDialog("Initial prefab found.", "Would you like to replace this prefab?", "Sure", "Nope")){
					createNew(go, localPath);
				}
			}else{	
				createNew(go, localPath);
			}
		}
		
		AssetDatabase.Refresh();
	}
	
	static GameObject createNew(GameObject go, string localPath){		
		Object prefab = PrefabUtility.CreateEmptyPrefab(localPath);
		PrefabUtility.ReplacePrefab(go, prefab);
		
		DestroyImmediate(go);
		
		return PrefabUtility.InstantiatePrefab(prefab) as GameObject;
	}
}