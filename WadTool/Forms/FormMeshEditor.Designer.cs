﻿namespace WadTool
{
    partial class FormMeshEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstMeshes = new DarkUI.Controls.DarkTreeView();
            this.panelMesh = new WadTool.Controls.PanelRenderingMesh();
            this.btCancel = new DarkUI.Controls.DarkButton();
            this.btOk = new DarkUI.Controls.DarkButton();
            this.panelEditingTools = new DarkUI.Controls.DarkSectionPanel();
            this.butAlpha = new DarkUI.Controls.DarkButton();
            this.butWire = new DarkUI.Controls.DarkButton();
            this.tabsModes = new TombLib.Controls.DarkTabbedContainer();
            this.tabVertexRemap = new System.Windows.Forms.TabPage();
            this.butAutoFit = new DarkUI.Controls.DarkButton();
            this.nudVertexNum = new DarkUI.Controls.DarkNumericUpDown();
            this.butFindVertex = new DarkUI.Controls.DarkButton();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.butRemapVertex = new DarkUI.Controls.DarkButton();
            this.tabVertexShadesAndNormals = new System.Windows.Forms.TabPage();
            this.butApplyShadesToAllVertices = new DarkUI.Controls.DarkButton();
            this.panelColor = new DarkUI.Controls.DarkPanel();
            this.butRecalcNormalsAvg = new DarkUI.Controls.DarkButton();
            this.darkLabel7 = new DarkUI.Controls.DarkLabel();
            this.darkLabel10 = new DarkUI.Controls.DarkLabel();
            this.butRecalcNormals = new DarkUI.Controls.DarkButton();
            this.tabVertexEffects = new System.Windows.Forms.TabPage();
            this.butPreview = new DarkUI.Controls.DarkButton();
            this.butConvertFromShades = new DarkUI.Controls.DarkButton();
            this.nudMove = new DarkUI.Controls.DarkNumericUpDown();
            this.darkLabel5 = new DarkUI.Controls.DarkLabel();
            this.nudGlow = new DarkUI.Controls.DarkNumericUpDown();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.butApplyToAllVertices = new DarkUI.Controls.DarkButton();
            this.tabSphere = new System.Windows.Forms.TabPage();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.butResetSphere = new DarkUI.Controls.DarkButton();
            this.nudSphereRadius = new DarkUI.Controls.DarkNumericUpDown();
            this.darkLabel9 = new DarkUI.Controls.DarkLabel();
            this.nudSphereZ = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSphereY = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSphereX = new DarkUI.Controls.DarkNumericUpDown();
            this.darkLabel8 = new DarkUI.Controls.DarkLabel();
            this.tabFaceAttributes = new System.Windows.Forms.TabPage();
            this.cbTexture = new DarkUI.Controls.DarkCheckBox();
            this.cbBlendMode = new DarkUI.Controls.DarkComboBox();
            this.butApplyToAllFaces = new DarkUI.Controls.DarkButton();
            this.cbBlend = new DarkUI.Controls.DarkCheckBox();
            this.nudShineStrength = new DarkUI.Controls.DarkNumericUpDown();
            this.cbSheen = new DarkUI.Controls.DarkCheckBox();
            this.butDoubleSide = new DarkUI.Controls.DarkButton();
            this.cbExtra = new DarkUI.Controls.DarkCheckBox();
            this.cbEditingMode = new DarkUI.Controls.DarkComboBox();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.panelMain = new DarkUI.Controls.DarkPanel();
            this.panelCenter = new DarkUI.Controls.DarkPanel();
            this.panelEditing = new DarkUI.Controls.DarkPanel();
            this.panelTexturinga = new DarkUI.Controls.DarkSectionPanel();
            this.panelTextureMap = new WadTool.Controls.PanelTextureMap();
            this.panelTexturingTools = new DarkUI.Controls.DarkPanel();
            this.butAllTextures = new DarkUI.Controls.DarkButton();
            this.butExportTexture = new DarkUI.Controls.DarkButton();
            this.butAddTexture = new DarkUI.Controls.DarkButton();
            this.butDeleteTexture = new DarkUI.Controls.DarkButton();
            this.comboCurrentTexture = new DarkUI.Controls.DarkComboBox();
            this.panelTree = new DarkUI.Controls.DarkPanel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusLabel = new DarkUI.Controls.DarkLabel();
            this.panelEditingTools.SuspendLayout();
            this.tabsModes.SuspendLayout();
            this.tabVertexRemap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertexNum)).BeginInit();
            this.tabVertexShadesAndNormals.SuspendLayout();
            this.tabVertexEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlow)).BeginInit();
            this.tabSphere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSphereRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSphereZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSphereY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSphereX)).BeginInit();
            this.tabFaceAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShineStrength)).BeginInit();
            this.darkSectionPanel2.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelEditing.SuspendLayout();
            this.panelTexturinga.SuspendLayout();
            this.panelTexturingTools.SuspendLayout();
            this.panelTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMeshes
            // 
            this.lstMeshes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstMeshes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMeshes.EvenNodeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstMeshes.ExpandOnDoubleClick = false;
            this.lstMeshes.FocusedNodeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(110)))), ((int)(((byte)(175)))));
            this.lstMeshes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstMeshes.Location = new System.Drawing.Point(1, 25);
            this.lstMeshes.MaxDragChange = 20;
            this.lstMeshes.Name = "lstMeshes";
            this.lstMeshes.NonFocusedNodeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.lstMeshes.OddNodeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.lstMeshes.Size = new System.Drawing.Size(257, 534);
            this.lstMeshes.TabIndex = 1;
            this.lstMeshes.Text = "darkTreeView1";
            this.lstMeshes.Click += new System.EventHandler(this.lstMeshes_Click);
            this.lstMeshes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMeshes_KeyDown);
            // 
            // panelMesh
            // 
            this.panelMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMesh.Location = new System.Drawing.Point(0, 1);
            this.panelMesh.Name = "panelMesh";
            this.panelMesh.Size = new System.Drawing.Size(374, 558);
            this.panelMesh.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Checked = false;
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(898, 571);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(81, 23);
            this.btCancel.TabIndex = 52;
            this.btCancel.Text = "Cancel";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.Checked = false;
            this.btOk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOk.Location = new System.Drawing.Point(811, 571);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(81, 23);
            this.btOk.TabIndex = 53;
            this.btOk.Text = "OK";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // panelEditingTools
            // 
            this.panelEditingTools.Controls.Add(this.butAlpha);
            this.panelEditingTools.Controls.Add(this.butWire);
            this.panelEditingTools.Controls.Add(this.tabsModes);
            this.panelEditingTools.Controls.Add(this.cbExtra);
            this.panelEditingTools.Controls.Add(this.cbEditingMode);
            this.panelEditingTools.Controls.Add(this.darkLabel2);
            this.panelEditingTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEditingTools.Location = new System.Drawing.Point(4, 399);
            this.panelEditingTools.Name = "panelEditingTools";
            this.panelEditingTools.SectionHeader = "Editing tools";
            this.panelEditingTools.Size = new System.Drawing.Size(333, 161);
            this.panelEditingTools.TabIndex = 54;
            // 
            // butAlpha
            // 
            this.butAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butAlpha.Checked = false;
            this.butAlpha.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAlpha.Image = global::WadTool.Properties.Resources.actions_AlphaTest_16;
            this.butAlpha.Location = new System.Drawing.Point(211, 29);
            this.butAlpha.Name = "butAlpha";
            this.butAlpha.Size = new System.Drawing.Size(24, 23);
            this.butAlpha.TabIndex = 12;
            this.butAlpha.Tag = "";
            this.toolTip.SetToolTip(this.butAlpha, "Toggle transparency");
            this.butAlpha.Click += new System.EventHandler(this.butAlpha_Click);
            // 
            // butWire
            // 
            this.butWire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butWire.Checked = false;
            this.butWire.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butWire.Image = global::WadTool.Properties.Resources.wireframe_16;
            this.butWire.Location = new System.Drawing.Point(181, 29);
            this.butWire.Name = "butWire";
            this.butWire.Size = new System.Drawing.Size(24, 23);
            this.butWire.TabIndex = 11;
            this.butWire.Tag = "";
            this.toolTip.SetToolTip(this.butWire, "Toggle wireframe mode");
            this.butWire.Click += new System.EventHandler(this.butWire_Click);
            // 
            // tabsModes
            // 
            this.tabsModes.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabsModes.Controls.Add(this.tabVertexRemap);
            this.tabsModes.Controls.Add(this.tabVertexShadesAndNormals);
            this.tabsModes.Controls.Add(this.tabVertexEffects);
            this.tabsModes.Controls.Add(this.tabSphere);
            this.tabsModes.Controls.Add(this.tabFaceAttributes);
            this.tabsModes.Location = new System.Drawing.Point(1, 58);
            this.tabsModes.Multiline = true;
            this.tabsModes.Name = "tabsModes";
            this.tabsModes.SelectedIndex = 0;
            this.tabsModes.Size = new System.Drawing.Size(331, 102);
            this.tabsModes.TabIndex = 7;
            // 
            // tabVertexRemap
            // 
            this.tabVertexRemap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabVertexRemap.Controls.Add(this.butAutoFit);
            this.tabVertexRemap.Controls.Add(this.nudVertexNum);
            this.tabVertexRemap.Controls.Add(this.butFindVertex);
            this.tabVertexRemap.Controls.Add(this.darkLabel1);
            this.tabVertexRemap.Controls.Add(this.butRemapVertex);
            this.tabVertexRemap.Location = new System.Drawing.Point(4, 4);
            this.tabVertexRemap.Name = "tabVertexRemap";
            this.tabVertexRemap.Size = new System.Drawing.Size(323, 58);
            this.tabVertexRemap.TabIndex = 0;
            this.tabVertexRemap.Text = "Vertex remap";
            // 
            // butAutoFit
            // 
            this.butAutoFit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butAutoFit.Checked = false;
            this.butAutoFit.Location = new System.Drawing.Point(2, 32);
            this.butAutoFit.Name = "butAutoFit";
            this.butAutoFit.Size = new System.Drawing.Size(319, 23);
            this.butAutoFit.TabIndex = 6;
            this.butAutoFit.Text = "Automatic fit";
            this.toolTip.SetToolTip(this.butAutoFit, "Try to automatically remap all vertices sitting on mesh holes.\r\nFor legacy engine" +
        "s, you still have to manually remap hair hole.");
            this.butAutoFit.Click += new System.EventHandler(this.butAutoFit_Click);
            // 
            // nudVertexNum
            // 
            this.nudVertexNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudVertexNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudVertexNum.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudVertexNum.Location = new System.Drawing.Point(91, 3);
            this.nudVertexNum.LoopValues = false;
            this.nudVertexNum.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudVertexNum.Name = "nudVertexNum";
            this.nudVertexNum.Size = new System.Drawing.Size(69, 23);
            this.nudVertexNum.TabIndex = 2;
            this.toolTip.SetToolTip(this.nudVertexNum, "Vertex number to operate with");
            this.nudVertexNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudVertexNum_KeyDown);
            // 
            // butFindVertex
            // 
            this.butFindVertex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butFindVertex.Checked = false;
            this.butFindVertex.Image = global::WadTool.Properties.Resources.general_search_16;
            this.butFindVertex.Location = new System.Drawing.Point(166, 3);
            this.butFindVertex.Name = "butFindVertex";
            this.butFindVertex.Size = new System.Drawing.Size(77, 23);
            this.butFindVertex.TabIndex = 5;
            this.butFindVertex.Text = "Jump to";
            this.butFindVertex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.butFindVertex, "Jump to specified vertex number");
            this.butFindVertex.Click += new System.EventHandler(this.butFindVertex_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(3, 6);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(84, 13);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Vertex number:";
            // 
            // butRemapVertex
            // 
            this.butRemapVertex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRemapVertex.Checked = false;
            this.butRemapVertex.Image = global::WadTool.Properties.Resources.replace_16;
            this.butRemapVertex.Location = new System.Drawing.Point(247, 3);
            this.butRemapVertex.Name = "butRemapVertex";
            this.butRemapVertex.Size = new System.Drawing.Size(74, 23);
            this.butRemapVertex.TabIndex = 3;
            this.butRemapVertex.Text = "Remap";
            this.butRemapVertex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.butRemapVertex, "Remap selected vertex to specified vertex number");
            this.butRemapVertex.Click += new System.EventHandler(this.butRemapVertex_Click);
            // 
            // tabVertexShadesAndNormals
            // 
            this.tabVertexShadesAndNormals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabVertexShadesAndNormals.Controls.Add(this.butApplyShadesToAllVertices);
            this.tabVertexShadesAndNormals.Controls.Add(this.panelColor);
            this.tabVertexShadesAndNormals.Controls.Add(this.butRecalcNormalsAvg);
            this.tabVertexShadesAndNormals.Controls.Add(this.darkLabel7);
            this.tabVertexShadesAndNormals.Controls.Add(this.darkLabel10);
            this.tabVertexShadesAndNormals.Controls.Add(this.butRecalcNormals);
            this.tabVertexShadesAndNormals.Location = new System.Drawing.Point(4, 4);
            this.tabVertexShadesAndNormals.Name = "tabVertexShadesAndNormals";
            this.tabVertexShadesAndNormals.Padding = new System.Windows.Forms.Padding(3);
            this.tabVertexShadesAndNormals.Size = new System.Drawing.Size(323, 58);
            this.tabVertexShadesAndNormals.TabIndex = 3;
            this.tabVertexShadesAndNormals.Text = "Normals & shades";
            // 
            // butApplyShadesToAllVertices
            // 
            this.butApplyShadesToAllVertices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butApplyShadesToAllVertices.Checked = false;
            this.butApplyShadesToAllVertices.Location = new System.Drawing.Point(222, 32);
            this.butApplyShadesToAllVertices.Name = "butApplyShadesToAllVertices";
            this.butApplyShadesToAllVertices.Size = new System.Drawing.Size(99, 23);
            this.butApplyShadesToAllVertices.TabIndex = 18;
            this.butApplyShadesToAllVertices.Text = "Apply to all";
            this.toolTip.SetToolTip(this.butApplyShadesToAllVertices, "Apply specified vertex shade to all vertices");
            this.butApplyShadesToAllVertices.Click += new System.EventHandler(this.butApplyShadesToAllVertices_Click);
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelColor.Location = new System.Drawing.Point(117, 32);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(99, 23);
            this.panelColor.TabIndex = 16;
            this.panelColor.Tag = "";
            this.toolTip.SetToolTip(this.panelColor, "Vertex shade (color) to apply");
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // butRecalcNormalsAvg
            // 
            this.butRecalcNormalsAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRecalcNormalsAvg.Checked = false;
            this.butRecalcNormalsAvg.Location = new System.Drawing.Point(222, 3);
            this.butRecalcNormalsAvg.Name = "butRecalcNormalsAvg";
            this.butRecalcNormalsAvg.Size = new System.Drawing.Size(99, 23);
            this.butRecalcNormalsAvg.TabIndex = 23;
            this.butRecalcNormalsAvg.Text = "Averaged";
            this.toolTip.SetToolTip(this.butRecalcNormalsAvg, "Averaged normals recalculation is more rough and straighforward way,\r\nbut still m" +
        "ay be useful in some cases.");
            this.butRecalcNormalsAvg.Click += new System.EventHandler(this.butRecalcNormalsAvg_Click);
            // 
            // darkLabel7
            // 
            this.darkLabel7.AutoSize = true;
            this.darkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel7.Location = new System.Drawing.Point(3, 35);
            this.darkLabel7.Name = "darkLabel7";
            this.darkLabel7.Size = new System.Drawing.Size(110, 13);
            this.darkLabel7.TabIndex = 21;
            this.darkLabel7.Text = "Vertex shade (color):";
            // 
            // darkLabel10
            // 
            this.darkLabel10.AutoSize = true;
            this.darkLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel10.Location = new System.Drawing.Point(3, 8);
            this.darkLabel10.Name = "darkLabel10";
            this.darkLabel10.Size = new System.Drawing.Size(112, 13);
            this.darkLabel10.TabIndex = 22;
            this.darkLabel10.Text = "Recalculate normals:";
            // 
            // butRecalcNormals
            // 
            this.butRecalcNormals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butRecalcNormals.Checked = false;
            this.butRecalcNormals.Location = new System.Drawing.Point(117, 3);
            this.butRecalcNormals.Name = "butRecalcNormals";
            this.butRecalcNormals.Size = new System.Drawing.Size(99, 23);
            this.butRecalcNormals.TabIndex = 20;
            this.butRecalcNormals.Text = "Weighted";
            this.toolTip.SetToolTip(this.butRecalcNormals, "Weighted normals recalculation gives better results\r\nbecause it takes angles betw" +
        "een different faces in consideration.");
            this.butRecalcNormals.Click += new System.EventHandler(this.butRecalcNormals_Click);
            // 
            // tabVertexEffects
            // 
            this.tabVertexEffects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabVertexEffects.Controls.Add(this.butPreview);
            this.tabVertexEffects.Controls.Add(this.butConvertFromShades);
            this.tabVertexEffects.Controls.Add(this.nudMove);
            this.tabVertexEffects.Controls.Add(this.darkLabel5);
            this.tabVertexEffects.Controls.Add(this.nudGlow);
            this.tabVertexEffects.Controls.Add(this.darkLabel4);
            this.tabVertexEffects.Controls.Add(this.butApplyToAllVertices);
            this.tabVertexEffects.Location = new System.Drawing.Point(4, 4);
            this.tabVertexEffects.Name = "tabVertexEffects";
            this.tabVertexEffects.Padding = new System.Windows.Forms.Padding(3);
            this.tabVertexEffects.Size = new System.Drawing.Size(323, 58);
            this.tabVertexEffects.TabIndex = 2;
            this.tabVertexEffects.Text = "Vertex effects";
            // 
            // butPreview
            // 
            this.butPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butPreview.Checked = false;
            this.butPreview.Image = global::WadTool.Properties.Resources.play_16;
            this.butPreview.Location = new System.Drawing.Point(222, 3);
            this.butPreview.Name = "butPreview";
            this.butPreview.Size = new System.Drawing.Size(99, 23);
            this.butPreview.TabIndex = 21;
            this.butPreview.Tag = "";
            this.butPreview.Text = "Preview";
            this.butPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.butPreview, "Preview effects");
            this.butPreview.Click += new System.EventHandler(this.butPreview_Click);
            // 
            // butConvertFromShades
            // 
            this.butConvertFromShades.Checked = false;
            this.butConvertFromShades.Location = new System.Drawing.Point(4, 32);
            this.butConvertFromShades.Name = "butConvertFromShades";
            this.butConvertFromShades.Size = new System.Drawing.Size(212, 23);
            this.butConvertFromShades.TabIndex = 20;
            this.butConvertFromShades.Text = "Convert from shades";
            this.toolTip.SetToolTip(this.butConvertFromShades, "Convert vertex effects from legacy workflow involving vertex shades.");
            this.butConvertFromShades.Click += new System.EventHandler(this.butConvertFromShades_Click);
            // 
            // nudMove
            // 
            this.nudMove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudMove.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudMove.Location = new System.Drawing.Point(151, 3);
            this.nudMove.LoopValues = false;
            this.nudMove.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.nudMove.Name = "nudMove";
            this.nudMove.Size = new System.Drawing.Size(65, 23);
            this.nudMove.TabIndex = 14;
            this.toolTip.SetToolTip(this.nudMove, "For legacy engines, any value above 0 results in constant movement only for merge" +
        "d statics.\r\nIn such case, movement strength is derived from room effect strength" +
        ".\r\n");
            // 
            // darkLabel5
            // 
            this.darkLabel5.AutoSize = true;
            this.darkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel5.Location = new System.Drawing.Point(109, 6);
            this.darkLabel5.Name = "darkLabel5";
            this.darkLabel5.Size = new System.Drawing.Size(38, 13);
            this.darkLabel5.TabIndex = 13;
            this.darkLabel5.Text = "Move:";
            // 
            // nudGlow
            // 
            this.nudGlow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudGlow.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudGlow.Location = new System.Drawing.Point(40, 3);
            this.nudGlow.LoopValues = false;
            this.nudGlow.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.nudGlow.Name = "nudGlow";
            this.nudGlow.Size = new System.Drawing.Size(65, 23);
            this.nudGlow.TabIndex = 12;
            this.toolTip.SetToolTip(this.nudGlow, "For legacy engines, any value above 0 results in constant glow only for merged st" +
        "atics.\r\nIn such case, glow strength is derived from room effect strength.");
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(1, 6);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(37, 13);
            this.darkLabel4.TabIndex = 11;
            this.darkLabel4.Text = "Glow:";
            // 
            // butApplyToAllVertices
            // 
            this.butApplyToAllVertices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butApplyToAllVertices.Checked = false;
            this.butApplyToAllVertices.Location = new System.Drawing.Point(222, 32);
            this.butApplyToAllVertices.Name = "butApplyToAllVertices";
            this.butApplyToAllVertices.Size = new System.Drawing.Size(99, 23);
            this.butApplyToAllVertices.TabIndex = 10;
            this.butApplyToAllVertices.Text = "Apply to all";
            this.toolTip.SetToolTip(this.butApplyToAllVertices, "Apply specified vertex attributes to all faces");
            this.butApplyToAllVertices.Click += new System.EventHandler(this.butApplyToAllVertices_Click);
            // 
            // tabSphere
            // 
            this.tabSphere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabSphere.Controls.Add(this.darkLabel6);
            this.tabSphere.Controls.Add(this.darkLabel3);
            this.tabSphere.Controls.Add(this.butResetSphere);
            this.tabSphere.Controls.Add(this.nudSphereRadius);
            this.tabSphere.Controls.Add(this.darkLabel9);
            this.tabSphere.Controls.Add(this.nudSphereZ);
            this.tabSphere.Controls.Add(this.nudSphereY);
            this.tabSphere.Controls.Add(this.nudSphereX);
            this.tabSphere.Controls.Add(this.darkLabel8);
            this.tabSphere.Location = new System.Drawing.Point(4, 4);
            this.tabSphere.Name = "tabSphere";
            this.tabSphere.Padding = new System.Windows.Forms.Padding(3);
            this.tabSphere.Size = new System.Drawing.Size(323, 58);
            this.tabSphere.TabIndex = 4;
            this.tabSphere.Text = "Sphere";
            // 
            // darkLabel6
            // 
            this.darkLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkLabel6.AutoSize = true;
            this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel6.Location = new System.Drawing.Point(219, 6);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(16, 13);
            this.darkLabel6.TabIndex = 23;
            this.darkLabel6.Text = "Z:";
            // 
            // darkLabel3
            // 
            this.darkLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(110, 6);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(15, 13);
            this.darkLabel3.TabIndex = 22;
            this.darkLabel3.Text = "Y:";
            // 
            // butResetSphere
            // 
            this.butResetSphere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butResetSphere.Checked = false;
            this.butResetSphere.Location = new System.Drawing.Point(117, 32);
            this.butResetSphere.Name = "butResetSphere";
            this.butResetSphere.Size = new System.Drawing.Size(204, 23);
            this.butResetSphere.TabIndex = 21;
            this.butResetSphere.Text = "Recalculate";
            this.toolTip.SetToolTip(this.butResetSphere, "Calculates average sphere which encloses the mesh");
            this.butResetSphere.Click += new System.EventHandler(this.butResetSphere_Click);
            // 
            // nudSphereRadius
            // 
            this.nudSphereRadius.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudSphereRadius.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudSphereRadius.Location = new System.Drawing.Point(50, 32);
            this.nudSphereRadius.LoopValues = false;
            this.nudSphereRadius.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSphereRadius.Name = "nudSphereRadius";
            this.nudSphereRadius.Size = new System.Drawing.Size(61, 23);
            this.nudSphereRadius.TabIndex = 15;
            this.toolTip.SetToolTip(this.nudSphereRadius, "Shininess value on the range from 0 to 63");
            this.nudSphereRadius.ValueChanged += new System.EventHandler(this.nudSphereData_ValueChanged);
            this.nudSphereRadius.Validated += new System.EventHandler(this.nudSphereData_ValueChanged);
            // 
            // darkLabel9
            // 
            this.darkLabel9.AutoSize = true;
            this.darkLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel9.Location = new System.Drawing.Point(3, 35);
            this.darkLabel9.Name = "darkLabel9";
            this.darkLabel9.Size = new System.Drawing.Size(45, 13);
            this.darkLabel9.TabIndex = 14;
            this.darkLabel9.Text = "Radius:";
            // 
            // nudSphereZ
            // 
            this.nudSphereZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSphereZ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudSphereZ.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudSphereZ.Location = new System.Drawing.Point(236, 3);
            this.nudSphereZ.LoopValues = false;
            this.nudSphereZ.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSphereZ.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudSphereZ.Name = "nudSphereZ";
            this.nudSphereZ.Size = new System.Drawing.Size(85, 23);
            this.nudSphereZ.TabIndex = 13;
            this.toolTip.SetToolTip(this.nudSphereZ, "Shininess value on the range from 0 to 63");
            this.nudSphereZ.ValueChanged += new System.EventHandler(this.nudSphereData_ValueChanged);
            this.nudSphereZ.Validated += new System.EventHandler(this.nudSphereData_ValueChanged);
            // 
            // nudSphereY
            // 
            this.nudSphereY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSphereY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudSphereY.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudSphereY.Location = new System.Drawing.Point(127, 3);
            this.nudSphereY.LoopValues = false;
            this.nudSphereY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSphereY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudSphereY.Name = "nudSphereY";
            this.nudSphereY.Size = new System.Drawing.Size(85, 23);
            this.nudSphereY.TabIndex = 11;
            this.toolTip.SetToolTip(this.nudSphereY, "Shininess value on the range from 0 to 63");
            this.nudSphereY.ValueChanged += new System.EventHandler(this.nudSphereData_ValueChanged);
            this.nudSphereY.Validated += new System.EventHandler(this.nudSphereData_ValueChanged);
            // 
            // nudSphereX
            // 
            this.nudSphereX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudSphereX.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudSphereX.Location = new System.Drawing.Point(20, 3);
            this.nudSphereX.LoopValues = false;
            this.nudSphereX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSphereX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.nudSphereX.Name = "nudSphereX";
            this.nudSphereX.Size = new System.Drawing.Size(85, 23);
            this.nudSphereX.TabIndex = 9;
            this.toolTip.SetToolTip(this.nudSphereX, "Shininess value on the range from 0 to 63");
            this.nudSphereX.ValueChanged += new System.EventHandler(this.nudSphereData_ValueChanged);
            this.nudSphereX.Validated += new System.EventHandler(this.nudSphereData_ValueChanged);
            // 
            // darkLabel8
            // 
            this.darkLabel8.AutoSize = true;
            this.darkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel8.Location = new System.Drawing.Point(4, 6);
            this.darkLabel8.Name = "darkLabel8";
            this.darkLabel8.Size = new System.Drawing.Size(16, 13);
            this.darkLabel8.TabIndex = 8;
            this.darkLabel8.Text = "X:";
            // 
            // tabFaceAttributes
            // 
            this.tabFaceAttributes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabFaceAttributes.Controls.Add(this.cbTexture);
            this.tabFaceAttributes.Controls.Add(this.cbBlendMode);
            this.tabFaceAttributes.Controls.Add(this.butApplyToAllFaces);
            this.tabFaceAttributes.Controls.Add(this.cbBlend);
            this.tabFaceAttributes.Controls.Add(this.nudShineStrength);
            this.tabFaceAttributes.Controls.Add(this.cbSheen);
            this.tabFaceAttributes.Controls.Add(this.butDoubleSide);
            this.tabFaceAttributes.Location = new System.Drawing.Point(4, 4);
            this.tabFaceAttributes.Name = "tabFaceAttributes";
            this.tabFaceAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabFaceAttributes.Size = new System.Drawing.Size(323, 58);
            this.tabFaceAttributes.TabIndex = 1;
            this.tabFaceAttributes.Text = "Face attributes";
            // 
            // cbTexture
            // 
            this.cbTexture.AutoSize = true;
            this.cbTexture.Checked = true;
            this.cbTexture.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTexture.Location = new System.Drawing.Point(7, 34);
            this.cbTexture.Name = "cbTexture";
            this.cbTexture.Size = new System.Drawing.Size(62, 17);
            this.cbTexture.TabIndex = 15;
            this.cbTexture.Text = "Texture";
            this.toolTip.SetToolTip(this.cbTexture, "Apply textures to faces");
            // 
            // cbBlendMode
            // 
            this.cbBlendMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBlendMode.FormattingEnabled = true;
            this.cbBlendMode.Location = new System.Drawing.Point(81, 3);
            this.cbBlendMode.Name = "cbBlendMode";
            this.cbBlendMode.Size = new System.Drawing.Size(210, 23);
            this.cbBlendMode.TabIndex = 11;
            // 
            // butApplyToAllFaces
            // 
            this.butApplyToAllFaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butApplyToAllFaces.Checked = false;
            this.butApplyToAllFaces.Location = new System.Drawing.Point(222, 32);
            this.butApplyToAllFaces.Name = "butApplyToAllFaces";
            this.butApplyToAllFaces.Size = new System.Drawing.Size(99, 23);
            this.butApplyToAllFaces.TabIndex = 9;
            this.butApplyToAllFaces.Text = "Apply to all";
            this.toolTip.SetToolTip(this.butApplyToAllFaces, "Apply specified face attributes to all faces");
            this.butApplyToAllFaces.Click += new System.EventHandler(this.butApplyToAllFaces_Click);
            // 
            // cbBlend
            // 
            this.cbBlend.AutoSize = true;
            this.cbBlend.Checked = true;
            this.cbBlend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBlend.Location = new System.Drawing.Point(7, 5);
            this.cbBlend.Name = "cbBlend";
            this.cbBlend.Size = new System.Drawing.Size(76, 17);
            this.cbBlend.TabIndex = 14;
            this.cbBlend.Text = "Blending:";
            this.toolTip.SetToolTip(this.cbBlend, "Apply blend mode and double-sided attribute to faces");
            // 
            // nudShineStrength
            // 
            this.nudShineStrength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudShineStrength.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudShineStrength.IncrementAlternate = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.nudShineStrength.Location = new System.Drawing.Point(146, 32);
            this.nudShineStrength.LoopValues = false;
            this.nudShineStrength.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.nudShineStrength.Name = "nudShineStrength";
            this.nudShineStrength.Size = new System.Drawing.Size(72, 23);
            this.nudShineStrength.TabIndex = 7;
            this.toolTip.SetToolTip(this.nudShineStrength, "Shininess value on the range from 0 to 63");
            // 
            // cbSheen
            // 
            this.cbSheen.AutoSize = true;
            this.cbSheen.Checked = true;
            this.cbSheen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSheen.Location = new System.Drawing.Point(81, 34);
            this.cbSheen.Name = "cbSheen";
            this.cbSheen.Size = new System.Drawing.Size(61, 17);
            this.cbSheen.TabIndex = 13;
            this.cbSheen.Text = "Sheen:";
            this.toolTip.SetToolTip(this.cbSheen, "Apply sheen attribute to faces");
            // 
            // butDoubleSide
            // 
            this.butDoubleSide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butDoubleSide.Checked = false;
            this.butDoubleSide.Image = global::WadTool.Properties.Resources.texture_DoubleSided_1_16;
            this.butDoubleSide.Location = new System.Drawing.Point(297, 3);
            this.butDoubleSide.Name = "butDoubleSide";
            this.butDoubleSide.Size = new System.Drawing.Size(24, 23);
            this.butDoubleSide.TabIndex = 12;
            this.butDoubleSide.Tag = "";
            this.toolTip.SetToolTip(this.butDoubleSide, "Double-sided");
            this.butDoubleSide.Click += new System.EventHandler(this.butDoubleSide_Click);
            // 
            // cbExtra
            // 
            this.cbExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExtra.Location = new System.Drawing.Point(241, 31);
            this.cbExtra.Name = "cbExtra";
            this.cbExtra.Size = new System.Drawing.Size(87, 17);
            this.cbExtra.TabIndex = 4;
            this.cbExtra.Text = "All numbers";
            this.toolTip.SetToolTip(this.cbExtra, "Show additional screen information");
            this.cbExtra.CheckedChanged += new System.EventHandler(this.cbVertexNumbers_CheckedChanged);
            // 
            // cbEditingMode
            // 
            this.cbEditingMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEditingMode.FormattingEnabled = true;
            this.cbEditingMode.Location = new System.Drawing.Point(45, 29);
            this.cbEditingMode.Name = "cbEditingMode";
            this.cbEditingMode.Size = new System.Drawing.Size(130, 23);
            this.cbEditingMode.TabIndex = 9;
            this.cbEditingMode.SelectedIndexChanged += new System.EventHandler(this.cbEditingMode_SelectedIndexChanged);
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(4, 32);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(40, 13);
            this.darkLabel2.TabIndex = 8;
            this.darkLabel2.Text = "Mode:";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.lstMeshes);
            this.darkSectionPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkSectionPanel2.Location = new System.Drawing.Point(0, 0);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "Mesh list";
            this.darkSectionPanel2.Size = new System.Drawing.Size(259, 560);
            this.darkSectionPanel2.TabIndex = 55;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Controls.Add(this.panelCenter);
            this.panelMain.Controls.Add(this.panelEditing);
            this.panelMain.Controls.Add(this.panelTree);
            this.panelMain.Location = new System.Drawing.Point(5, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(974, 560);
            this.panelMain.TabIndex = 56;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelMesh);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(263, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panelCenter.Size = new System.Drawing.Size(374, 560);
            this.panelCenter.TabIndex = 57;
            // 
            // panelEditing
            // 
            this.panelEditing.Controls.Add(this.panelTexturinga);
            this.panelEditing.Controls.Add(this.panelEditingTools);
            this.panelEditing.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEditing.Location = new System.Drawing.Point(637, 0);
            this.panelEditing.Name = "panelEditing";
            this.panelEditing.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panelEditing.Size = new System.Drawing.Size(337, 560);
            this.panelEditing.TabIndex = 56;
            // 
            // panelTexturinga
            // 
            this.panelTexturinga.Controls.Add(this.panelTextureMap);
            this.panelTexturinga.Controls.Add(this.panelTexturingTools);
            this.panelTexturinga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTexturinga.Location = new System.Drawing.Point(4, 0);
            this.panelTexturinga.Name = "panelTexturinga";
            this.panelTexturinga.SectionHeader = "Texturing";
            this.panelTexturinga.Size = new System.Drawing.Size(333, 399);
            this.panelTexturinga.TabIndex = 0;
            // 
            // panelTextureMap
            // 
            this.panelTextureMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTextureMap.Location = new System.Drawing.Point(1, 55);
            this.panelTextureMap.Name = "panelTextureMap";
            this.panelTextureMap.Size = new System.Drawing.Size(331, 343);
            this.panelTextureMap.TabIndex = 0;
            // 
            // panelTexturingTools
            // 
            this.panelTexturingTools.Controls.Add(this.butAllTextures);
            this.panelTexturingTools.Controls.Add(this.butExportTexture);
            this.panelTexturingTools.Controls.Add(this.butAddTexture);
            this.panelTexturingTools.Controls.Add(this.butDeleteTexture);
            this.panelTexturingTools.Controls.Add(this.comboCurrentTexture);
            this.panelTexturingTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTexturingTools.Location = new System.Drawing.Point(1, 25);
            this.panelTexturingTools.Name = "panelTexturingTools";
            this.panelTexturingTools.Size = new System.Drawing.Size(331, 30);
            this.panelTexturingTools.TabIndex = 1;
            // 
            // butAllTextures
            // 
            this.butAllTextures.Checked = false;
            this.butAllTextures.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAllTextures.Image = global::WadTool.Properties.Resources.actions_DrawAllRooms_16;
            this.butAllTextures.Location = new System.Drawing.Point(1, 3);
            this.butAllTextures.Name = "butAllTextures";
            this.butAllTextures.Size = new System.Drawing.Size(24, 23);
            this.butAllTextures.TabIndex = 8;
            this.butAllTextures.Tag = "";
            this.toolTip.SetToolTip(this.butAllTextures, "List all textures from wad");
            this.butAllTextures.Click += new System.EventHandler(this.butAllTextures_Click);
            // 
            // butExportTexture
            // 
            this.butExportTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butExportTexture.Checked = false;
            this.butExportTexture.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExportTexture.Image = global::WadTool.Properties.Resources.general_Export_16;
            this.butExportTexture.Location = new System.Drawing.Point(277, 3);
            this.butExportTexture.Name = "butExportTexture";
            this.butExportTexture.Size = new System.Drawing.Size(24, 23);
            this.butExportTexture.TabIndex = 7;
            this.butExportTexture.Tag = "";
            this.toolTip.SetToolTip(this.butExportTexture, "Export to file");
            this.butExportTexture.Click += new System.EventHandler(this.butExportTexture_Click);
            // 
            // butAddTexture
            // 
            this.butAddTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butAddTexture.Checked = false;
            this.butAddTexture.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddTexture.Image = global::WadTool.Properties.Resources.general_plus_math_16;
            this.butAddTexture.Location = new System.Drawing.Point(247, 3);
            this.butAddTexture.Name = "butAddTexture";
            this.butAddTexture.Size = new System.Drawing.Size(24, 23);
            this.butAddTexture.TabIndex = 5;
            this.butAddTexture.Tag = "";
            this.butAddTexture.Click += new System.EventHandler(this.butAddTexture_Click);
            // 
            // butDeleteTexture
            // 
            this.butDeleteTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butDeleteTexture.Checked = false;
            this.butDeleteTexture.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDeleteTexture.Image = global::WadTool.Properties.Resources.trash_16;
            this.butDeleteTexture.Location = new System.Drawing.Point(307, 3);
            this.butDeleteTexture.Name = "butDeleteTexture";
            this.butDeleteTexture.Size = new System.Drawing.Size(24, 23);
            this.butDeleteTexture.TabIndex = 6;
            this.toolTip.SetToolTip(this.butDeleteTexture, "Delete texture");
            this.butDeleteTexture.Click += new System.EventHandler(this.butDeleteTexture_Click);
            // 
            // comboCurrentTexture
            // 
            this.comboCurrentTexture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCurrentTexture.FormattingEnabled = true;
            this.comboCurrentTexture.Location = new System.Drawing.Point(30, 3);
            this.comboCurrentTexture.Name = "comboCurrentTexture";
            this.comboCurrentTexture.Size = new System.Drawing.Size(211, 23);
            this.comboCurrentTexture.TabIndex = 4;
            this.comboCurrentTexture.SelectedValueChanged += new System.EventHandler(this.comboCurrentTexture_SelectedValueChanged);
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.darkSectionPanel2);
            this.panelTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTree.Location = new System.Drawing.Point(0, 0);
            this.panelTree.Name = "panelTree";
            this.panelTree.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.panelTree.Size = new System.Drawing.Size(263, 560);
            this.panelTree.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.statusLabel.Location = new System.Drawing.Point(3, 576);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(284, 13);
            this.statusLabel.TabIndex = 57;
            this.statusLabel.Text = "This label will contain useful info about current mesh.";
            // 
            // FormMeshEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "FormMeshEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mesh editor";
            this.panelEditingTools.ResumeLayout(false);
            this.panelEditingTools.PerformLayout();
            this.tabsModes.ResumeLayout(false);
            this.tabVertexRemap.ResumeLayout(false);
            this.tabVertexRemap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertexNum)).EndInit();
            this.tabVertexShadesAndNormals.ResumeLayout(false);
            this.tabVertexShadesAndNormals.PerformLayout();
            this.tabVertexEffects.ResumeLayout(false);
            this.tabVertexEffects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlow)).EndInit();
            this.tabSphere.ResumeLayout(false);
            this.tabSphere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSphereRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSphereZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSphereY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSphereX)).EndInit();
            this.tabFaceAttributes.ResumeLayout(false);
            this.tabFaceAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShineStrength)).EndInit();
            this.darkSectionPanel2.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelEditing.ResumeLayout(false);
            this.panelTexturinga.ResumeLayout(false);
            this.panelTexturingTools.ResumeLayout(false);
            this.panelTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PanelRenderingMesh panelMesh;
        private DarkUI.Controls.DarkTreeView lstMeshes;
        private DarkUI.Controls.DarkButton btCancel;
        private DarkUI.Controls.DarkButton btOk;
        private DarkUI.Controls.DarkSectionPanel panelEditingTools;
        private DarkUI.Controls.DarkButton butRemapVertex;
        private DarkUI.Controls.DarkNumericUpDown nudVertexNum;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkCheckBox cbExtra;
        private DarkUI.Controls.DarkButton butFindVertex;
        private DarkUI.Controls.DarkPanel panelMain;
        private DarkUI.Controls.DarkPanel panelTree;
        private TombLib.Controls.DarkTabbedContainer tabsModes;
        private System.Windows.Forms.TabPage tabVertexRemap;
        private System.Windows.Forms.TabPage tabFaceAttributes;
        private DarkUI.Controls.DarkNumericUpDown nudShineStrength;
        private DarkUI.Controls.DarkButton butApplyToAllFaces;
        private System.Windows.Forms.TabPage tabVertexEffects;
        private DarkUI.Controls.DarkButton butApplyToAllVertices;
        private DarkUI.Controls.DarkNumericUpDown nudGlow;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkNumericUpDown nudMove;
        private DarkUI.Controls.DarkLabel darkLabel5;
        private DarkUI.Controls.DarkComboBox cbBlendMode;
        private DarkUI.Controls.DarkPanel panelColor;
        private System.Windows.Forms.TabPage tabVertexShadesAndNormals;
        private DarkUI.Controls.DarkButton butApplyShadesToAllVertices;
        private DarkUI.Controls.DarkButton butRecalcNormals;
        private DarkUI.Controls.DarkButton butConvertFromShades;
        private DarkUI.Controls.DarkLabel darkLabel7;
        private DarkUI.Controls.DarkComboBox cbEditingMode;
        private DarkUI.Controls.DarkButton butDoubleSide;
        private System.Windows.Forms.ToolTip toolTip;
        private DarkUI.Controls.DarkButton butAutoFit;
        private System.Windows.Forms.TabPage tabSphere;
        private DarkUI.Controls.DarkNumericUpDown nudSphereZ;
        private DarkUI.Controls.DarkNumericUpDown nudSphereY;
        private DarkUI.Controls.DarkNumericUpDown nudSphereX;
        private DarkUI.Controls.DarkLabel darkLabel8;
        private DarkUI.Controls.DarkLabel darkLabel9;
        private DarkUI.Controls.DarkButton butResetSphere;
        private DarkUI.Controls.DarkButton butPreview;
        private DarkUI.Controls.DarkPanel panelEditing;
        private DarkUI.Controls.DarkSectionPanel panelTexturinga;
        private Controls.PanelTextureMap panelTextureMap;
        private DarkUI.Controls.DarkPanel panelTexturingTools;
        private DarkUI.Controls.DarkButton butAddTexture;
        private DarkUI.Controls.DarkButton butDeleteTexture;
        private DarkUI.Controls.DarkComboBox comboCurrentTexture;
        private DarkUI.Controls.DarkCheckBox cbTexture;
        private DarkUI.Controls.DarkCheckBox cbBlend;
        private DarkUI.Controls.DarkCheckBox cbSheen;
        private DarkUI.Controls.DarkLabel darkLabel10;
        private DarkUI.Controls.DarkButton butRecalcNormalsAvg;
        private DarkUI.Controls.DarkButton butExportTexture;
        private DarkUI.Controls.DarkNumericUpDown nudSphereRadius;
        private DarkUI.Controls.DarkButton butAllTextures;
        private DarkUI.Controls.DarkButton butAlpha;
        private DarkUI.Controls.DarkButton butWire;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel statusLabel;
        private DarkUI.Controls.DarkPanel panelCenter;
    }
}