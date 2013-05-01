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
				Debug.Log("Don't create");
			}else{	
				createNew(go, localPath);
			}
		}
		
		AssetDatabase.Refresh();
	}
	
	static void createNew(GameObject go, string localPath){		
		Object prefab = PrefabUtility.CreateEmptyPrefab(localPath);
		PrefabUtility.ReplacePrefab(go, prefab);
	}
}
