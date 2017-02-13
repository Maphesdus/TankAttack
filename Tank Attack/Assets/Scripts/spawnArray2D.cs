using UnityEngine;
using System.Collections;

public class spawnArray2D : MonoBehaviour {
    public Transform prefab;

    public float spacing = 15;
    public float height = 10;
    public int max = 50;

    private float rnd = 0;


    // START:
    void Start() {
        for (int z = 0; z < max; z++) {
            for (int x = 0; x < max; x++) {
                rnd = Random.Range(-10.0f, 1.0f);

                Instantiate(prefab, new Vector3((x + rnd) * spacing, height, (z + rnd) * spacing), Quaternion.identity);
            }
        }
    }
	
	// UPDATE:
	void Update () {
	
	}
}
