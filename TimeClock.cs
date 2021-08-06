using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeClock : MonoBehaviour
{
    GameObject TextController;
    BattleLog battleLog;
    // Start is called before the first frame update
    void Start()
    {
        TextController = GameObject.Find("TextController");
        battleLog = TextController.GetComponent<BattleLog>();
    }

    // Update is called once per frame
    public void Onclick()
    {
        Debug.Log("hourglass‚ª‰Ÿ‰º‚³‚ê‚Ü‚µ‚½");
        battleLog.TimeClock();
        
       

    }
}
