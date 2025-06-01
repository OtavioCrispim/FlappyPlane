using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade;
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(obstaculo, 5f);

        gameController = FindObjectOfType<GameController>();       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * velocidade;
        AumentandoVelocidade();
    }

    private void AumentandoVelocidade()
    {
        velocidade = 4f + gameController.level;
    }
}
