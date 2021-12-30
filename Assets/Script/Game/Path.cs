using UnityEngine;

namespace Bloonz.Game
{
    /// <summary>
    /// Saves the bloon path for the current level.
    /// </summary>
    public class Path : MonoBehaviour
    {
        public static Vector3[] Points { get; private set; }
    
        private void Awake()
        {
            PathNode[] nodes = GetComponentsInChildren<PathNode>();
            
            Points = new Vector3[nodes.Length+2];
            Points[0] = GameObject.FindWithTag("Start").transform.position;
            Points[Points.Length-1] = GameObject.FindWithTag("Exit").transform.position;
            
            for (int i = 0; i < nodes.Length; i++)
            {
                Points[i+1] = nodes[i].transform.position;
            }

            Debug.Log($"" +
                      $"Path: {Points.Length} points" +
                      $"\nStart: {Points[0]}" +
                      $"\nExit: {Points[Points.Length - 1]}"); 
            
            Destroy(gameObject);
        }
    }
}