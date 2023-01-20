using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPopUp1 : MonoBehaviour
{
    public GameObject PopUp;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("triggerBox"))
        { 
            
            PopUp.SetActive(true);
        }
       
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("triggerBox"))
        {

            PopUp.SetActive(false);
        }

    }
}
