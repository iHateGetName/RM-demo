using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoot_on : MonoBehaviour
{
    public int hp = 10;
    public Slider HP;

    // Start is called before the first frame update
    void Start()
    {
        HP.value = 1;  //Value的值介于0-1之间，且为浮点数
      //  GameObject.Find("基地").GetComponent<shoot_on_homebase>().enabled = false;
       // GameObject.Find("基地").GetComponent<shoot_on_homebase::OnTriggerEnter()>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hp == 0)
        {
            Debug.Log("前哨战摧毁，基地无敌状态解除");
            Destroy(gameObject);
          //  GameObject.Find("基地").GetComponent<shoot_on_homebase>().enabled = true;
            //GameObject.Find("基地").GetComponent < shoot_on_homebase::OnTriggerEnter() > ().enabled = true;

        }
    }
    void OnTriggerEnter(Collider e)
    {

        if (e.gameObject.tag.CompareTo("子弹") == 0)
        {
            Debug.Log("击中前哨战");
            Destroy(e.gameObject);//销毁加速球
            hp = hp - 1;
            HP.value = HP.value - 0.1f;
        }
    }
}
