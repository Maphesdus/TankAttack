using UnityEngine;
using System.Collections;

public class hideCursor : MonoBehaviour {
    public bool hide = true;
    void Start () {
        if (hide) Cursor.visible = false;
    }
}