using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Engine_UI_Power : MonoBehaviour
{
    public bool running = false;
    [SerializeField] private TMP_InputField t;
    private string ocsCmd = "";
    private string[] cmds = { "ocs_grid_init_pw1", "ocs_grid_init_pw0", "ocs_grid_swap ", "ocs_bin ", "ocs_root_spd: " };
    [SerializeField] private GameObject[] rails;
    private int cmdIndex = 0;

    

    private bool run = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        run = Input.GetKeyDown(KeyCode.Return);

        if (t.text.Length > 0)
        {
            ocsCmd = t.text;
        }

        if (cmds[0].Contains(ocsCmd) && run) {
            running = true;
        }
        else if(cmds[1].Contains(ocsCmd) && run) {
            running = false;
        }


        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            cmdIndex++;
            if(cmdIndex > cmds.Length - 1)
            {
                cmdIndex = cmds.Length - 1;
            }

            t.text = cmds[cmdIndex];
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            cmdIndex--;
            if (cmdIndex < 0)
            {
                cmdIndex = 0;
            }

            t.text = cmds[cmdIndex];
        }

        if (ocsCmd.Contains(cmds[2]) && run)
        {
            
            int mat4rx = Random.Range(1, 59);
            string temp = ocsCmd;
            string argv = temp.Replace(cmds[2], "");
            GameObject.Find(argv).GetComponent<LerpTogetherOCS>().name = mat4rx;


        }


        if (ocsCmd.Contains(cmds[3]) && run)
        {

            string temp = ocsCmd;
            string argv = temp.Replace(cmds[3], "");
            GameObject.Find(argv).gameObject.SetActive(false);


        }


        if (ocsCmd.Contains(cmds[4]) && run)
        {

            string temp = ocsCmd;
            int argv = int.Parse(temp.Replace(cmds[4], ""));
            
            for(int i=0; i<rails.Length; i++)
            {
                rails[i].GetComponent<LerpTogetherOCS>().speed = argv;
            }


        }

    }
}
