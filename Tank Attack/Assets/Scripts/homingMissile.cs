using UnityEngine;
using System.Collections;

public class homingMissile : MonoBehaviour {
    public int MoveSpeed = 50;
    private GameObject Player;

    // START:
    void Start() {        
        Player = GameObject.FindGameObjectWithTag("Player");
        Destroy(gameObject, 3);
    } // END START

    // UPDATE:
    void Update() {
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, MoveSpeed * Time.deltaTime);
    } // END UPDATE
} // END CLASS homingMissile