using UnityEngine;
using System.Collections;

public class houseExlode : MonoBehaviour {
    public int HP = 5;
    public GameObject houseRegular;
    public GameObject houseExploded;

    public GameObject explosion;
    public bool exploded = false;

    public AudioClip explodeClip;
    public AudioClip hitClip;
    AudioSource explodeSource;
    AudioSource hitSource;

    // Use this for initialization
    void Start () {
        explodeSource = GetComponent<AudioSource>();
        hitSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	    if (HP <= 0 && exploded== false) {
            explode();
        }
	}

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "bullet") {
            Debug.Log(HP);
            HP--;
            hitSource.Play();
        } 
    }

    // EXPLODE:
    void explode() {
        Debug.Log("EXPLODE!");
        Instantiate(explosion, this.transform.position, this.transform.rotation);
        exploded = true;
        explodeSource.Play();
        houseRegular.gameObject.SetActive(false);
        houseExploded.gameObject.SetActive(true);
    }
}