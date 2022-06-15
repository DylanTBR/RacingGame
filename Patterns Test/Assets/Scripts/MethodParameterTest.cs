using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MethodParameters
{
    public class MethodParameterTest : MonoBehaviour
    {
        private void Update()
        {
            StaticTest.SetHealth(100); 
        }
        protected internal void ParameterOne(float value)
        {
           
        }

    }
}
