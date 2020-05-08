using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Msagl.Drawing;

namespace SpojnoscWierzcholkowaGrafu
{
	public class GraphGenerator
	{
		private int minVerticesCount;
		private int maxVerticesCount;
		private float propabilityOfEdge;

		public GraphGenerator(float propabilityOfEdge, int maxVerticesCount, int minVerticesCount)
		{
			this.propabilityOfEdge = propabilityOfEdge;
			this.maxVerticesCount = maxVerticesCount;
			this.minVerticesCount = minVerticesCount;
		}


		public Graph Generate(int[,] graphMatrix)
		{
			Graph graph = new Graph("graph");

			for (int i = 0; i < graphMatrix.GetLength(0); i++)
			{
				int noConnectionCount = 0;
				for (int j = 0; j < graphMatrix.GetLength(1); j++)
				{
					noConnectionCount++;
					if (graphMatrix[i, j] == 1)
					{
						if (!graph.Edges.Any(edge => edge.Source == j.ToString() && edge.Target == i.ToString()))
							graph.AddEdge(i.ToString(), j.ToString()).Attr.ArrowheadAtTarget = ArrowStyle.None;
					}
				}

				if (noConnectionCount == graphMatrix.GetLength(1))
					graph.AddNode(i.ToString());
			}

			return graph;
		}

		public int[,] GenerateGraphMatrix()
		{
			Random rnd = new Random();

			int vertices = rnd.Next(minVerticesCount, maxVerticesCount + 1);

			int[,] graph = new int[vertices, vertices];

			for (int i = 0; i < vertices; i++)
			{
				for (int j = 0; j < vertices; j++)
				{
					if (i != j && graph[i, j] != 1)
					{
						graph[i, j] = ((float)rnd.Next(0, 101)) / 100.0f <= propabilityOfEdge ? 1 : 0;
						if (graph[i, j] == 1)
							graph[j, i] = 1;
					}
				}
			}
			return graph;
		}
	}
}
