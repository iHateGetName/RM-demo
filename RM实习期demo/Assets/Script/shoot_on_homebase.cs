
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoot_on_homebase: MonoBehaviour
{
    public int hp = 20;
    public Slider HP;
    public GameObject obj;
    public GameObject sentry;
    public CanvasGroup HP_UI_hiden;

    // Start is called before the first frame update
    void Start()
    {
        HP.value = 1;  //Value的值介于0-1之间，且为浮点数
        HP_UI_hiden.alpha = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (obj == false)
        {
            HP_UI_hiden.alpha = 1;
        }
        if (HP.value == 0.0f)
        {
            Debug.Log("基地摧毁，比赛结束");
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider e)
    {
        if (obj == false) {

            if (e.gameObject.tag.CompareTo("子弹") == 0)
            {
                Debug.Log("击中基地");
                Destroy(e.gameObject);//销毁加速球
                hp = hp - 1;
                if(sentry == false)
                {
                    HP.value = HP.value - 0.2f;
                }
                else
                {
                    HP.value = HP.value - 0.05f;
                }
            }
        }
        
    }
}
