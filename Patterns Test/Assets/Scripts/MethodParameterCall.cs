using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MethodParameters
{
    public class MethodParameterCall : MonoBehaviour
    {
        private MethodParameterTest methodParameterTest, methodParameterTest2;

        private void Start()
        {
            methodParameterTest = new MethodParameterTest();
            methodParameterTest2 = new MethodParameterTest();
        }
        private void Update()
        {
        }

        public void ChangeValue()
        {

        }
    }

}
