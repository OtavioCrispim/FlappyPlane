using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private Vector3 position;
    [SerializeField] private float positionMin = -0.5f;
    [SerializeField] private float positionMax = 2.5f;
    private float pontos = 0;
    [SerializeField] private TMP_Text pontosText;
    // Start is called before the first frame update
    void Start()
    {
        timer = TimerAleatorio(0.1f, 1f);
        //pontosText;
    }

    // Update is called once per frame
    void Update()
    {
        Pontos();
        CriaObstaculo();
    }

    private void Pontos()
    {
        pontos += Time.deltaTime;
        pontosText.text =$"Pontos:  {Mathf.Round(pontos).ToString()}";
    }

    private void CriaObstaculo()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = TimerAleatorio(1f, 3f);
            position.y = Random.Range(positionMin, positionMax);
            Instantiate(obstaculo, position, Quaternion.identity);
        }
    }

    private float TimerAleatorio(float rangeMin, float rangeMax)
    {
        return timer = Random.Range(rangeMin, rangeMax);
    }
}
