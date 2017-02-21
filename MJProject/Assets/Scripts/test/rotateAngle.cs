using UnityEngine;
using System.Collections;

public class rotateAngle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(transform.position + new Vector3(0,0.018f,0) ,Vector3.right ,Time.deltaTime *10f);
	}
}
