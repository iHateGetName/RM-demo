
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoot_on_sentry : MonoBehaviour
{
    public int hp = 20;
    public Slider HP;
    public GameObject obj;
    public CanvasGroup HP_UI_hiden;
    // Start is called before the first frame update
    void Start()
    {
        HP.value = 1;  //Value的值介于0-1之间，且为浮点数
        //HP.setActive(false);
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
            Debug.Log("哨兵摧毁，基地护甲打开");
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider e)
    {
        if (obj == false)
        {
            //HP.setActive(true);
            if (e.gameObject.tag.CompareTo("子弹") == 0)
            {
                Debug.Log("击中哨兵");
                Destroy(e.gameObject);//销毁加速球
                hp = hp - 1;
                HP.value = HP.value - 0.05f;
            }
        }

    }
}
