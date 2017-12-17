using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformation : MonoBehaviour {
    public float minimum = 10.0F;
    public float maximum = 20.0F;
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        transform.localScale = new Vector3(Mathf.PingPong(Time.time*1000, maximum - minimum) + minimum, Mathf.PingPong(Time.time * 1000, maximum - minimum) + minimum,Mathf.PingPong(Time.time * 1000, maximum - minimum) + minimum);

    }
}
