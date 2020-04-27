using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SpojnoscWierzcholkowaGrafu
{
	public class GraphSolver
	{
		private List<int>[] graph { get; }

		private int N;

		private List<int>[] graph1;
		private List<int>[] graph2;

		private bool[] visited1;
		private bool[] visited2;

		public GraphSolver(List<int>[] graph)
		{
			this.graph = graph;
			N = graph.Length * graph[0].Count;

			graph.CopyTo(graph1, 0);
			graph.CopyTo(graph2, 0);

			visited1 = new bool[N];
			visited2 = new bool[N];
		}

		private void Dfs1(int x)
		{
			visited1[x] = true;
			foreach (int i in graph1[x])
				if (!visited1[i])
					Dfs1(i);
		}

		private void Dfs2(int x)
		{
			visited2[x] = true;
			foreach (int i in graph2[x])
				if (!visited2[i])
					Dfs2(i);
		}

		public bool IsConnected()
		{
			for (int i = 0; i < N; i++)
				visited1[i] = false;

			Dfs1(1);

			for (int i = 0; i < N; i++)
				visited2[i] = false;

			Dfs2(1);

			for (int i = 1; i <= N; i++)
			{
				if (!visited1[i] && !visited2[i])
					return false;
			}
			return true;
		}

	}
}
