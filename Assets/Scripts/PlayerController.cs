using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]private float velocidade = 5f;
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
    }

    public void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rb.velocity = Vector2.up * velocidade;
    }

    public void LimitandoVelocidadeDecida()
    {
        if (rb.velocity.y < -velocidade)
            rb.velocity = Vector2.down * velocidade;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Jogo");
    }
}
