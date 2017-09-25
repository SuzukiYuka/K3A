using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    float speed = 5.0f;
    float groundLine = 20.0f;
    float jumpPower = 400.0f;
    Rigidbody playerRigidBody;
    int jumpCount = 0;

    void Start() {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    void Update() {

        if (Input.GetKey(KeyCode.RightArrow)) {

            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {

            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {

            if (jumpCount < 1) {
                Debug.Log(jumpCount);
                jumpCount += 1;
                playerRigidBody.AddForce(Vector3.up * jumpPower);
            }
        }

        if (transform.position.y <= -groundLine) {

            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag == "Stage") {
            Debug.Log("Stageにぶつかった");
            jumpCount = 0;
        }
    }

}
