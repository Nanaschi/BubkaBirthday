using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;
using Random = System.Random;

namespace _Scripts
{
    public static class Extensions
    {


        public static object GetRandomElement<T>(this List<T> array)
        {
            var rand = new Random();
            return  array[rand.Next(array.Count)];
        }
        
    }
}