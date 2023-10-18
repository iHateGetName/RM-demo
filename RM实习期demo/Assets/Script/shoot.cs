using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        //这里的transform来自测速模块，看着像枪管
        projectilePrefab.transform.position = transform.position;
        projectilePrefab.transform.rotation = transform.rotation;
    }

    // Update is called once per frame

    void Update()
    {
        

        projectilePrefab.transform.position = transform.position;
        projectilePrefab.transform.rotation = transform.rotation;

        adjust_dir();
     
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fire(); //发射子弹
        }
    }
    public int up_down_adjust = 0;//调整枪口倾斜角度，从0到10。0为平射，800为向上27°射
    public void adjust_dir()
    {
        if (Input.GetKey(KeyCode.E) && up_down_adjust < 800)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * 5);
            up_down_adjust = up_down_adjust + 1;
            Debug.Log("抬高发射角度");
        }
        if (Input.GetKey(KeyCode.Q) && up_down_adjust > 0)
        {
            transform.Rotate(Vector3.left * Time.deltaTime * 5);
            up_down_adjust = up_down_adjust - 1;
            Debug.Log("降低发射角度");
        }
    }

    public void fire()
    {
        Vector3 adjust_pos = new Vector3(0f, 0.4f, 0.6f);
        Instantiate(projectilePrefab, projectilePrefab.transform.position + adjust_pos
            ,projectilePrefab.transform.rotation);
    }
}
