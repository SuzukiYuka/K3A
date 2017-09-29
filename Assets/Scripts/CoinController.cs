using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("aaaaa");
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("bbbb");
    }
}
