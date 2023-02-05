using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombreJugador;
    private GameManager gm;


    
    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
    }
    void update()
    {
        if (gm.contadorEnemigo == 5)
        {
            Debug.Log("Gana Enemigo");
            //CHANGE SCENE TO GAME OVER
        } else if (gm.contadorPlayer == 5)
        {
            Debug.Log("Gana Jugador");
            // CHANGE SCENE TO PLAYER WON
        }
    }
    // Update is called once per frame
    private void OnMouseDown()
    {
        if (gm.contadorPlayer < 5 & gm.contadorEnemigo < 5)
        {
            int prefabEnemigo = Random.Range(0, gm.gameList.Count);
            gm.gameList[prefabEnemigo].transform.position += Vector3.down * 2;
            string nombreEnemigo = gm.gameList[prefabEnemigo].GetComponent<Enemigo>().nombreEnemigo;
            transform.position += Vector3.up * 2;

            string matchResult = "";
            switch (nombreJugador)
            { 
                case "Abuelo":
                {
                    switch (nombreEnemigo)
                    {
                    case "Abuelo":
                    matchResult = "Empate";
                    break;

                    case "Abuela":
                    matchResult = "Pierde";
                    break;
                        
                    case "Padre":
                    matchResult = "Gana";
                    break;

                    case "Madre":
                    matchResult = "Pierde";
                    break;
                    
                    case "Niño":
                    matchResult = "Gana";
                    break;
                    }
                }
                break;

                case "Abuela":
                {
                    switch (nombreEnemigo)
                    {
                    case "Abuelo":
                    matchResult = "Gana";
                    break;

                    case "Abuela":
                    matchResult = "Empate";
                    break;
                        
                    case "Padre":
                    matchResult = "Gana";
                    break;

                    case "Madre":
                    matchResult = "Pierde";
                    break;
                    
                    case "Niño":
                    matchResult = "Pierde";
                    break;
                    }
                }
                break;

                case "Padre":
                {
                    switch (nombreEnemigo)
                    {
                    case "Abuelo":
                    matchResult = "Pierde";
                    break;

                    case "Abuela":
                    matchResult = "Pierde";
                    break;
                        
                    case "Padre":
                    matchResult = "Empate";
                    break;

                    case "Madre":
                    matchResult = "Gana";
                    break;
                    
                    case "Niño":
                    matchResult = "Gana";
                    break;
                    }
                }
                break;

                case "Niño":
                {
                    switch (nombreEnemigo)
                    {
                    case "Abuelo":
                    matchResult = "Pierde";
                    break;

                    case "Abuela":
                    matchResult = "Gana";
                    break;
                        
                    case "Padre":
                    matchResult = "Pierde";
                    break;

                    case "Madre":
                    matchResult = "Gana";
                    break;
                    
                    case "Niño":
                    matchResult = "Empate";
                    break;
                    }
                }
                break;
                 
                case "Madre":
                {
                    switch (nombreEnemigo)
                    {
                    case "Abuelo":
                    matchResult = "Gana";
                    break;

                    case "Abuela":
                    matchResult = "Gana";
                    break;
                        
                    case "Padre":
                    matchResult = "Pierde";
                    break;

                    case "Madre":
                    matchResult = "Empate";
                    break;
                    
                    case "Niño":
                    matchResult = "Pierde";
                    break;
                    }
                }
                break;
                
            }

            StartCoroutine(cooldownAnim(prefabEnemigo));

            Debug.Log(matchResult);
            if (matchResult == "Gana") {
                gm.contadorPlayer++;
            } else if (matchResult == "Pierde") {
                gm.contadorEnemigo++;
            }
        } 
        Debug.Log(gm.contadorEnemigo.ToString() + gm.contadorPlayer.ToString());

    }

    IEnumerator cooldownAnim(int prefabEnemigo)
    {
        yield return new WaitForSeconds(1);
        gm.gameList[prefabEnemigo].transform.position += Vector3.up * 2;
        transform.position += Vector3.down * 2;
    }
}