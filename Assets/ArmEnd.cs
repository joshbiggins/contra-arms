using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmEnd : MonoBehaviour {

    public byte numberOfPieces; //Number of pieces in limb
    public Transform armStart; //Start piece (transform) of limb
    public GameObject armPiece; //Prefab for middle pieces of limb
    public float bend; //Amount limb should bend outwards

    private Vector3 target;

    // Use this for initialization
    void Start () {
        target = transform.position;
        for(byte i = 1; i <= numberOfPieces; i++)
        {
            ArmPiece piece = GameObject.Instantiate(armPiece).GetComponent<ArmPiece>();
            piece.armEnd = transform;
            piece.armStart = armStart;
            piece.position = i;
            piece.Init();
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButton(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
            transform.position = target;
        }
	}

}
