using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.forward * 1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.back * 1f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.left * 1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.right * 1f);
        }
    }
}
