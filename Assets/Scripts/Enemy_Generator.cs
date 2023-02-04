using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Initial Generator.
public class Enemy_Generator : MonoBehaviour
{

    public int maxNEnemies = 10;
    public GameObject enemyPrefab;
    public GameObject playerPrefab;
    private List<GameObject> enemyList;


    // Spawn Area
    // TODO: remove enemy from list when destroyed.
    public int minX = 0;
    public int maxX = 20;
    public int minZ = 0;
    public int maxZ = 20;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxNEnemies; i++) {
            // Instantiate enemyprefab to random location in range of the big map.
            SpawnEnemy(enemyPrefab, getRandPos());
        }
        
    }

    /**
     * Return random position between min,max.
     */
    Vector3 getRandPos()
    {
        return new Vector3(Random.Range(minX, maxX), 0, Random.Range(minZ, maxZ));
    }


    /**
     * Spawn single enemy at position
     */
    void SpawnEnemy(GameObject enemy, Vector3 position)
    {
        Instantiate(enemy, position, new Quaternion());
        enemyList.Add(enemy);
    }

}
