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

namespace SpojnoscWierzcholkowaGrafu
{
	public partial class Form1 : Form
	{
		static int[,] exampleGraph = new int[,]
		{
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0,0,0,1, 0, 0, 0, 0, 0, 0, 0, 0, 0}

		};

		public Form1()
		{
			InitializeComponent();

			Graph graph = new Graph("graph");

			for (int i = 0; i < exampleGraph.GetLength(0); i++)
			{
				for (int j = 0; j < exampleGraph.GetLength(1); j++)
				{
					if (exampleGraph[i, j] >= 1)
						graph.AddEdge(i.ToString(), j.ToString());
				}
			}

			gViewer2.Graph = graph;
		}

	}
}

