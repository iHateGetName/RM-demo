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
        Vector3 dir = transform.position - player.transform.position;  //正方体指向球体的向量dir = 球体坐标 - 正方体坐标
        Quaternion ang = Quaternion.LookRotation(dir);  //创建一个 使正方体“看向”球体的旋转角
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


/*//计算角度

angle =Mathf.Rad2Deg*Mathf.Atan ((transform.position.y - m_player.position.y) / (transform.position.x - m_player.position.x));

//判断角度所在象限，并进行修正。

if (transform.position.x - m_player.position.x < 0)

angle=angle-90;

else 

angle=angle+90;

//设置物体的自身欧拉角，是物体绕自身坐标系在Z轴，旋转Z度。

transform.localEulerAngles=new Vector3(0,0,angle);

//生成gun物体。

//Instantiate (gun, transform.position, transform.rotation);
*/