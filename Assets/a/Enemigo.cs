using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] public int vida;
    [SerializeField] private int ataque;

    // Start is called before the first frame update
    void Start()
    {
        getVida();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getVida()
    {
        return vida = Random.Range(1, 20);
    }
}
