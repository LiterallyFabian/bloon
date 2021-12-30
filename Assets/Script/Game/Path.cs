using UnityEngine;

namespace Bloon.Game
{
    /// <summary>
    /// Saves the bloon path for the current level.
    /// </summary>
    public class Path : MonoBehaviour
    {
        public static Vector3[] Points { get; private set; }
    
        private void Start()
        {
            PathNode[] nodes = GetComponentsInChildren<PathNode>();
            
            Points = new Vector3[nodes.Length+2];
            Points[0] = GameObject.FindWithTag("Start").transform.position;
            Points[Points.Length-1] = GameObject.FindWithTag("Exit").transform.position;
            
            float length = 0;
            
            for (int i = 1; i < nodes.Length; i++)
            {
                Points[i] = nodes[i].transform.position;
                length += Vector3.Distance(nodes[i - 1].transform.position, nodes[i].transform.position);
            }
            
            Debug.Log($"" +
                      $"Path: {Points.Length} points" +
                      $"\nStart: {Points[0]}" +
                      $"\nExit: {Points[Points.Length-1]}" +
                      $"Length: {length} units");        
            
            Destroy(gameObject);
        }
    }
}