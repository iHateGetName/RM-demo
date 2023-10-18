using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Security.AccessControl;
using UnityEngine;

public class player_control : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private Rigidbody playerRb;

    public int View = 1;

    // public Camera GodV;
    // public Camera operat_V;
    private Vector3 FirstView = new Vector3(0, 0.3f, -0.15f);
    private Vector3 ThirdView = new Vector3(0, 0.5f, 1.5f);
    //private Vector3 GodView = new Vector3(3, 20, 3);
    private GameObject Cam;
    private void Awake()
    {
        Cam = transform.Find("Main Camera").gameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        // playerRb = GetCommponent<Rigidbody>();
        /*
        GodV.enabled =false;
        operat_V.enable = true;
        */
    }

    // Update is called once per frame
    void Update()
    {

        MouseLook();
        ChangeView();
        //Move_wasd();
        
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(-Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(-Vector3.forward * verticalInput * Time.deltaTime * speed);
        
        /*
          if (Input.GetKeyDown(KeyCode.Space))
          {
              playerRb.AddForce(Vector3.up * jumpForce, Force.ForceMode.Impulse);
          }*/
    }
    /*
    public void Move_wasd()//wasd前后移动
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(-Vector3.right * horizontalInput * Time.deltaTime * speed);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(-Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
    */
    public void MouseLook()//鼠标微调转向
    {
        float mx = Input.GetAxis("Mouse X");

        Quaternion qx = Quaternion.Euler(0, mx, 0);

        transform.rotation = qx * transform.rotation;
        /*
        float angle = transform.eulerAngles.x;
        if (angle > 180) angle -= 360;
        if (angle < 180) angle += 360;
        
        if(angle> 60)
        {
            transform.eulerAngles = new Vector3(60, eulerAngles.y, 0);
        }
        if (angle < -60)
        {
            transform.eulerAngles = new Vector3(-60, eulerAngles.y, 0);
        }
        */
    }
    public void ChangeView()//改变视角
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            View++;
        }
        if (View >= 3)
        {
            View = 1;
            /*
            GodV.enabled = false;
            operat_V.enable = true;
            */
        }
        if (View == 1)
        {
            Cam.transform.localPosition = FirstView;
        }
        if (View == 2)
        {
            Cam.transform.localPosition = ThirdView;
        }
        /*   上帝视角
        if (View == 3)
        {
            GodV.enabled = true;
            operat_V.enable = false; 
        }
        */
    }
}
