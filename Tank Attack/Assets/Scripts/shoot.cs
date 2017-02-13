using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
    public Rigidbody projectile;
    public Transform Spawnpoint;
    public int shootSpeed;

    public AudioClip shootClip;
    AudioSource shootSource;

    // START:
    void Start () {
        shootSource = GetComponent<AudioSource>();
    }
	
	// UPDATE:
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            shootSource.Play();
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, projectile.rotation);
            clone.velocity = Spawnpoint.TransformDirection(Vector3.forward*shootSpeed);
        }
	} // END UPDATE
} // END CLASS SHOOT