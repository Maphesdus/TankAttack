using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
    public Material mat;
    public Material outline;

    void OnMouseOver() {
        GetComponent<Renderer>().material = outline;
    }

    void OnMouseExit() {
        GetComponent<Renderer>().material = mat;
    }
}