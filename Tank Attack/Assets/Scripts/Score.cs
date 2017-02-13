using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    public int HP = 100;
    public int kills = 0;

    public int posX = 10;
    public int posY = 10;
    public int width = 150;
    public int height = 50;

    public GUISkin gui;

    public AudioClip hitClip;
    AudioSource hitSource;

    public GameObject explosion;
    public GameObject debris;

    // START:
    void Start () {
        //posX = Screen.width / 2;
        hitSource = GetComponent<AudioSource>();
    }
	
	// UPDATE:
	void Update () {
	    if (HP <= 0) {
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            Instantiate(debris, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
	}

    // ON GUI:
    void OnGUI() {
        GUI.skin = gui;
        GUI.Label(new Rect(posX, posY, width, height), "HP: " + HP);
        GUI.Label(new Rect(posX, posY + 35, width, height), "Kills: " + kills + "/3");
    }

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "bullet") {
            Debug.Log(HP);
            HP--;
            hitSource.Play();
        } 
    }
}