using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class sentry_shoot : MonoBehaviour
{
    public GameObject player;
    public GameObject bullet_prefab;
    private float startDelay = 2;
    private float spawnInterval = 0.5f;


    private Vector3 standard_position;
    private Vector3 sentry_position;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("auto_shoot", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        standard_position = player.transform.position;
        sentry_position = transform.position;
        Vector3 pos_angle_x = sentry_position.x - standard_position.x;
        Vector3 pos_angle_y = sentry_position.y - standard_position.y;
        Vector3 pos_angle_z = sentry_position.z - standard_position.z;

        float angle_x = Vector3.Angle(Vector3.forward, pos_angle_x);
        float angle_y = Vector3.Angle(Vector3.forward, pos_angle_y);
        float angle_z = Vector3.Angle(Vector3.forward, pos_angle_z);

        Vector3 adjust_rotation = Quaternion.Euler(angle_x, angle_y, angle_z);
        */
        Vector3 dir = transform.position - player.transform.position;  //������ָ�����������dir = �������� - ����������
        Quaternion ang = Quaternion.LookRotation(dir);  //����һ�� ʹ�����塰�����������ת��
        transform.rotation = ang;
    }
    void auto_shoot()
    {
        // Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        // Vector3 lookR = (player.transform.rotation - transform.rotation).normalized;
        Instantiate(bullet_prefab, transform.position
           ,transform.rotation);
    }
}


/*//����Ƕ�

angle =Mathf.Rad2Deg*Mathf.Atan ((transform.position.y - m_player.position.y) / (transform.position.x - m_player.position.x));

//�жϽǶ��������ޣ�������������

if (transform.position.x - m_player.position.x < 0)

angle=angle-90;

else 

angle=angle+90;

//�������������ŷ���ǣ�����������������ϵ��Z�ᣬ��תZ�ȡ�

transform.localEulerAngles=new Vector3(0,0,angle);

//����gun���塣

//Instantiate (gun, transform.position, transform.rotation);
*/