using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    GameLogic gameLogic;

    private void OnTriggerEnter() { gameLogic.EndGame(); }       
    void Start()
    {
        gameLogic = GameObject.Find("Logic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
