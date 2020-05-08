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
			Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation3 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
			this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
			this.gViewer2 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gViewer3 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
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
			this.gViewer2.EdgeInsertButtonVisible = false;
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
			this.gViewer2.Size = new System.Drawing.Size(818, 270);
			this.gViewer2.TabIndex = 0;
			this.gViewer2.TightOffsetForRouting = 0.125D;
			this.gViewer2.ToolBarIsVisible = false;
			this.gViewer2.Transform = planeTransformation2;
			this.gViewer2.UndoRedoButtonsVisible = true;
			this.gViewer2.WindowZoomButtonPressed = false;
			this.gViewer2.ZoomF = 1D;
			this.gViewer2.ZoomWindowThreshold = 0.05D;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(903, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(205, 42);
			this.button1.TabIndex = 1;
			this.button1.Text = "Wygeneruj nowy graf";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(903, 104);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(205, 42);
			this.button2.TabIndex = 2;
			this.button2.Text = "Oblicz k";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(898, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 26);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			this.label1.Visible = false;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// gViewer3
			// 
			this.gViewer3.ArrowheadLength = 10D;
			this.gViewer3.AsyncLayout = false;
			this.gViewer3.AutoScroll = true;
			this.gViewer3.BackwardEnabled = false;
			this.gViewer3.BuildHitTree = true;
			this.gViewer3.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
			this.gViewer3.EdgeInsertButtonVisible = true;
			this.gViewer3.FileName = "";
			this.gViewer3.ForwardEnabled = false;
			this.gViewer3.Graph = null;
			this.gViewer3.InsertingEdge = false;
			this.gViewer3.LayoutAlgorithmSettingsButtonVisible = true;
			this.gViewer3.LayoutEditingEnabled = true;
			this.gViewer3.Location = new System.Drawing.Point(12, 300);
			this.gViewer3.LooseOffsetForRouting = 0.25D;
			this.gViewer3.MouseHitDistance = 0.05D;
			this.gViewer3.Name = "gViewer3";
			this.gViewer3.NavigationVisible = true;
			this.gViewer3.NeedToCalculateLayout = true;
			this.gViewer3.OffsetForRelaxingInRouting = 0.6D;
			this.gViewer3.PaddingForEdgeRouting = 8D;
			this.gViewer3.PanButtonPressed = false;
			this.gViewer3.SaveAsImageEnabled = true;
			this.gViewer3.SaveAsMsaglEnabled = true;
			this.gViewer3.SaveButtonVisible = true;
			this.gViewer3.SaveGraphButtonVisible = true;
			this.gViewer3.SaveInVectorFormatEnabled = true;
			this.gViewer3.Size = new System.Drawing.Size(818, 270);
			this.gViewer3.TabIndex = 4;
			this.gViewer3.TightOffsetForRouting = 0.125D;
			this.gViewer3.ToolBarIsVisible = false;
			this.gViewer3.Transform = planeTransformation3;
			this.gViewer3.UndoRedoButtonsVisible = true;
			this.gViewer3.WindowZoomButtonPressed = false;
			this.gViewer3.ZoomF = 1D;
			this.gViewer3.ZoomWindowThreshold = 0.05D;
			this.gViewer3.Load += new System.EventHandler(this.gViewer3_Load);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(1266, 687);
			this.Controls.Add(this.gViewer3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gViewer2);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
		private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer3;
	}
}

