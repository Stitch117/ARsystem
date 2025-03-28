using System;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{
    GameObject[] m_targets = new GameObject[5];
    [SerializeField] private GameObject m_target;
    int index = -1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkIfFull() != -1)
        {
            m_targets[index] = Instantiate(m_target, new Vector3(transform.position.x + (RandomNumberGenerator.GetInt32(3) - 1.5f),
                                                                 transform.position.y + (RandomNumberGenerator.GetInt32(3) - 1.5f), 
                                                                 transform.position.z + (RandomNumberGenerator.GetInt32(3) - 1.5f)), transform.rotation);
        }
    }

    int checkIfFull()
    {
        for (int i = 0; i < m_targets.Length; i++)
        {
            if (m_targets[i] == null)
            {
                index = i;
                return index;
            }
        }
        index = -1;
        return index;
    }
}
