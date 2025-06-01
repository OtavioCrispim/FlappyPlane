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
    [SerializeField] private TMP_Text levelText;
    public int level { get; private set; } = 1;
    private float nextLevel = 10f;
    [SerializeField] private float limiteTimerMin = 1f;
    [SerializeField] private float limiteTimerMax = 3f;

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
        GanhaLevel();
    }

    private void GanhaLevel()
    {
        levelText.text = level.ToString();
        if(pontos > nextLevel)
        {
            level++;
            nextLevel *= 2;

        }
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
            limiteTimerMin = limiteTimerMin > 0.25f ? limiteTimerMin / level : 0.25f;
            timer = TimerAleatorio(limiteTimerMin, limiteTimerMax);
            position.y = Random.Range(positionMin, positionMax);
            Instantiate(obstaculo, position, Quaternion.identity);
        }
    }

    private float TimerAleatorio(float rangeMin, float rangeMax)
    {
        return timer = Random.Range(rangeMin, rangeMax);
    }
}
