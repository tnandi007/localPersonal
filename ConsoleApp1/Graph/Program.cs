// See https://aka.ms/new-console-template for more information

int[][] array = new int[3][];
int[] arr1 = new int[4]{1,2,3,4};
int[] arr2 = { 1,2,3,4};
var arr3 = new int[4] { 1, 2,3,4 };
var arr4 = new[] { 1, 2, 3, 4 };
array[0] = new int[2];
array[1] = new int[3];
array[2] = new int[3];
int[,] arr = { {1,2 },{1,2 } };
//int[][] vs = new int[3][4];
Console.WriteLine(array.Length);
/// <summary>
/// 
/// </summary>

int[] distance=Enumerable.Repeat(int.MaxValue,5).ToArray();
PriorityQueue<int,int> queue=new PriorityQueue<int,int>();
for (int i = 0; i < 5; i++)
    queue.Enqueue(distance[i], i);

/// <summary>
/// 
/// </summary>

var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

var graph = new Graph<int>(vertices, edges);
var algorithms = new Algorithms();

Console.WriteLine(string.Join(", ", algorithms.BFS(graph, 1)));
// 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
/// <summary>
/// 
/// </summary>

var vertices2 = new[] { 0, 1, 2, 3, 4, 5, 6 };
var edges2 = new[] { Tuple.Create(0,1), Tuple.Create(0,2),Tuple.Create(1,3),Tuple.Create(3,4),
    Tuple.Create(2,4),Tuple.Create(3,5), Tuple.Create(4,5), Tuple.Create(5,6)};
var graph2 = new Graph<int>(vertices2, edges2);
var visited = new HashSet<int>();
Algorithms.DFS(graph2, 0, visited);

//0,1,3,4,2,5,6

var visited2 = new HashSet<int>();
visited2.Add(0);
Algorithms.PrintAllPAths(graph2,0,5,"" + 0,visited2);


var vertices3 = new[] { 0, 1, 2, 3, 4};
var edges3 = new[] { Tuple.Create(0, 1), Tuple.Create(0, 2), Tuple.Create(0, 3), Tuple.Create(3, 4) };//,Tuple.Create(1,2)};
var graph3 = new Graph<int>(vertices3, edges3);
var visited3 = new HashSet<int>();
Console.WriteLine(Algorithms.isCyclic(graph3, visited3));

var vertices4 = new[] { 0, 1, 2,3};
var edges4 = new[] { Tuple.Create(1, 0), Tuple.Create(0, 2), Tuple.Create(2, 3), Tuple.Create(3, 0) };//,Tuple.Create(1,2)};

//1---->0-->2
//        /   |
//       /    |
//       1<---3
var graph4 = new Graph<int>(vertices4, edges4);
var visited4 = new HashSet<int>();
Console.WriteLine(Algorithms.isCyclicD(graph4, visited4));

/// <summary>
/// 
/// </summary>

//int[][] inputGrid = new int[][] { new int[]{ 1, 1, 1, 1, 0 },new int[] { 1, 1, 0, 1, 0 },new int[] {1,1,0,0,0 }, new int[]{0,0,0,0,0 } };
int[][] inputGrid = new int[][] { new int[] { 1, 1, 0, 0, 0 }, new int[] { 1, 1, 0, 0, 0 }, new int[] { 0, 0, 1, 0, 0 }, new int[] { 0, 0, 0, 1, 1 } };
Console.WriteLine(GFG.findNumberOfIslands(inputGrid));

GFG.CanFinish(3, new int[][] { new int[] { 1, 0 }, new int[] { 2, 1 }, new int[] { 0, 2 } });
GFG.FindCheapestPrice(4, new int[][] { new int[] {0, 1, 100 },new int[] { 1, 2, 100 }, new int[] { 2, 0, 100 },new int[] { 1, 3, 600 }, new int[] { 2, 3, 200 } }, 0, 3, 1);

int V = 5;
List<BellmanFord.Edge>[] graphxy = new List<BellmanFord.Edge>[V];
BellmanFord.createGraph(graphxy);
//createGraph(graph);
int src = 0;
BellmanFord.bellmanFord(graphxy, src);

//Console.WriteLine("Hello, World!");
//Jagged Array
int[][] grid = new int[][] { new int [] {1, 1, 0},

                         new int[]{1, 0, 0},

                         new int[] {1, 9, 1}};
int rslt = minimumDistance(grid);

