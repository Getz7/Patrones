using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    [SerializeField] private Enemy_Factory _enemyFac;
    [SerializeField] private GameObject[] spawns;
   

    
    

    // Start is called before the first frame update
    private void Start()
    {
        

        //LLamamos a la factoria para crear los enemigos 
        

        _enemyFac.CreateEnemy("Centipede", new Vector2(41, -79)).transform.SetParent(transform);
        //_enemyFac.CreateEnemy("Centipede", new Vector2(67, -79)).transform.SetParent(transform);



        _enemyFac.CreateEnemy("BigBloated", new Vector2(15, -80));
        

    }

    
}
