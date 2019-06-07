using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public float moveSpeed = 10;
    public float rotSpeed = 10;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        float z = Input.GetAxis( "Vertical" ) * moveSpeed;
        float y = Input.GetAxis( "Horizontal" ) * rotSpeed;

        transform.Translate( 0, 0, z );
        transform.Rotate( 0, y, 0 );
    }
}
