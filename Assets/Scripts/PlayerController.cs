using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    float speed = 10.0f;
    float groundLine = 20.0f;

    void Start() {

    }

    void Update() {

        if (Input.GetKey(KeyCode.RightArrow)) {

            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {

            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow)) {

            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }

        if (transform.position.y <= -groundLine) {

            SceneManager.LoadScene("GameOver");
        }
    }
}
