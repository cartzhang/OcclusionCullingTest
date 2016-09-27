using UnityEngine;
using System.Collections;
using System.Reflection;
using System;

public class GetMonoVersion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        Type type = Type.GetType("Mono.Runtime");
        if (type != null)
        {
            MethodInfo displayName = type.GetMethod("GetDisplayName", BindingFlags.NonPublic | BindingFlags.Static);
            if (displayName != null)
                Debug.Log(displayName.Invoke(null, null));
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(System.Environment.Version);
    }
}
