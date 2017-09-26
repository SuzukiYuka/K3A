using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    float speed = 5.0f;
    float jumpSpeed = 200f;
    float groundLine = 20.0f;
    float jumpPower = 400.0f;
    Rigidbody playerRigidBody;
    int jumpCount = 0;
    int coinCount = 0;

    private bool isJump {
        
        get { return jumpCount != 0; }
    }

    public Text coinLabel;



    void Start() {

        playerRigidBody = GetComponent<Rigidbody>();
    }

    void Update() {

        if (Input.GetKey(KeyCode.D)) {

            if (!isJump){

                playerRigidBody.velocity = new Vector3(speed, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.A)) {

            if (!isJump) {

                playerRigidBody.velocity = new Vector3(-speed, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)) {

            if (!isJump) {

                jumpCount += 1;
                playerRigidBody.AddForce(Vector3.up * jumpPower);
            }
        }

        if (Input.GetKeyDown(KeyCode.D)) {

            if (isJump) {

                playerRigidBody.AddForce(Vector3.right * jumpSpeed);
            }
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            if (isJump) {

                playerRigidBody.AddForce((Vector3.left * jumpSpeed));
            }
        }

        if (transform.position.y <= -groundLine) {

            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.CompareTag("Stage")) {

            jumpCount = 0;
        }

        if (collision.gameObject.CompareTag("Coin")) {

            coinCount++;
            coinLabel.text = coinCount.ToString();
            Destroy(collision.collider.gameObject);
        }
    }

}
