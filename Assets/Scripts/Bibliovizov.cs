using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class Bibliovizov : MonoBehaviour {

	void Start () {
		
	}
    [DllImport("Biblioteka")]
    private static extern int answer();

	void Update () {
        Debug.Log(answer());
	}

    void OnGUI()
    {
        float fps = 1.0f / Time.deltaTime + answer();
        GUILayout.Label("FPS + 42 = " + fps);
    }
}
