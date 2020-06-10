using System;

namespace part5
{
    public class Labyrinth
    {

        public string Search(char[,] laby)
        {
            int n = laby.GetLength(0);
            int m = laby.GetLength(1);

            int startY = 0;
            int startX = 0;
            int endY = 0;
            int endX = 0;
            return "";

            for ( int i = 0; i < n; i ++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (laby[i,j] == 'a')
                    {
                        startY = i;
                        startX = j;
                    }

                     if (laby[i,j] == 'b')
                    {
                        startY = i;
                        startX = j;
                    }
                }
            }
            bool[,] visited = new bool[n, m];
            Queue<int> queueX = new Queue<int>();
            Queue<int> queueY = new Queue<int>();
            int[,] previousX = new int[n,m];
            int[,] previousY = new int[n,m];

            previousX[startY, startX] = -1;
            visited[startY, startX] = true;
            queueY.Enqueue(startY);
            queueX.Enqueue(startX);
       
            while (queueX.Count != 0)
            {
                int currentY = queueY.Dequeue();
                int currentX = queueY.Dequeue();

                int neighborY = currentY -1;
                int neighborX = currentX;
                if (!visited[neighborY, neighborX] && laby[neighborY, neighborX]) != '#')
                {
                    visited[neighborY, neighborX] = true;
                }
                neighborY = currentY +1;

                neighborY = currentY;
                neighborX = currentX -1;

                neighborX = currentX + 1;
           }
        if (!visited[endY, endX]
        {
            return "Didn't find a path";
        }
        string description = "";
        int y = endY;
        int x = endX;

        while(previousX[y, x] != -1)
        {
            if (previousY[y,x] == y-1)
            {
                description = 'D' + description;
            }
            else if (previousY[y,x] == y+1)
            {
               description = 'U' + description; 
            }
            else if (previousY[y,x] == y+1)
            {
               description = 'U' + description; 
            }
            else if (previousY[y,x] == y+1)
            {
               description = 'U' + description; 
            }
            else if (previousY[y,x] == y+1)
            {
               description = 'U' + description; 
            }

            
            
            int swap = y;
            y = previousY
            x = previous
        
        }
    
    }

}