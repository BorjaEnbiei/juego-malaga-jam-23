using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int vida, vidajugando;
    [SerializeField] public int ataque;
    [SerializeField] public bool jugada;
    private GameManager gm;

    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Vector3 posicionInicial = transform.position;
        
        if (jugada == false)
        {
            transform.position += Vector3.up * 2;
            jugada = true;
            Debug.Log(vida);
        }
        else
        {
            transform.position = posicionInicial;
            jugada = false;
        }
    }
}
