using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]private float velocidade = 5f;
    [SerializeField] private GameObject puff;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Subir();
        LimitandoVelocidadeDecida();
        GameOverLimiteAltura();       
    }

    public void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocidade;
            GameObject puffCriado = CriandoPuff();
            DestroyPuff(puffCriado);
        }
    }

    public void LimitandoVelocidadeDecida()
    {
        if (rb.velocity.y < -velocidade)
            rb.velocity = Vector2.down * velocidade;
    }

    private void GameOverLimiteAltura()
    {
       if (transform.position.y >= 5.5f ||  transform.position.y <= -5.5f)
            SceneManager.LoadScene("Inicio");
    }

    private GameObject CriandoPuff()
    {
        return Instantiate(puff, transform.position, Quaternion.identity);      
    }

    private void DestroyPuff(GameObject puff)
    {
        Destroy(puff, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Inicio");
    }
}
