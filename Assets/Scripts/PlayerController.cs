using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    float speed = 5.0f;
    float jumpSpeed = 200f;
    float groundLine = 20.0f;
    float jumpPower = 400.0f;
    int jumpCount = 0;
    int coinCount = 0;

    Animator animator;

    bool isJump {

        get { return jumpCount != 0; }
    }

    void Start() {

        animator = GetComponent<Animator>();
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Space)) {

            if (!isJump) {

                jumpCount += 1;
                animator.SetBool("Jump", true);
            }
        } else {

            animator.SetBool("Jump", false);
        }


        if (transform.position.y <= -groundLine) {

            SceneManager.LoadScene("GameOver");
        }
    }
}
