using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tower : MonoBehaviour
{
    /// <summary>
    /// The name of this tower
    /// </summary>
    public abstract string Name { get; }
    
    /// <summary>
    /// The base cost of this tower
    /// </summary>
    public abstract int Cost { get; }
    
    /// <summary>
    /// The base range of this tower
    /// </summary>
    public abstract float Range { get; }
    
    /// <summary>
    /// The base fire rate of this tower
    /// </summary>
    public abstract float FireRate { get; }
    
    /// <summary>
    /// The upgrades available for this tower
    /// </summary>
    public abstract Upgrade[] Upgrades { get; }
}
