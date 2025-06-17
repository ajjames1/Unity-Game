using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineer : MonoBehaviour
{
    private float speed = 10.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed * Input.GetAxis("Vertical");
        transform.Rotate(0, Input.GetAxis("Mouse X") * 3, 0);
    }
}
