using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Transform target;
    Vector3 offset = new Vector3(0, 1, -10);
    float range = 4f;
    float distance = 0;

	// Use this for initialization
	void Start () {

        transform.position = target.position + offset;
	}
	
	// Update is called once per frame
	void Update () {
        distance = transform.position.x - target.position.x;

        if (distance >= range) {
            
            transform.position = target.position + offset + new Vector3(range, 0, 0);
		} else if (distance <= -range) {
            
			transform.position = target.position + offset + new Vector3(-range, 0, 0);
        } else {
            
            transform.position = target.position + offset + new Vector3(distance, 0, 0);
		}
   	}
}
