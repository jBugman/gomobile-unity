using UnityEngine;
using System.Collections;

public class PluginTest : MonoBehaviour {

	void Start () {
		AndroidJavaClass jc = new AndroidJavaClass("go.golib.Golib"); 
		Debug.Log(jc);
		var result = jc.CallStatic<string>("Hello", "World!");
		Debug.Log(result);
	}
}
