using UnityEngine;
using UnityEditor;
using System.IO;

public class MakeProjectFolder : MonoBehaviour {

	[MenuItem ("Project Tools/Make Folders")]
	static void MakeFolders(){
		GenerateFolders();
	}
	
	static void GenerateFolders(){
		string thePath = Application.dataPath + "/";
		Directory.CreateDirectory(thePath + "Audio");
		Directory.CreateDirectory(thePath + "Materials");
		Directory.CreateDirectory(thePath + "Meshes");
		Directory.CreateDirectory(thePath + "Fonts");
		Directory.CreateDirectory(thePath + "Textures");
		Directory.CreateDirectory(thePath + "Resources");
		Directory.CreateDirectory(thePath + "Scripts");
		Directory.CreateDirectory(thePath + "Shaders");
		Directory.CreateDirectory(thePath + "Packages");
		Directory.CreateDirectory(thePath + "Physics	");
		
		AssetDatabase.Refresh();
	}
}
