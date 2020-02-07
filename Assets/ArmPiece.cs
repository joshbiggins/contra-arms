using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmPiece : MonoBehaviour {
    public byte position; //Position in line
    public Transform armEnd; //End piece of limb
    public Transform armStart; //Start piece of limb
    public bool fixedLimb; //Is limb fixed?

    private float bend;
    private ArmEnd armEndScript;
    private byte numberOfPieces;
    private Vector3 originalVector;

	// Use this for initialization
	public void Init () {
        armEndScript = armEnd.gameObject.GetComponent<ArmEnd>();
        numberOfPieces = armEndScript.numberOfPieces;
        originalVector = armEnd.position - armStart.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (numberOfPieces > 0)
        {
            bend = armEndScript.bend;
            Vector3 armVector = armEnd.position - armStart.position;
            
            if(fixedLimb)
            {
                transform.position = Vector3.Lerp(armStart.position, armStart.position + originalVector, (float)position / numberOfPieces * 0.4f);
                transform.position = Vector3.Lerp(transform.position, armEnd.position, (float)position / numberOfPieces * 0.8f);
            }
            if (!fixedLimb)
            {
                Vector3 perpVector = new Vector3(armVector.y, armVector.x, 0.0f).normalized * bend;

                float distFromMiddle = Mathf.Abs((float)position - Mathf.Ceil((float)numberOfPieces / 2));
                if (distFromMiddle < 1)
                {
                    distFromMiddle = 0.9f;
                }

                perpVector = perpVector / distFromMiddle;

                transform.position = Vector3.Lerp(armStart.position, armEnd.position, (float)position / numberOfPieces * 0.8f);
                transform.position += perpVector;
            }
        }
	}
}
