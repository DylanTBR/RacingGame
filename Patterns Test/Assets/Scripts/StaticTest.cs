using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MethodParameters
{
    public class StaticTest : MonoBehaviour
    {
        //Static Field abstraction 
        private static float health;

        public static void SetHealth(float value)
        {
            health = value;
        }
        public static float GetHealth()
        {
            return health; 
        }
        // End of abstraction

        private static void ReferenceVariable(MethodParameterTest methodParameterTest, MethodParameterTest methodParameterTest2)
        {
            methodParameterTest.ParameterOne(2); 
            methodParameterTest2.ParameterOne(2); 
        }

    }
}
