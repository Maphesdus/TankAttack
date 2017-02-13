using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    private float randomColorR;
    private float randomColorG;
    private float randomColorB;
    private int intensity = 5;
    private bool isGrounded = true;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.left * intensity;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow)) {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * intensity;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow)) {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.forward * intensity;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.back * intensity;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (isGrounded) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.up * intensity;
                isGrounded = false;
            }

            if (Input.GetKeyUp(KeyCode.Space)) {
                this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            myFunction();
        }
    }// END UPDATE

    void myFunction() {
        randomColorR = Random.Range(0f, 1f);
        randomColorG = Random.Range(0f, 1f);
        randomColorB = Random.Range(0f, 1f);
        this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(randomColorR, randomColorG, randomColorB, 1);
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Ground") {
            isGrounded = true;
        }
    }
}
