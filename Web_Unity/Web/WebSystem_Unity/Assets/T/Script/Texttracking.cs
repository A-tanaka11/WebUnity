using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texttracking : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        GameObject MainCamera = GameObject.Find("Main Camera");
        Vector3 cameraPosition = new Vector3(MainCamera.transform.position.x, MainCamera.transform.position.y, MainCamera.transform.position.z);

        transform.LookAt(cameraPosition);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
