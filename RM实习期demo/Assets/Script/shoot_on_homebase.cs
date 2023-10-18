
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
        HP.value = 1;  //Value��ֵ����0-1֮�䣬��Ϊ������
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
            Debug.Log("���شݻ٣���������");
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider e)
    {
        if (obj == false) {

            if (e.gameObject.tag.CompareTo("�ӵ�") == 0)
            {
                Debug.Log("���л���");
                Destroy(e.gameObject);//���ټ�����
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
