using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    public HoleSpawner holeSpawner;
    public List<Mole> moles = new List<Mole>();
    public float maxTime = 5;
    public float minTime = 2;
    private float time;
    private float spawnTime;

    private void Start()
    {
        foreach (GameObject mole in holeSpawner.moles)
        {
            Mole newmole;
            newmole = mole.GetComponent<Mole>();
            moles.Add(newmole);
        }
        time = minTime;
        SetRandomTime();
    }

    //Countdown for when the mole needs to appear
    private void Update()
    {
        time += Time.deltaTime;
        if (time >= spawnTime) 
        {
            SpawnMole();
            SetRandomTime();
            time = 0f;
        }
    }

    //Sets random time for when next mole should appear
    private void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    //Mole is spawned in random hole
    public void SpawnMole()
    {
        int moleToSpawn;
        moleToSpawn = Random.Range(0, moles.Count);
        moles[moleToSpawn].Spawn();
    }
}
