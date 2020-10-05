using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venue : MonoBehaviour
{
    [SerializeField]
    private string VenueName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string Name
    {
        get { return VenueName; }
        set { VenueName = value;}
    }
}
