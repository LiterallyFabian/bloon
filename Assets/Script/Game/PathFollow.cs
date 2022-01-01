using System;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UIElements;

namespace Bloonz.Game
{
    public class PathFollow : MonoBehaviour
    {
        [Tooltip("The base speed modifier to move this bloon at")]
        [SerializeField] private float _speed = 1.0f;
        
        [Tooltip("The current point to move to")]
        public int CurrentPoint = 0;
        
        [Tooltip("The bloon to move")]
        public PhysicalBloon PhysicalBloon;
        public float Progress { get; private set; }

        [Tooltip("Whether or not the bloon should move. If false, the bloon will not move.")]
        public bool IsMoving = false;

        private void Start()
        {
            transform.position = Path.Points[CurrentPoint];
        }

        private void Update()
        {
            if(!IsMoving) return;
            
            Vector3 position = transform.position;
            
            if (position != Path.Points[CurrentPoint])
            {
                position = Vector3.MoveTowards(position, Path.Points[CurrentPoint],
                    _speed * PhysicalBloon.Bloon.Speed * Time.deltaTime);
                transform.position = position;
                
                Progress = 1 - Vector3.Distance(position, Path.Points[CurrentPoint]) / Vector3.Distance(Path.Points[CurrentPoint- 1], Path.Points[CurrentPoint]) + CurrentPoint;
            }
            else
            {
                CurrentPoint++;
                if (CurrentPoint == Path.Points.Length)
                {
                    // TODO: Drain lives
                    Destroy(gameObject);
                }
            }
        }
    }
}