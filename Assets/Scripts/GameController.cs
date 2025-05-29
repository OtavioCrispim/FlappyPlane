using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float timer = 1f;
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private Vector3 position;
    [SerializeField] private float positionMin = -0.5f;
    [SerializeField] private float positionMax = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = TimerAleatorio();
            position.y = Random.Range(positionMin, positionMax);
            Instantiate(obstaculo, position, Quaternion.identity);
        }         
    }

    private float TimerAleatorio()
    {
        return timer = Random.Range(1f, 3f);
    }
}
