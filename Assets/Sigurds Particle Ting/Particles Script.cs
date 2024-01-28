using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesScript : MonoBehaviour
{
    public GameObject[] particlePrefabs;
    public Transform spawnKeeper;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Instantiate(GetRandomParticles(), transform.position, UnityEngine.Random.rotation, spawnKeeper);
    }
    private GameObject GetRandomParticles() {
        return particlePrefabs[UnityEngine.Random.Range(0, particlePrefabs.Length)];
    }

}

