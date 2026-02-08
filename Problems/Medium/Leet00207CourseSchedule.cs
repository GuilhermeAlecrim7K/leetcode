namespace SharpLeetCode.Problems.Medium;

public class Leet00207CourseSchedule
{
    private class GraphNode(int courseNum)
    {
        private List<GraphNode> _prerequisites = new();

        public int CourseNum { get; } = courseNum;
        public void AddPrerequisite(GraphNode node) => _prerequisites.Add(node);
        public IEnumerable<GraphNode> PreRequisites { get { return _prerequisites; } }
    }

    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var graphNodes = AssembleGraph(numCourses, prerequisites);
        var visited = new bool[numCourses];
        foreach (var node in graphNodes)
        {
            if (DetectCycle(node, new bool[numCourses], visited))
                return false;
        }
        return true;
    }

    private bool DetectCycle(GraphNode node, bool[] visitedInCurrentIteration, bool[] visited)
    {
        if (visited[node.CourseNum])
            return false;
        visited[node.CourseNum] = true;
        visitedInCurrentIteration[node.CourseNum] = true;
        foreach (var p in node.PreRequisites)
        {
            if (visitedInCurrentIteration[p.CourseNum])
                return true;
            if (DetectCycle(p, visitedInCurrentIteration, visited))
                return true;
        }
        visitedInCurrentIteration[node.CourseNum] = false;
        return false;
    }

    private IEnumerable<GraphNode> AssembleGraph(int numCourses, int[][] prerequisites)
    {
        var graphNodes = Enumerable.Range(0, numCourses)
            .Select((_, index) => new GraphNode(index))
            .ToList();
        foreach (var prerequisite in prerequisites)
            graphNodes[prerequisite[0]].AddPrerequisite(graphNodes[prerequisite[1]]);

        return graphNodes;
    }
}