using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mole : MonoBehaviour
{
    public GameObject mole;
    public void Hit()
    {
        mole.SetActive(false);
    }
    public void Spawn()
    {
        mole.SetActive(true);
        StartCoroutine(DespawnTimer());
    }

    public void Despawn()
    {
        mole.SetActive(false);
    }

    public IEnumerator DespawnTimer()
    {
        yield return new WaitForSeconds(1.5f);
        Despawn();
    }
}
