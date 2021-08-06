using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attack : MonoBehaviour
{
    GameObject TextController;
    BattleLog battleLog;

    bool Attackable = true;
    // Start is called before the first frame update
    void Start()
    {
        TextController = GameObject.Find("TextController");
        battleLog = TextController.GetComponent<BattleLog>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        battleLog.Attack(Attackable);
        Attackable = false;

    }
}
