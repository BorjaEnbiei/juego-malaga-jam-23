using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public List<Player> PlayerList = new List<Player>();
    [SerializeField] private int healthEnem,playerHealth;
    public Player player;
    public GameObject enemigo;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        enemySpawn();
        healthEnem = enemigo.GetComponent<Enemigo>().getVida();
        //playerHealth = GetComponent<Player>().vida;
       // Debug.Log(playerHealth);
    }
     
    public void enemySpawn()
    {
        Instantiate(enemigo);
        enemigo.SetActive(true);
    }
}
