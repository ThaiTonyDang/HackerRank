using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Runtime.CompilerServices;

class Result
{

    public static int[] ComputeZ(string s)
    {
        int n = s.Length;
        int[] z = new int[n];
        int L = 0, R = 0;
        for (int i = 1; i < n; i++)
        {
            if (i > R)
            {
                L = R = i;
                while (R < n && s[R] == s[R - L])
                    R++;
                z[i] = R - L;
                R--;
            }
            else
            {
                int k = i - L;
                if (z[k] < R - i + 1)
                    z[i] = z[k];
                else
                {
                    L = i;
                    while (R < n && s[R] == s[R - L])
                        R++;
                    z[i] = R - L;
                    R--;
                }
            }
        }
        return z;
    }
    public static void VirusIndices(string P, string V)
    {
        string combinedForward = V + "#" + P;
        string combinedReverse = new string(V.Reverse().ToArray()) + "#" + new string(P.Reverse().ToArray());

        int[] Z1 = ComputeZ(combinedForward);
        int[] Z2 = ComputeZ(combinedReverse);

        int N = V.Length;
        int M = P.Length;

        List<int> results = new List<int>();

        for (int i = 0; i <= M - N; i++)
        {
            if (Z1[N + 1 + i] == N)
                results.Add(i);
            else
            {
                int matchFromStart = Z1[N + 1 + i];
                int matchFromEnd = Z2[combinedReverse.Length - (i + N)];
                if (matchFromStart + matchFromEnd + 1 >= N)
                    results.Add(i);
            }
        }

        if (results.Count > 0)
            Console.WriteLine(string.Join(" ", results));
        else
            Console.WriteLine("No Match!");
    }


}

class Solution
{
    public static void Main(string[] args)
    {

    }
}
