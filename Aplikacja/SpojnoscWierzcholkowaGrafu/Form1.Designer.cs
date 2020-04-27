namespace SpojnoscWierzcholkowaGrafu
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation1 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
			Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation2 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
			this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
			this.gViewer2 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
			this.SuspendLayout();
			// 
			// gViewer1
			// 
			this.gViewer1.ArrowheadLength = 10D;
			this.gViewer1.AsyncLayout = false;
			this.gViewer1.AutoScroll = true;
			this.gViewer1.BackwardEnabled = false;
			this.gViewer1.BuildHitTree = true;
			this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
			this.gViewer1.EdgeInsertButtonVisible = true;
			this.gViewer1.FileName = "";
			this.gViewer1.ForwardEnabled = false;
			this.gViewer1.Graph = null;
			this.gViewer1.InsertingEdge = false;
			this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
			this.gViewer1.LayoutEditingEnabled = true;
			this.gViewer1.Location = new System.Drawing.Point(0, 0);
			this.gViewer1.LooseOffsetForRouting = 0.25D;
			this.gViewer1.MouseHitDistance = 0.05D;
			this.gViewer1.Name = "gViewer1";
			this.gViewer1.NavigationVisible = true;
			this.gViewer1.NeedToCalculateLayout = true;
			this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
			this.gViewer1.PaddingForEdgeRouting = 8D;
			this.gViewer1.PanButtonPressed = false;
			this.gViewer1.SaveAsImageEnabled = true;
			this.gViewer1.SaveAsMsaglEnabled = true;
			this.gViewer1.SaveButtonVisible = true;
			this.gViewer1.SaveGraphButtonVisible = true;
			this.gViewer1.SaveInVectorFormatEnabled = true;
			this.gViewer1.Size = new System.Drawing.Size(532, 421);
			this.gViewer1.TabIndex = 0;
			this.gViewer1.TightOffsetForRouting = 0.125D;
			this.gViewer1.ToolBarIsVisible = true;
			this.gViewer1.Transform = planeTransformation1;
			this.gViewer1.UndoRedoButtonsVisible = true;
			this.gViewer1.WindowZoomButtonPressed = false;
			this.gViewer1.ZoomF = 1D;
			this.gViewer1.ZoomWindowThreshold = 0.05D;
			// 
			// gViewer2
			// 
			this.gViewer2.ArrowheadLength = 10D;
			this.gViewer2.AsyncLayout = false;
			this.gViewer2.AutoScroll = true;
			this.gViewer2.BackwardEnabled = false;
			this.gViewer2.BuildHitTree = true;
			this.gViewer2.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
			this.gViewer2.EdgeInsertButtonVisible = true;
			this.gViewer2.FileName = "";
			this.gViewer2.ForwardEnabled = false;
			this.gViewer2.Graph = null;
			this.gViewer2.InsertingEdge = false;
			this.gViewer2.LayoutAlgorithmSettingsButtonVisible = true;
			this.gViewer2.LayoutEditingEnabled = true;
			this.gViewer2.Location = new System.Drawing.Point(12, 12);
			this.gViewer2.LooseOffsetForRouting = 0.25D;
			this.gViewer2.MouseHitDistance = 0.05D;
			this.gViewer2.Name = "gViewer2";
			this.gViewer2.NavigationVisible = true;
			this.gViewer2.NeedToCalculateLayout = true;
			this.gViewer2.OffsetForRelaxingInRouting = 0.6D;
			this.gViewer2.PaddingForEdgeRouting = 8D;
			this.gViewer2.PanButtonPressed = false;
			this.gViewer2.SaveAsImageEnabled = true;
			this.gViewer2.SaveAsMsaglEnabled = true;
			this.gViewer2.SaveButtonVisible = true;
			this.gViewer2.SaveGraphButtonVisible = true;
			this.gViewer2.SaveInVectorFormatEnabled = true;
			this.gViewer2.Size = new System.Drawing.Size(624, 410);
			this.gViewer2.TabIndex = 0;
			this.gViewer2.TightOffsetForRouting = 0.125D;
			this.gViewer2.ToolBarIsVisible = false;
			this.gViewer2.Transform = planeTransformation2;
			this.gViewer2.UndoRedoButtonsVisible = true;
			this.gViewer2.WindowZoomButtonPressed = false;
			this.gViewer2.ZoomF = 1D;
			this.gViewer2.ZoomWindowThreshold = 0.05D;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(1190, 444);
			this.Controls.Add(this.gViewer2);
			this.Name = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
		private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer2;
	}
}

