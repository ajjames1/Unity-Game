using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatchFinish0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        Transform t = this.transform.parent.GetChild(0).transform;

        if (t)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, t.position, Time.deltaTime);
        }
    }
}
