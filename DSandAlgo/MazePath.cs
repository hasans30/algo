using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class MazePath
    {
        public static Cell [][] maze ;//= new Cell [3][];
        private static List<Cell> path = new List<Cell>();

        public static void FindPath(Cell [][]M, Cell start, Cell end)
        {
            start.visited = true;
            path.Add(start);

            if(start==end)
            {
                //print path
                foreach(var cell in path)
                {
                    Console.Write("({0},{1}) ->", cell.x, cell.y);
                    cell.isSolution = true;
                }
                Console.WriteLine();
                return;
            }
            List<Cell> validNeighbours = GetValidNeighbours(M,start);
            if(validNeighbours.Count==0)
            {
                path.Remove(start);
                return;
            }

            foreach (var cell in validNeighbours)
            {
                FindPath(M, cell, end);
            }
        }

        private static List<Cell> GetValidNeighbours(Cell [][] M, Cell start)
        {
            List<Cell> neighbours = new List<Cell>();
            Cell c = GetNextValidCell(M, start, 1, 0);
            if (c != null)
            {
                c.direction = 1;
                neighbours.Add(c);
            }
            c = GetNextValidCell(M, start, -1, 0);
            if (c != null)
            {
                c.direction = -1;
                neighbours.Add(c);
            }
            c = GetNextValidCell(M, start, 0, 1);
            if (c != null)
            {
                c.direction = 2;
                neighbours.Add(c);
            }
            c = GetNextValidCell(M, start, 0, -1);
            if (c != null)
            {
                c.direction = -2;
                neighbours.Add(c);
            }
            return neighbours;

            
        }

        private static Cell GetNextValidCell(Cell[][] M, Cell start, int p, int q)
        {
            int x = start.x + p;
            int y = start.y + q;
            if (x>=0&&y>=0&&x < M.Length && y < M[0].Length
                && M[x][y].visited == false
                && M[x][y].blocked == false)
                return M[x][y];
            return null;

        }

        public static void CallMaze()
        {
            maze = new Cell[6][];
            for (int i = 0; i < maze.Length; i++)
            {
                maze[i] = new Cell [maze.Length];
            }
            makeRandomMaze(maze);
            printMaze(maze);
            FindPath(maze, maze[0][0], maze[maze.Length - 1][maze[0].Length - 1]);
            Console.WriteLine("Solution:");
            printMaze(maze);


        }

        private static void printMaze(Cell[][] maze)
        {
            for (int i = 0; i < maze.Length; ++i)
            {
                for (int j = 0; j < maze[i].Length; ++j)
                {
                    //decide symbol
                    string str = "";
                    switch(maze[i][j].direction)
                    {
                        case -1: str = "<"; break;
                        case 1: str = ">"; break;
                        case -2: str = "^"; break;
                        case 2: str = "v"; break;
                    }

                    if (maze[i][j].blocked)
                        Console.Write("#|");
                    else if (maze[i][j].isSolution)
                        Console.Write("{0}|",str);
                    else
                        Console.Write("_|");
                }
                Console.WriteLine();
            }
        }


        private static void makeRandomMaze(Cell[][] maze)
        {
            Random random = new Random();
            for (int i = 0; i < maze.Length; ++i)
            {
                for (int j = 0; j < maze[0].Length; ++j)
                {
                    maze[i][j] = new Cell();
                    maze[i][j].x = i;
                    maze[i][j].y = j;
                    maze[i][j].blocked = ((random.Next() % 3) == 1);
                    maze[i][j].visited=false;
                }
            }
            maze[0][0].blocked = false;
            maze[maze.Length - 1][maze[0].Length - 1].blocked = false;

        }
    }

    public class Cell
    {
        public bool visited;
        public bool blocked;
        public int x, y;
        public bool isSolution;
        public int direction;
    }
}
