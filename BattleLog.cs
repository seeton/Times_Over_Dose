using UnityEngine;
using System.Collections;
using UnityEngine.UI;   // uGUIの機能を使うお約束
using UnityEditor;
using UnityEngine.SceneManagement;

public class BattleLog : MonoBehaviour
{
    public int TimeGauge = 0;
    public Text uiText; // uiTextへの参照を保つ
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
            uiText.text = "もう一度ターンを行うことが可能になりました";
        }
        else
        {
            uiText.text = string.Format("時空の砂時計を使用:時空ゲージ{0:0}", TimeGauge);
            Debug.Log(TimeGauge);
        }
        
    }

    public void Attack(bool Attackable)
    {
        if (Attackable)
        {
            hpSlider.value -= AttackValue;
            uiText.text = string.Format("敵に{0,000}の攻撃!!",AttackValue);
        }
        else
        {
            Debug.Log("攻撃不可能");
            uiText.text = "攻撃は一ターンに一度のみ可能です";
        }
        
        
    }
}
