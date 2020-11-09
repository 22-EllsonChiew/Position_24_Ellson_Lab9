using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CordText : MonoBehaviour
{
    public GameObject Position;
    

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        Position.GetComponent<Text>().text = "Position: " + GameObject.FindGameObjectWithTag("Player").transform.position; 

    }

}
