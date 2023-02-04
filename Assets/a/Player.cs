using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombreJugador;
    private GameManager gm;
    private int contadorPlayer, contadorEnemigo;

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

        if (contadorPlayer  !=6 || contadorEnemigo !=6)
        {
            int prefabEnemigo = Random.Range(0, gm.gameList.Count);
            gm.gameList[prefabEnemigo].transform.position += Vector3.down * 2;
            string nombreEnemigo = gm.gameList[prefabEnemigo].GetComponent<Enemigo>().nombreEnemigo;
            transform.position += Vector3.up * 2;
            switch (nombreJugador)
            {
                case "Abuelo":
                    if (nombreEnemigo.Equals("Abuelo"))
                    {
                        Debug.Log("Empate");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                    }
                    if (nombreEnemigo.Equals("Abuela"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    if (nombreEnemigo.Equals("Padre"))
                    {
                        Debug.Log("Gana");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorPlayer++;
                    }
                    if (nombreEnemigo.Equals("Madre"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    if (nombreEnemigo.Equals("Niño"))
                    {
                        Debug.Log("Gana");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorPlayer++;
                    }
                    break;
                case "Abuela":
                    if (nombreEnemigo.Equals("Abuelo"))
                    {
                        Debug.Log("Gana");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorPlayer++;
                    }
                    if (nombreEnemigo.Equals("Abuela"))
                    {
                        Debug.Log("Empate");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                    }
                    if (nombreEnemigo.Equals("Padre"))
                    {
                        Debug.Log("Gana");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorPlayer++;
                    }
                    if (nombreEnemigo.Equals("Madre"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    if (nombreEnemigo.Equals("Niño"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    break;
                case "Padre":
                    if (nombreEnemigo.Equals("Abuelo"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    if (nombreEnemigo.Equals("Abuela"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    if (nombreEnemigo.Equals("Padre"))
                    {
                        Debug.Log("Empate");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                    }
                    if (nombreEnemigo.Equals("Madre"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    if (nombreEnemigo.Equals("Niño"))
                    {
                        Debug.Log("Gana");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorPlayer++;
                    }
                    break;
                case "Madre":
                    if (nombreEnemigo.Equals("Abuelo"))
                    {
                        Debug.Log("Gana");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorPlayer++;
                    }
                    if (nombreEnemigo.Equals("Abuela"))
                    {
                        Debug.Log("Gana");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorPlayer++;
                    }
                    if (nombreEnemigo.Equals("Padre"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    if (nombreEnemigo.Equals("Madre"))
                    {
                        Debug.Log("Empate");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                    }
                    if (nombreEnemigo.Equals("Niño"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    break;
                case "Niño":
                    if (nombreEnemigo.Equals("Abuelo"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    if (nombreEnemigo.Equals("Abuela"))
                    {
                        Debug.Log("Gana");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorPlayer++;
                    }
                    if (nombreEnemigo.Equals("Padre"))
                    {
                        Debug.Log("Pierde");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorEnemigo++;
                    }
                    if (nombreEnemigo.Equals("Madre"))
                    {
                        Debug.Log("Gana");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                        contadorPlayer++;
                    }
                    if (nombreEnemigo.Equals("Niño"))
                    {
                        Debug.Log("Empate");
                        StartCoroutine(cooldownAnim(gm.gameList, prefabEnemigo));
                    }
                    break;
            }
            if (contadorEnemigo == 6)
            {
                Debug.Log("Gana Enemigo");
            }
            if (contadorPlayer == 6)
            {
                Debug.Log("Gana Jugador");
            }
        }
    }

    IEnumerator cooldownAnim(List<GameObject> lista, int indice)
    {

        yield return new WaitForSeconds(2);
        lista[indice].transform.position += Vector3.up * 2;
        transform.position += Vector3.down * 2;

    }
}
