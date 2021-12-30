using System;
using System.ComponentModel.Design;
using UnityEngine;

namespace Bloon.Game
{
    public class PathFollow : MonoBehaviour
    {
        [SerializeField] private float _speed = 1.0f;
        private int _currentPoint = 0;

        private void Start()
        {
            transform.position = Path.Points[_currentPoint];
        }

        private void Update()
        {
            if (transform.position != Path.Points[_currentPoint])
            {
                transform.position = Vector3.MoveTowards(transform.position, Path.Points[_currentPoint], _speed * Time.deltaTime);
            }
            else
            {
                _currentPoint++;

                if (_currentPoint == Path.Points.Length)
                {
                    Destroy(gameObject);
                }
            }

        }
    }
}