using System;
using System.Collections.Generic;
namespace part5
{
    public class Connectivity
    {
        public int n;
        public List<int> [] graph;
        public Connectivity(int n)
        {
            this.n = n;
            this.graph = new List<int>[n + 1];
            for (int i =1; i<=n; i++)
            {
                graph[i] = new List<int>();
            }

        }
        public void AddConnection(int a, int b)
        {
           this.graph[a].Add(b);
           this.graph[b].Add(a);
        }

        public int Calculate(int x)
        {
            List<int> visitedList = graph[x];
            if(visitedList.Contains(x))
            {
                return 0;
            }
            foreach (int i in graph[x])
            {
                Calculate(n);
            }
            return visitedList.Count;
        }


    }

}