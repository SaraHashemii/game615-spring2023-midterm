using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float speed = 1f;
    public GameObject endPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z <= endPos.transform.position.z)
        {
            gameObject.transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
        }
        
       
    }
}
