using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public List<GameObject> gameList = new List<GameObject>();
    public GameObject enemigo1;
    public GameObject enemigo2;
    public GameObject enemigo3;
    void Start()
    {
        gameList.Add(enemigo1);
        gameList.Add(enemigo2);
        gameList.Add(enemigo3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
