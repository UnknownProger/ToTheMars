using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetsController : MonoBehaviour {

    [Header("Earth")]
    public Transform earth;
    public float earthSpeed;
    [Header("Moon")]
    public Transform moon;
    public float moonSpeed;
    [Header("Mars")]
    public Transform mars;
    public float marsSpeed;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        earth.Rotate(Vector3.up, earthSpeed * Time.deltaTime);

        moon.RotateAround(earth.position, Vector3.forward + Vector3.right, moonSpeed * Time.deltaTime); 
		
	}
}
