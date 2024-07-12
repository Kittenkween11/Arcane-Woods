using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ArcaneWoods
{
    public class Rotate : MonoBehaviour
    {
        [SerializeField, Range(-360, 360)]
        private float _rotationSpeed = 500;
        // Start is called before the first frame update
        void Start()
        {
         
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 rotation = Vector3.zero;
            rotation.x += Time.deltaTime * _rotationSpeed;

            rotation.y += Time.deltaTime * _rotationSpeed;
            transform.Rotate(rotation, Space.Self);
        }
    }
}
