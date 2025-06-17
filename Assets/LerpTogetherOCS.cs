using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTogetherOCS : MonoBehaviour
{

    [SerializeField] private Engine_UI_Power engine;

    public int name = 0;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

        name = int.Parse(this.transform.name) - 1;
    }



    // Update is called once per frame
    void Update()
    {

        Transform t = this.transform.parent.GetChild(name + 1).transform;

        if (t && engine.running)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, t.position, Time.deltaTime * speed);
        }
    }
}
