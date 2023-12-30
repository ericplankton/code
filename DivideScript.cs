using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DivideScript : MonoBehaviour
{
    public static class Divisors
    {

        public static int[] GetDivisors(int n)
        {
            if (n <= 0)
            {
                return null;
            }
            List divisors = new List();
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    if (i != n / i)
                    {
                        divisors.Add(n / i);
                    }
                }
            }
            divisors.Sort();
            return divisors.ToArray();
        }
    }
}


   

