using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    GameLogic gameLogic;
    [SerializeField] ParticleSystem _explosion;
    Transform _expHolder;

    void Start()
    {
        gameLogic = GameObject.Find("Logic").GetComponent<GameLogic>();
        _expHolder = GameObject.Find("ExpHolder").GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "terx1")
        {
        var explosion = Instantiate(_explosion, transform.position, Quaternion.identity, _expHolder);
        gameLogic.KillCounter();
        explosion.Play();
        Destroy(gameObject);

        }
    }
}
