using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float vida;
    [SerializeField] public int ataque;
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
        
        int prefabEnemigo = Random.Range(0, gm.gameList.Count);
        gm.gameList[prefabEnemigo].transform.position += Vector3.down * 2;
        float vidaEnemigo = gm.gameList[prefabEnemigo].GetComponent<Enemigo>().vida;
        int dmgEnemigo = gm.gameList[prefabEnemigo].GetComponent<Enemigo>().ataque;
        transform.position += Vector3.up * 2;
        while (vidaEnemigo > 0 && vida > 0)
        {
            vidaEnemigo = vidaEnemigo - ataque;
            vida = vida - dmgEnemigo;
        }
        if (vidaEnemigo <= 0 && vida <= 0)
        {
            Debug.Log("Empate");
            StartCoroutine(cooldownAnimDraw(gm.gameList, prefabEnemigo, gameObject));
        }
        if (vida <= 0 && vidaEnemigo > 0)
        {
            Debug.Log("Gana Enemigo");
            StartCoroutine(cooldownAnimEnemiWin(gm.gameList, prefabEnemigo, gameObject));
        }
        if (vidaEnemigo <= 0 && vida > 0)
        {
            Debug.Log("Gana Jugador");
            StartCoroutine(cooldownPlayerWin(gm.gameList,prefabEnemigo));
        }
    }

    IEnumerator cooldownAnimDraw(List<GameObject> lista, int indice, GameObject gameObject)
    {

        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        Destroy(lista[indice]);
        lista.RemoveAt(indice);
        Debug.Log(lista.Count);
    }
    IEnumerator cooldownAnimEnemiWin(List<GameObject> lista, int indice, GameObject gameObject)
    {

        yield return new WaitForSeconds(2);
        lista[indice].transform.position += Vector3.up * 2;
        Destroy(gameObject);
    }

    IEnumerator cooldownPlayerWin(List<GameObject> lista, int indice)
    {
        
        yield return new WaitForSeconds(2);
        transform.position += Vector3.down * 2;
        Destroy(lista[indice]);
        lista.RemoveAt(indice);
        Debug.Log(lista.Count);
    }
}
