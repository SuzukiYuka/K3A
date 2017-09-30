using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    // public
    public Text coinLabel;

    // private
    float speed = 5.0f;
    float jumpSpeed = 200f;
    float groundLine = 20.0f;
    float jumpPower = 400.0f;
    int coinCount = 0;

    Animator animator;

    void Start() {

        animator = GetComponent<Animator>();
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

    }

    void Update() {

        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        if (Input.GetKeyDown(KeyCode.Space)) {

            animator.SetBool("Jump", true);
        } else {

            animator.SetBool("Jump", false);
        }


        if (transform.position.y <= -groundLine) {

            SceneManager.LoadScene("GameOver");
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit) {

        if (hit.gameObject.CompareTag("Coin")) {

            Destroy(hit.gameObject);
            coinCount++;
            coinLabel.text = coinCount.ToString();
        }
    }
}
