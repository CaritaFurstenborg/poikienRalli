using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamStabile : MonoBehaviour {

    [SerializeField]
    private GameObject theCar;

    private float CamX, CamY, CamZ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CamX = theCar.transform.eulerAngles.x;
        CamY = theCar.transform.eulerAngles.y;
        CamZ = theCar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CamX - CamX, CamY, CamZ - CamZ);
	}
}
