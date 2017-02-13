using UnityEngine;
using System.Collections;

public class Tank_AI : MonoBehaviour {
    // AI VARIABLES
    private Transform Player;
    public int MoveSpeed = 4;
    public float ChaseDistance = 50.0f;
    public float AttackDistance = 25.0f;
    public GameObject bullet;
    public GameObject firepoint;

    public float waitTime = 0.5f;
    private float initialWaitTime = 0.0f;
    private float DistanceToPlayer;
    public int shootSpeed = 50;

    public int HP = 10;

    public AudioClip shootClip;
    public AudioClip hitClip;
    AudioSource shootSource;
    AudioSource hitSource;

    public GameObject TANK;
    public GameObject explosion;
    public GameObject debris;
    public bool dead = false;

    //float strength = .5f;
    //float str;
    //Quaternion targetRotation;

    // START:
    void Start() {
        shootSource = GetComponent<AudioSource>();
        hitSource = GetComponent<AudioSource>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        initialWaitTime = waitTime;
    } // END START()

    void Update() {
        DistanceToPlayer = Vector3.Distance(transform.position, Player.position);
        //targetRotation = Quaternion.LookRotation(Player.position - transform.position);
        //str = Mathf.Min(strength * Time.deltaTime, 1);

        if (DistanceToPlayer <= ChaseDistance && DistanceToPlayer >= AttackDistance) {
            transform.LookAt(Player);
            //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, str);
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, MoveSpeed * Time.deltaTime);
        } // END IF

        if (DistanceToPlayer <= AttackDistance) {
            transform.LookAt(Player);
            //shoot();

            waitTime -= Time.deltaTime;
            if (waitTime <= 0 && dead == false) {
                shootSource.Play();
                Instantiate(bullet, firepoint.transform.position, Quaternion.identity);
                waitTime = initialWaitTime;
            }
        } // END IF

        if (HP <= 0 && dead == false) {
            explode();
        }
    } // END UPDATE()

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "bullet") {
            Debug.Log(HP);
            HP--;
            hitSource.Play();
        } 
    }

    // EXPLODE:
    void explode() {
        dead = true;
        TANK.gameObject.SetActive(false);
        Instantiate(explosion, this.transform.position, this.transform.rotation);
        Instantiate(debris, this.transform.position, this.transform.rotation);
    }
}