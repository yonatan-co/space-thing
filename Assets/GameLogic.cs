using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    int EnemyCount;
    [SerializeField] Timerx timer;
    public void KillCounter()
    {
        ++EnemyCount;
        Debug.Log( EnemyCount );
    }
    public void EndGame()
    {
        Debug.Log($"your Time count: {timer.get_time()}");
        Debug.Log($"your Enemy count: {EnemyCount}");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
