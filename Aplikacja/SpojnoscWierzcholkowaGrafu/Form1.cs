using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Color = Microsoft.Msagl.Drawing.Color;

namespace SpojnoscWierzcholkowaGrafu
{
	public partial class Form1 : Form
	{
		private GraphGenerator gg;
		private Graph mainGraph;
		private int[,] intGraph;

		public Form1()
		{
			gg = new GraphGenerator(0.33f, 10, 3);

			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			gViewer3.Graph = null;
			label1.Text = "";
			button2.Enabled = true;

			intGraph = gg.GenerateGraphMatrix();
			mainGraph = gg.Generate(intGraph);
			mainGraph.Attr.LayerDirection = LayerDirection.LR;
			gViewer2.LayoutEditingEnabled = false;
			gViewer3.LayoutEditingEnabled = false;
			gViewer2.Graph = mainGraph;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			bool isDisconnected = false;
			isDisconnected = CheckIfGraphDisconnected(isDisconnected);

			if (!isDisconnected)
			{
				CreateMstGraph();
			}
			else
			{
				gViewer3.Graph = mainGraph;
				label1.Text = "k(G) = 0";

			}

			label1.Visible = true;

		}

		private void CreateMstGraph()
		{
			int[] parent = PrimsAlgorithm.Prim(intGraph);
			Graph graph = new Graph();

			for (int i = 1; i < intGraph.GetLength(0); ++i)
				graph.AddEdge(parent[i].ToString(), i.ToString()).Attr.ArrowheadAtTarget = ArrowStyle.None;

			int[,] mst = CreateMst(parent);

			PaintMainGraphAccordingToMst(mst);

			graph.Attr.LayerDirection = LayerDirection.LR;
			gViewer3.Graph = graph;
			label1.Text = "k(G) = " + CalculateK(intGraph, mst).ToString();
		}

		private void PaintMainGraphAccordingToMst(int[,] mst)
		{
			mainGraph = new Graph();
			for (int i = 0; i < intGraph.GetLength(0); i++)
			{
				int noConnectionCount = 0;
				for (int j = 0; j < intGraph.GetLength(1); j++)
				{
					noConnectionCount++;
					if (intGraph[i, j] == 1)
					{
						if (!mainGraph.Edges.Any(edge => edge.Source == j.ToString() && edge.Target == i.ToString()))
						{
							if (intGraph[i, j] == mst[i, j])
							{
								var edge = mainGraph.AddEdge(i.ToString(), j.ToString());
								edge.Attr.ArrowheadAtTarget = ArrowStyle.None;
								edge.Attr.Color = Color.LimeGreen;
							}
							else
								mainGraph.AddEdge(i.ToString(), j.ToString()).Attr.ArrowheadAtTarget = ArrowStyle.None;
						}
					}
				}

				if (noConnectionCount == intGraph.GetLength(1))
					mainGraph.AddNode(i.ToString());
			}

			mainGraph.Attr.LayerDirection = LayerDirection.LR;
			gViewer2.Graph = mainGraph;
		}

		private bool CheckIfGraphDisconnected(bool isDisconnected)
		{
			for (int i = 0; i < intGraph.GetLength(0); i++)
			{
				int rowConnectionsCount = 0;
				for (int j = 0; j < intGraph.GetLength(0); j++)
				{
					if (intGraph[i, j] == 0)
						rowConnectionsCount++;
				}

				if (rowConnectionsCount == intGraph.GetLength(0))
					isDisconnected = true;
			}

			return isDisconnected;
		}

		private int CalculateK(int[,] orginalGraph, int[,] mst)
		{
			int k = 0;
			for (int i = 0; i < mst.GetLength(0); i++)
			{
				for (int j = 0; j < mst.GetLength(0); j++)
				{
					if (orginalGraph[i, j] != mst[i, j])
						k++;
				}
			}
			return k / 2;
		}

		private int[,] CreateMst(int[] parent)
		{
			int[,] mst = new int[parent.Length, parent.Length];
			for (int i = 1; i < parent.Length; ++i)
			{
				mst[parent[i], i] = 1;
				mst[i, parent[i]] = 1;
			}

			return mst;
		}

		private void gViewer3_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}

