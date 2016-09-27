using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class IsRenderByCamera : MonoBehaviour
{
    private Renderer rend;
	// Use this for initialization
	void Start ()
    {
        rend = this.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        //if (rend.IsVisibleFrom(Camera.main))
        //{
        //    Debug.Log("visible by main camera");
        //}
        //else
        //{
        //    Debug.Log("not visible by any camera");
        //}

        //if (rend.IsVisibleFrom(Camera.main)) Debug.Log("Visible");
        //else Debug.Log("Not visible");

        if (rend.isVisible)
        {
            Debug.LogError("red cube is Visible");
        }
        else
        {
            Debug.LogError("red cube not Visible"); ;
        }

        if (Camera.main.useOcclusionCulling)
        {
            Debug.Log("currrent occluson is using");
        }    
    }

    void OnWillRenderObject()
    {
        //Debug.Log("will render ");
    }


    void OnBecameVisible()
    {
        //Debug.Log("became Visible");
    }

    void OnBecameInvisible()
    {
        //Debug.Log("became InVisible");
    }


}



public static class RendererExtensions
{
    public static bool IsVisibleFrom(this Renderer renderer, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
    }
}

