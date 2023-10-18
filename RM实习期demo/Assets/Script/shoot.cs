using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        //�����transform���Բ���ģ�飬������ǹ��
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
            fire(); //�����ӵ�
        }
    }
    public int up_down_adjust = 0;//����ǹ����б�Ƕȣ���0��10��0Ϊƽ�䣬800Ϊ����27����
    public void adjust_dir()
    {
        if (Input.GetKey(KeyCode.E) && up_down_adjust < 800)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * 5);
            up_down_adjust = up_down_adjust + 1;
            Debug.Log("̧�߷���Ƕ�");
        }
        if (Input.GetKey(KeyCode.Q) && up_down_adjust > 0)
        {
            transform.Rotate(Vector3.left * Time.deltaTime * 5);
            up_down_adjust = up_down_adjust - 1;
            Debug.Log("���ͷ���Ƕ�");
        }
    }

    public void fire()
    {
        Vector3 adjust_pos = new Vector3(0f, 0.4f, 0.6f);
        Instantiate(projectilePrefab, projectilePrefab.transform.position + adjust_pos
            ,projectilePrefab.transform.rotation);
    }
}
