using System;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UIElements;

namespace Bloonz.Game
{
    public class PathFollow : MonoBehaviour
    {
        [SerializeField] private float _speed = 1.0f;
        public int CurrentPoint = 0;
        public PhysicalBloon PhysicalBloon;

        private void Start()
        {
            transform.position = Path.Points[CurrentPoint];
            
            PhysicalBloon bloon = GetComponent<PhysicalBloon>();
            if(bloon) _speed = bloon.Bloon.Speed;
        }

        private void Update()
        {
            if (transform.position != Path.Points[CurrentPoint])
            {
                transform.position = Vector3.MoveTowards(transform.position, Path.Points[CurrentPoint],
                    _speed * PhysicalBloon.Bloon.Speed * Time.deltaTime);
            }
            else
            {
                CurrentPoint++;

                if (CurrentPoint == Path.Points.Length)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}