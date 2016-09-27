using UnityEngine;
using System.Collections;

public class Setposition : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        transform.position = Vector3.zero;
	}

    public float speed = 5;
	// Update is called once per frame
    [ExecuteInEditMode]
	void Update ()
    {
        //if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        //{
        //    this.transform.position += transform.up * -speed* Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        //{
        //    this.transform.position += transform.up * speed * Time.deltaTime;
        //}
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.transform.position += transform.right * -speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.position += transform.right * speed * Time.deltaTime;
        }

    }
}
