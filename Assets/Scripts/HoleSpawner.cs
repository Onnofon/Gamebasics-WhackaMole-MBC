using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSpawner : MonoBehaviour
{
    public GameObject hole;
    public GameManager gm;
    public List<GameObject> moles = new List<GameObject>();

    private void Start()
    {
        SpawnHoles();
    }

    //Spawn mole holes based on user input for amount of holes.
    public void SpawnHoles()
    {
        if (gm.holes >= 35)
            gm.holes = 35;

        for (int i = 0; i < gm.holes; i++)
        {
            GameObject molehole = Instantiate(hole);
            molehole.transform.SetParent(this.transform);
            molehole.transform.localScale = new Vector3(1, 1, 1);
            moles.Add(molehole);
        }

    }
}

