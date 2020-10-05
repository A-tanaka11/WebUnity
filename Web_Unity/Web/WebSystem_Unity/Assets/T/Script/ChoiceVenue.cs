using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceVenue : MonoBehaviour
{
    [SerializeField]
    private GameObject message;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "door")
        {
            SceneManager.LoadScene("VenueScene");
            
        }

        if (collision.gameObject.name == "door1")
        {
            //SceneManager.LoadScene("VenueScene");
           
        }

        if (collision.gameObject.name == "door2")
        {
            //SceneManager.LoadScene("VenueScene");
           
        }

        if (collision.gameObject.name == "door3")
        {
            //SceneManager.LoadScene("VenueScene");
            
        }
    }
}
