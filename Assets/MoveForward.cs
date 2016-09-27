using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public float speed = 5;
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            this.transform.position += transform.forward * -speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            this.transform.position += transform.forward * speed * Time.deltaTime;
        }

    }
}
