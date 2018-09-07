using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speedMultiplier = 10f;
    public float rotationMultiplier = 150f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotationMultiplier;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speedMultiplier;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
