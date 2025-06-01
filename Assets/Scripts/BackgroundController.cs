using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] private Renderer backgroundRenderer;
    [SerializeField] private float xOffset = 0;
    private Vector2 texturaOffset;
    private float velocidade = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        backgroundRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        xOffset += Time.deltaTime * velocidade;
        texturaOffset.x = xOffset;
        backgroundRenderer.material.mainTextureOffset = texturaOffset;
    }
}
