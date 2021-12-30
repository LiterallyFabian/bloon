using System;
using System.Collections;
using System.Collections.Generic;
using Bloonz;
using Bloonz.Bloons;
using Bloonz.Game;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("The Bloon prefab to use for the game")]
    [SerializeField] private GameObject _bloonPrefab;
    
    [Tooltip("The spawning area for the bloons")]
    private Vector3 _spawnPosition;

    private void Start()
    {
        _spawnPosition = GameObject.FindWithTag("Start").transform.position;
        SummonBloon(BloonType.Yellow);
    }

    /// <summary>
    /// Spawns a bloon of the specified type at spawn
    /// </summary>
    /// <param name="type"></param>
    private void SummonBloon(BloonType type)
    {
        SummonBloon(type, _spawnPosition, 0);
    }

    /// <summary>
    /// Summons a bloon of the specified type at the specified position.
    /// Mainly used when a popped bloon spawns 2..* bloons.
    /// </summary>
    /// <param name="type">The bloon type to spawn</param>
    /// <param name="position">The position to spawn the bloon at</param>
    /// <param name="currentPoint">The next node this bloon should move towards</param>
    private void SummonBloon(BloonType type, Vector3 position, int currentPoint)
    {
        Bloon b = Manager.GetBloon(type);
        GameObject go = Instantiate(_bloonPrefab, position, Quaternion.identity);
        PhysicalBloon pb = go.GetComponent<PhysicalBloon>();
        
        pb.PathFollow.CurrentPoint = currentPoint;
        pb.PathFollow.IsMoving = true;
        
        pb.SetBloon(b);
    }
}