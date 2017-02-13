using UnityEngine;
using System.Collections;

public class destroyThis : MonoBehaviour {
    public float seconds = 3.0f;

	void Start () {
        Destroy(gameObject, seconds);
    }
}