using UnityEngine;
using System.Collections;
using UnityEngine.UI;   // uGUI�̋@�\���g������
using UnityEditor;
using UnityEngine.SceneManagement;

public class BattleLog : MonoBehaviour
{
    public int TimeGauge = 0;
    public Text uiText; // uiText�ւ̎Q�Ƃ�ۂ�
    [SerializeField] Slider hpSlider;

    public int AttackValue = 50;
    void Start()
    {
        hpSlider.maxValue = 100;
        hpSlider.value = 100;

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void TimeClock()
    {
        TimeGauge++;
        if (TimeGauge == 10)
        {
            uiText.text = "������x�^�[�����s�����Ƃ��\�ɂȂ�܂���";
        }
        else
        {
            uiText.text = string.Format("����̍����v���g�p:����Q�[�W{0:0}", TimeGauge);
            Debug.Log(TimeGauge);
        }
        
    }

    public void Attack(bool Attackable)
    {
        if (Attackable)
        {
            hpSlider.value -= AttackValue;
            uiText.text = string.Format("�G��{0,000}�̍U��!!",AttackValue);
        }
        else
        {
            Debug.Log("�U���s�\");
            uiText.text = "�U���͈�^�[���Ɉ�x�̂݉\�ł�";
        }
        
        
    }
}
