using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Bloonz;
using Bloonz.Bloons;
using Bloonz.Game;
using Bloonz.Round;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Tooltip("The Bloon prefab to use for the game")]
    [SerializeField] private GameObject _bloonPrefab;
    
    [Tooltip("The spawning area for the bloons")]
    private Vector3 _spawnPosition;
    
    public static GameManager Instance { get; private set; }
    
    public List<PhysicalBloon> Bloons { get; } = new List<PhysicalBloon>();

    private void Start()
    {
        _spawnPosition = GameObject.FindWithTag("Start").transform.position;
        Instance = this;


        StartCoroutine(SummonRound(4));
    }

    #region Summoning
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
    /// Only called directly when a popped bloon shall spawn 2..* bloons.
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
        
        Bloons.Add(pb);
    }

    private IEnumerator SummonRound(int round)
    {
        Round r = RoundManager.Rounds[round - 1];
        
        Debug.Log($"Summoning round {round} with {r.TotalBloons} bloons.");
        
        
        float delayDelta = 0;
        // summon each group of bloons in the round
        foreach (BloonGroup group in r.BloonGroups)
        {
            // wait for the group to be ready
            yield return new WaitForSeconds(group.Delay - delayDelta);
            delayDelta += group.Delay;
            StartCoroutine(SummonGroup(group));
        }
    }

    private IEnumerator SummonGroup(BloonGroup group)
    {
        Debug.Log($"Summoning group {group.BloonType} with {group.Count} bloons.");
        for(int i = 0; i < group.Count; i++)
        {
            yield return new WaitForSeconds(group.DelayBetweenBloons);
            SummonBloon(group.BloonType);
        }
    }
    #endregion
    
    #region Getting Bloons

    /// <summary>
    /// Finds a bloon closest to a position
    /// </summary>
    /// <returns>The closest bloon, or null if none are spawned</returns>
    public PhysicalBloon FindClosest(Vector3 pos)
    {
        PhysicalBloon closest = null;
        float minDist = float.MaxValue;
        foreach(PhysicalBloon b in Bloons)
        {
            float dist = Vector3.Distance(pos, b.transform.position);
            if (dist < minDist)
            {
                closest = b;
                minDist = dist;
            }
        }
        return closest;
    }

    /// <summary>
    /// Finds the first bloon on the path
    /// </summary>
    /// <returns>A bloon on the path, or null if none are spawned</returns>
    public PhysicalBloon FindFirst()
    {
        // find highest progress
        float highestProgress = 0;
        PhysicalBloon highestBloon = null;
        foreach (PhysicalBloon b in Bloons.Where(b => b.PathFollow.Progress > highestProgress))
        {
            highestProgress = b.PathFollow.Progress;
            highestBloon = b;
        }

        return highestBloon;
    }
    
    #endregion
}