/// <summary>
/// dijkstras-shortest-path-algorithm-greedy-algo
/// </summary>
int[,] graph1 = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                            { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                            { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                            { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                            { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                            { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                            { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                            { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                            { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
GFG t = new GFG();

// Function call
t.dijkstra(graph1, 0);

int[][] adjMatrix = new int[][] { new int[] {0,2,4,0,0,0},
                                  new int[]{2,0,1,7,0,0},
                                  new int[]{4,1,0,0,3,0},
                                  new int[]{0,7,0,0,2,1},
                                  new int[]{ 0,0,3,2,0,5},
                                  new int[]{ 0,0,0,1,5,0}
                                };
int[] dist=Algorithms.dijkstra(adjMatrix, 0);
Console.WriteLine("Hello, World!");
string[] values = new string[] {"acre","care", "race" };
Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
foreach(string str in values)
{
    char[] chars = str.ToCharArray();
    Array.Sort(chars);
    string sorted=new string(chars);
    if (results.ContainsKey(sorted))
    {
        results[sorted].Add(str);
        continue;
    }
    List<string> list = new List<string>();
    list.Add(str);
    results.Add(sorted,list);
}


static int minimumDistance(int[][] grid)
{
    if (grid == null || grid.Length == 0)
        return -1;
    var visited = new HashSet<string>();
    Queue<int[]> q = new Queue<int[]>();
    q.Enqueue(new int[] { 0, 0 });
    visited.Add("0,0");
    int distance = 0;
    int[][] moves = new int[4][] { new int[2] { 0, 1 }, new int[2] { 0, -1 }, new int[2] { -1, 0 }, new int[2] { 1, 0 } };
    while (q.Count > 0)
    {
        int size = q.Count;
        for (int i = 0; i < size; i++)
        {
            int[] point = q.Dequeue();
            if (grid[point[0]][point[1]] == 9)
                return distance;
            foreach (int[] move in moves)
            {
                int x = point[0] + move[0];
                int y = point[1] + move[1];
                if (x >= 0 && x < grid.Length && y >= 0 && y < grid[0].Length &&
                    grid[x][y] != 0 && !visited.Contains(x + "," + y))
                {
                    q.Enqueue(new int[] { x, y });
                    visited.Add(x + "," + y);
                }
            }
        }
        distance++;
    }
    return -1;
}

public class Graph<T>
{
    public Graph() { }
    public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges)
    {
        foreach (var vertex in vertices)
            AddVertex(vertex);

        foreach (var edge in edges)
            AddEdge(edge);
    }

    public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

    public void AddVertex(T vertex)
    {
        AdjacencyList[vertex] = new HashSet<T>();
        //AdjacencyList.Add(vertex, new HashSet<T>());
        
    }

    public void AddEdge(Tuple<T, T> edge)
    {
        if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
        {
            AdjacencyList[edge.Item1].Add(edge.Item2);
            AdjacencyList[edge.Item2].Add(edge.Item1);
        }
    }
}

public class Algorithms
{
    
    public HashSet<T> BFS<T>(Graph<T> graph, T start)
    {
        //step 1: create a HashSet/Array to track the visisted vertices
        var visited = new HashSet<T>();

        if (!graph.AdjacencyList.ContainsKey(start))
            return visited;
        //step 2. Create a queueu (FIFO)
        var queue = new Queue<T>();
        //step3. Eneue the starting Vertex
        queue.Enqueue(start);
        //Run through the queue unless empty
        while (queue.Count > 0)
        {
            //Dequeue the first Vertex
            var vertex = queue.Dequeue();
            //check if visisted, then SKip otherwise continue
            if (visited.Contains(vertex))
                continue;
            // Add the Vertex to the visisted HashSet
            visited.Add(vertex);
            // For each neighbour of the vertex, add them to the queue if not visisted
            foreach (var neighbor in graph.AdjacencyList[vertex])
                if (!visited.Contains(neighbor))
                    queue.Enqueue(neighbor);
        }

        return visited;
    }

    public static void DFS<T>(Graph<T> graph, T current, HashSet<T> visited )
    {
        //Base case for recursion
        if (visited.Contains(current))
            return;

        Console.WriteLine(current);
        visited.Add(current);
        foreach(var neighbor in graph.AdjacencyList[current])
        {
            DFS(graph, neighbor, visited);
        }

    }

    public static void PrintAllPAths(Graph<int> graph, int source, int destination, string path, HashSet<int> visited)
    {
        if (source == destination)
        { Console.WriteLine(path); 
            return; }

        foreach(var neighbor in graph.AdjacencyList[source])
        {
            if (!visited.Contains(neighbor))
            {
                visited.Add(neighbor);
                PrintAllPAths(graph, neighbor, destination, path + "->" + neighbor, visited);
                visited.Remove(neighbor);
            }
        }

    }

    public static bool isCyclic(Graph<int> graph, HashSet<int> visited)
    {
        foreach( var vertex in graph.AdjacencyList.Keys)
        {
            if(!visited.Contains(vertex))
            if(isCyclicUtil(graph,visited,vertex,-1))
                return true;

        }
        return false;
    }

    //for undirected graph
  //   0---3-----4
  //   /\
  //  /  \
  // /    \
  //1------2
    
    public static bool isCyclicUtil(Graph<int> graph, HashSet<int> visited, int curr, int parent)
    {
        visited.Add(curr);

        foreach(var neighbor in graph.AdjacencyList[curr])
        {
           
            if (!visited.Contains(neighbor))
            {
                bool isCycle = isCyclicUtil(graph, visited, neighbor, curr);
                if (isCycle) return true;
            }
            else if (neighbor != parent)
            {
                return true;
            }
            //else return true;

        }

        return false;
    }

    public static bool isCyclicD(Graph<int> graph, HashSet<int> visited)
    {
        HashSet<int> stackArray=new HashSet<int>();
        foreach (var vertex in graph.AdjacencyList.Keys)
        {
            if (!visited.Contains(vertex))
                if (isCyclicUtilD(graph, visited, vertex, stackArray))
                    return true;

        }
        return false;
    }
    public static bool isCyclicUtilD(Graph<int> graph, HashSet<int> visited, int curr, HashSet<int> stackArr)
    {
        visited.Add(curr);
        stackArr.Add(curr);

        foreach (var neighbor in graph.AdjacencyList[curr])
        {
            if(stackArr.Contains(neighbor))
                return true;
            else if (!visited.Contains(neighbor))
            {
                bool isCycle = isCyclicUtilD(graph, visited, neighbor, stackArr);
                if (isCycle) return true;
            }                  

        }
        stackArr.Remove(curr);
        return false;
    }

    public static int[] dijkstra(int[][] adjMatrix, int src)//(ArrayList<Edge> graph[], int src)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(); //(vertex, ditance[vertext]) priority is distance 
        int[] dist = Enumerable.Repeat(int.MaxValue, adjMatrix.Length).ToArray();
        dist[src] = 0;
        bool[] vis = Enumerable.Repeat(false, adjMatrix.Length).ToArray();

        pq.Enqueue(src, 0);
        //while (!pq.isEmpty())
        while (pq.Count > 0)
        {
            // Pair curr = pq.remove();
            var u = pq.Dequeue();
            //if (!vis[curr.n])
            if (!vis[u])
            {
                //vis[curr.n] = true;
                vis[u] = true;
                for (int v = 0; v < adjMatrix[u].Length; v++)
                {
                    if (adjMatrix[u][v] > 0)
                    {
                        //perform relaxation
                        if (dist[u] != int.MaxValue && dist[v] > dist[u] + adjMatrix[u][v])
                        {
                            dist[v] = dist[u] + adjMatrix[u][v];
                            //parent[v] = u;
                        }
                        pq.Enqueue(v, dist[v]);
                    }
                }

                
            }
        }
        return dist;
    }

}

class GFG
{
    // A utility function to find the
    // vertex with minimum distance
    // value, from the set of vertices
    // not yet included in shortest
    // path tree
    static int V = 9;
    int minDistance(int[] dist, bool[] sptSet)
    {
        // Initialize min value
        int min = int.MaxValue, min_index = -1;

        for (int v = 0; v < V; v++)
            if (sptSet[v] == false && dist[v] <= min)
            {
                min = dist[v];
                min_index = v;
            }

        return min_index;
    }

    // A utility function to print
    // the constructed distance array
    void printSolution(int[] dist)
    {
        Console.Write("Vertex \t\t Distance "
                      + "from Source\n");
        for (int i = 0; i < V; i++)
            Console.Write(i + " \t\t " + dist[i] + "\n");
    }

    // Function that implements Dijkstra's
    // single source shortest path algorithm
    // for a graph represented using adjacency
    // matrix representation
    public void dijkstra(int[,] graph, int src)
    {
        int[] dist
            = new int[V]; // The output array. dist[i]
                          // will hold the shortest
                          // distance from src to i

        // sptSet[i] will true if vertex
        // i is included in shortest path
        // tree or shortest distance from
        // src to i is finalized
        bool[] sptSet = new bool[V];

        // Initialize all distances as
        // INFINITE and stpSet[] as false
        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        // Distance of source vertex
        // from itself is always 0
        dist[src] = 0;

        // Find shortest path for all vertices
        for (int count = 0; count < V - 1; count++)
        {
            // Pick the minimum distance vertex
            // from the set of vertices not yet
            // processed. u is always equal to
            // src in first iteration.
            int u = minDistance(dist, sptSet);

            // Mark the picked vertex as processed
            sptSet[u] = true;

            // Update dist value of the adjacent
            // vertices of the picked vertex.
            for (int v = 0; v < V; v++)

                // Update dist[v] only if is not in
                // sptSet, there is an edge from u
                // to v, and total weight of path
                // from src to v through u is smaller
                // than current value of dist[v]
                if (!sptSet[v] && graph[u, v] != 0
                    && dist[u] != int.MaxValue
                    && dist[u] + graph[u, v] < dist[v])
                    dist[v] = dist[u] + graph[u, v];
        }

        // print the constructed distance array
        printSolution(dist);
    }

    /*
    Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's
    (water), return the number of islands.
    An island is surrounded by water and is formed by connecting adjacent lands
    horizontally or vertically. You may assume all four edges of the grid are all
    surrounded by water.
    Example 1
    Input: grid = [
        ["1", "1", "1", "1", "0"],
        ["1","1","0","1","0"],
        ["1","1","0","0","0"],
        ["0","0","0","0","0"]
    ]
    Output: 1
    Example 2
    Input: grid = [
    ["1","1","0","0","0"],
    ["1","1","0","0","0"],
    ["0","0","1","0","0"],
    ["0","0","0","1","1"]
    ]
    Output: 3
    */

    public static int findNumberOfIslands(int[][] grid)
    {
        int rows = grid.Length;
        int columns = grid[0].Length;

        int count = 0;

        for(int i=0; i< rows; i++)
        {
            for(int j=0; j<columns;j++)
            {

                if(grid[i][j]==1)
                {
                    count++;
                    DetectIsland(i, j, grid);
                }
                
            }
        }

         
        return count;
    }

    public static void  DetectIsland(int row, int column, int[][] grid)
    {
        if (row < 0 || column < 0 || row >= grid.Length || column >= grid[row].Length || grid[row][column] == 0)
            return;

        grid[row][column] = 0; 
        DetectIsland(row+1, column, grid);
        DetectIsland(row-1, column, grid);
        DetectIsland(row, column+1, grid);
        DetectIsland(row,column-1, grid);

    }

    /*There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1. You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course bi first if you want to take course ai.

      For example, the pair[0, 1], indicates that to take course 0 you have to first take course 1.
    Return true if you can finish all courses.Otherwise, return false.

    Example 1:

    Input: numCourses = 2, prerequisites = [[1,0]]
    Output: true
    Explanation: There are a total of 2 courses to take.
    To take course 1 you should have finished course 0. So it is possible.
    Example 2:

    Input: numCourses = 2, prerequisites = [[1,0],[0,1]]
    Output: false
    Explanation: There are a total of 2 courses to take.
    To take course 1 you should have finished course 0, and to take course 0 you should also have finished course 1. So it is impossible.*/

    public static bool CanFinish(int numCourses, int[][] prerequisites)
    {
        
        Dictionary<int, HashSet<int>> adjList=new Dictionary<int, HashSet<int>>();

        for(int i = 0; i < numCourses; i++)
        {
            adjList.Add(i, new HashSet<int>());
        }

        foreach(var list in prerequisites)
        {
            if(adjList.ContainsKey(list[0]) && adjList.ContainsKey(list[1]))
            {
                adjList[list[0]].Add(list[1]);
                adjList[list[1]].Add(list[0]);
            }
        }

        
        
        HashSet<int> stackArray = new HashSet<int>();
        var visited = new HashSet<int>();
        //foreach (var vertex in graph.AdjacencyList.Keys)
        //{
        //    if (!visited.Contains(vertex))
        //        if (Algorithms.isCyclicUtilD(graph, visited, vertex, stackArray))
        //            return true;

        //}
        //return false;
        //bool[] visited=new bool[numCourses];
        //foreach (var vertex in adjList.Keys)
        //{
        //    if(!visited.Contains(vertex))
        //        if (isCyclicUtil(adjList, visited, vertex, stackArray))
        //        return true;
        //}
        
        if (prerequisites == null || prerequisites.Length == 0)
            return true;

        List<int>[] g = new List<int>[numCourses];
        int[] indegree = new int[numCourses];
        Queue<int> q = new Queue<int>();
        int nodeCount = 0;

        foreach (var item in prerequisites)
        {
            if (g[item[0]] == null)
                g[item[0]] = new List<int>();

            g[item[0]].Add(item[1]);
            indegree[item[1]] += 1;
        }

        for (int vertex=0;vertex<numCourses; vertex++)//adjList.Keys)
        {
            if (!visited.Contains(vertex))
                if (isCyclicUtil(g, visited, vertex, stackArray))
                    return true;
        }

        for (int i = 0; i < numCourses; i++)
            if (indegree[i] == 0)
                q.Enqueue(i);

        while (q.Count > 0)
        {
            int cur = q.Dequeue();

            if (g[cur] != null)
                foreach (var item in g[cur])
                    if (--indegree[item] == 0)
                        q.Enqueue(item);

            nodeCount++;
        }

        return nodeCount == numCourses;
    }

    public static bool isCyclicUtil(List<int>[] AdjacencyList, HashSet<int> visited, int curr, HashSet<int> stackArr)
    {
        visited.Add(curr);
        stackArr.Add(curr);
        if (AdjacencyList[curr] != null)
        {
            foreach (var neighbor in AdjacencyList[curr])
            {
                if (stackArr.Contains(neighbor))
                    return true;
                else if (!visited.Contains(neighbor))
                {
                    bool isCycle = isCyclicUtil(AdjacencyList, visited, neighbor, stackArr);
                    if (isCycle) return true;
                }

            }
            stackArr.Remove(curr);
        }
        else
        {
            stackArr.Remove(curr);
        }
        return false;
    }

    public static int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        int[] dist = new int[n];
        Array.Fill(dist, int.MaxValue);
        dist[src] = 0;
        for (int i = 0; i <= k; i++)
        {
            int[] temp = dist.ToArray();
            foreach (int[] flight in flights)
            {
                if (dist[flight[0]] != int.MaxValue)
                {
                    temp[flight[1]] = Math.Min(temp[flight[1]], dist[flight[0]] + flight[2]);
                }
            }
            dist = temp;
        }
        return dist[dst] == int.MaxValue ? -1 : dist[dst];
    }
}


public  class BellmanFord
{
    public class Edge
    {
        public int src;
        public int dest;
        public int wt;
        public Edge(int s, int d, int w)
        {
            this.src = s;
            this.dest = d;
            this.wt = w;
        }
    }
    public static void createGraph(List<Edge>[] graph)
    {
        for (int i = 0; i < graph.Length; i++)
        {
            graph[i] = new List<Edge>();
        }
        graph[0].Add(new Edge(0, 1, 100));
        graph[1].Add(new Edge(1,2,100));
        graph[1].Add(new Edge(1, 3, 600));
        graph[2].Add(new Edge(2, 0, 100));       
        graph[2].Add(new Edge(2, 3, 200));
        //graph[4].Add(new Edge(4, 1, -1));
    }
    public static void bellmanFord(List<Edge>[] graph, int src)
    {
        int[] dist = new int[graph.Length];
        for (int i = 0; i < dist.Length; i++)
        {
            if (i != src)
                dist[i] = int.MaxValue;
        }
        //O(V)
        for (int i = 0; i <= 1; i++)
        {
            int[] temp=dist.ToArray();//
            //edges - O(E)
            for (int j = 0; j < graph.Length; j++)
            {
                foreach (Edge e in graph[j])
                {
                    //Edge e = graph[k];
                    int u = e.src;
                    int v = e.dest;
                    int wt = e.wt;
                    //if (dist[u] != int.MaxValue && dist[u] + wt < dist[v])
                    //{
                    //    dist[v] = dist[u] + wt;
                    //}
                    if (dist[u] != int.MaxValue)
                    {
                        temp[v] = Math.Min(temp[v], dist[u] + wt);
                    }
                }
            }

            dist = temp;
            //for (int k = 0; k < graph[j].Count; k++)

            //{
            //    Edge e = graph[k];
            //    int u = e.src;
            //    int v = e.dest;
            //    int wt = e.wt;
            //    if (dist[u] != Integer.MAX_VALUE && dist[u] + wt < dist[v])
            //    {
            //        dist[v] = dist[u] + wt;
            //    }
            //}
        }

        //Detecting Negative Weight Cycle
        //for (int j = 0; j < graph.length; j++)
        //{
        //    for (int k = 0; k < graph[j].size(); k++)
        //    {
        //        Edge e = graph[j].get(k);
        //        int u = e.src;
        //        int v = e.dest;
        //        int wt = e.wt;
        //        if (dist[u] != Integer.MAX_VALUE && dist[u] + wt < dist[v])
        //        {
        //            System.out.println("negative weight cycle exists");
        //            break;
        //        }
        //    }
        //}
        for (int i = 0; i < dist.Length; i++)
        {
            Console.WriteLine(dist[i]);
        }
        Console.WriteLine();
    }
    }
