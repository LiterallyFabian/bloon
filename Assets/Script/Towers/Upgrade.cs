using System.Collections;
using System.Collections.Generic;
using Bloonz;
using UnityEngine;

public abstract class Upgrade : MonoBehaviour
{
    /// <summary>
    /// The name of this upgrade
    /// </summary>
    public abstract string Name { get; }
    
    /// <summary>
    /// The base cost of this upgrade
    /// </summary>
    public abstract int Cost { get; }
    
    /// <summary>
    /// The description of this upgrade
    /// </summary>
    public abstract string Description { get; }
    
    /// <summary>
    /// The position of this upgrade in the upgrade menu
    /// </summary>
    public abstract UpgradePath Path { get; }
    
    /// <summary>
    /// Applies this upgrade on its tower
    /// </summary>
    public abstract void ApplyUpgrade();
}
