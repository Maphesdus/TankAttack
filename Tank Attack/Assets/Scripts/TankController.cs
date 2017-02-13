using UnityEngine;

public class TankController : MonoBehaviour {
    public GameObject body;
    public GameObject turret;
    public GameObject barrel;
    public float tankTurnSpeed = 10.0f;
    public float tankMoveSpeed = 3.0f;
    public float turretRotateSpeed = 20.0f;
    public float barrelRotateSpeed = 10.0f;

    /*public static int HP = 100;
    public static int kills = 0;

    public int posX = 10;
    public int posY = 10;
    public int width = 150;
    public int height = 50;

    public GUISkin gui;*/

    // UPDATE:
    void Update() {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * tankTurnSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * tankMoveSpeed;
        var tx = Input.GetAxis("Turret") * Time.deltaTime * turretRotateSpeed;
        var by = Input.GetAxis("Barrel") * Time.deltaTime * barrelRotateSpeed;

        body.transform.Rotate(0, x, 0);
        body.transform.Translate(0, 0, z);
        turret.transform.Rotate(0, tx, 0);
        barrel.transform.Rotate(-by, 0, 0);
    }

    // ON GUI:
    /*void OnGUI() {
        GUI.skin = gui;
        GUI.Label(new Rect(posX, posY, width, height), "HP: " + HP);
        GUI.Label(new Rect(posX, posY + 35, width, height), "Kills: " + kills + "/3");
    }*/
}