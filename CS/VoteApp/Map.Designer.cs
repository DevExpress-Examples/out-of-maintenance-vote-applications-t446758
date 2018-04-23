namespace DevExpress.VoteApp {
    partial class Map {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.MapOverlay mapOverlay1 = new DevExpress.XtraMap.MapOverlay();
            DevExpress.XtraMap.MapOverlayTextItem mapOverlayTextItem1 = new DevExpress.XtraMap.MapOverlayTextItem();
            this.colRepPercents = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGOP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repProgress = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.colDemPercents = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDem = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.demProgress = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.stateLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.mapTooltipController = new DevExpress.Utils.ToolTipController(this.components);
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tsElectionSimilutor = new DevExpress.XtraEditors.ToggleSwitch();
            this.switchResults = new DevExpress.XtraEditors.SimpleButton();
            this.lbElection = new DevExpress.XtraEditors.LabelControl();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.listVoteResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridTooltipController = new DevExpress.Utils.ToolTipController(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.votesPanelPeople = new DevExpress.VoteApp.VotesPanel();
            this.votesPanelElectoral = new DevExpress.VoteApp.VotesPanel();
            this.lbRep = new DevExpress.XtraEditors.LabelControl();
            this.lbDem = new DevExpress.XtraEditors.LabelControl();
            this.piRep = new DevExpress.XtraEditors.PictureEdit();
            this.piDem = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btBackToStates = new DevExpress.XtraEditors.SimpleButton();
            this.btCenter = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btBackToStates2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsElectionSimilutor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVoteResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piRep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colRepPercents
            // 
            this.colRepPercents.FieldName = "RepPercents";
            this.colRepPercents.Name = "colRepPercents";
            this.colRepPercents.Visible = true;
            // 
            // colGOP
            // 
            this.colGOP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGOP.AppearanceHeader.Options.UseFont = true;
            this.colGOP.AutoFillDown = true;
            this.colGOP.Caption = "GOP";
            this.colGOP.ColumnEdit = this.repProgress;
            this.colGOP.FieldName = "IntRepPercents";
            this.colGOP.Name = "colGOP";
            this.colGOP.RowIndex = 1;
            this.colGOP.Visible = true;
            this.colGOP.Width = 209;
            // 
            // repProgress
            // 
            this.repProgress.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            this.repProgress.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.repProgress.LookAndFeel.UseDefaultLookAndFeel = false;
            this.repProgress.Name = "repProgress";
            this.repProgress.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.repProgress.ShowTitle = true;
            this.repProgress.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(0)))), ((int)(((byte)(2)))));
            // 
            // colDemPercents
            // 
            this.colDemPercents.FieldName = "DemPercents";
            this.colDemPercents.Name = "colDemPercents";
            this.colDemPercents.Visible = true;
            // 
            // colDem
            // 
            this.colDem.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDem.AppearanceHeader.Options.UseFont = true;
            this.colDem.Caption = "DEM";
            this.colDem.ColumnEdit = this.demProgress;
            this.colDem.FieldName = "IntDemPercents";
            this.colDem.Name = "colDem";
            this.colDem.Visible = true;
            this.colDem.Width = 209;
            // 
            // demProgress
            // 
            this.demProgress.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            this.demProgress.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.demProgress.LookAndFeel.UseDefaultLookAndFeel = false;
            this.demProgress.Name = "demProgress";
            this.demProgress.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.demProgress.ShowTitle = true;
            this.demProgress.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(188)))));
            // 
            // mapControl
            // 
            this.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(40D, -104D);
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.EnableScrolling = false;
            this.mapControl.Layers.Add(this.stateLayer);
            this.mapControl.Location = new System.Drawing.Point(0, 188);
            this.mapControl.MaxZoomLevel = 9D;
            this.mapControl.MinZoomLevel = 4D;
            this.mapControl.Name = "mapControl";
            this.mapControl.NavigationPanelOptions.Height = 40;
            this.mapControl.NavigationPanelOptions.ShowCoordinates = false;
            this.mapControl.NavigationPanelOptions.ShowKilometersScale = false;
            this.mapControl.NavigationPanelOptions.ShowScrollButtons = false;
            mapOverlay1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            mapOverlayTextItem1.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            mapOverlayTextItem1.Text = "Source: United States Federal Election Commission; County-Level election data cou" +
    "rtesy of TheGuardian.com";
            mapOverlayTextItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            mapOverlayTextItem1.TextStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            mapOverlayTextItem1.TextStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            mapOverlay1.Items.Add(mapOverlayTextItem1);
            mapOverlay1.Location = new System.Drawing.Point(30, -30);
            this.mapControl.Overlays.Add(mapOverlay1);
            this.mapControl.Size = new System.Drawing.Size(931, 574);
            this.mapControl.TabIndex = 0;
            this.mapControl.ToolTipController = this.mapTooltipController;
            this.mapControl.ZoomLevel = 4D;
            this.mapControl.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl_MapItemClick);
            this.mapControl.MapItemDoubleClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl_MapItemClick);
            this.mapControl.DoubleClick += new System.EventHandler(this.mapControl_DoubleClick);
            // 
            // stateLayer
            // 
            this.stateLayer.Data = this.shapefileDataAdapter1;
            this.stateLayer.ShapeTitlesVisibility = DevExpress.XtraMap.VisibilityMode.Visible;
            this.stateLayer.ToolTipPattern = "%V0%";
            // 
            // mapTooltipController
            // 
            this.mapTooltipController.AllowHtmlText = true;
            this.mapTooltipController.AutoPopDelay = 500;
            this.mapTooltipController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            this.mapTooltipController.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.mapTooltipController_BeforeShow);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel1.ContentImage = global::DevExpress.VoteApp.Properties.Resources.flag;
            this.panel1.Controls.Add(this.panelControl3);
            this.panel1.Controls.Add(this.switchResults);
            this.panel1.Controls.Add(this.lbElection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 43);
            this.panel1.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.tsElectionSimilutor);
            this.panelControl3.Location = new System.Drawing.Point(1043, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(188, 32);
            this.panelControl3.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Simulation mode:";
            // 
            // tsElectionSimilutor
            // 
            this.tsElectionSimilutor.Location = new System.Drawing.Point(92, 3);
            this.tsElectionSimilutor.Name = "tsElectionSimilutor";
            this.tsElectionSimilutor.Properties.OffText = "Off";
            this.tsElectionSimilutor.Properties.OnText = "On";
            this.tsElectionSimilutor.Size = new System.Drawing.Size(95, 24);
            this.tsElectionSimilutor.TabIndex = 7;
            this.tsElectionSimilutor.Toggled += new System.EventHandler(this.tsElectionSimilutor_Toggled);
            // 
            // switchResults
            // 
            this.switchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.switchResults.Location = new System.Drawing.Point(929, 5);
            this.switchResults.Name = "switchResults";
            this.switchResults.Size = new System.Drawing.Size(108, 32);
            this.switchResults.TabIndex = 6;
            this.switchResults.Text = "Show 2012";
            this.switchResults.Click += new System.EventHandler(this.switchResults_Click);
            // 
            // lbElection
            // 
            this.lbElection.AllowHtmlString = true;
            this.lbElection.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElection.Appearance.Options.UseFont = true;
            this.lbElection.Location = new System.Drawing.Point(5, 3);
            this.lbElection.Name = "lbElection";
            this.lbElection.Size = new System.Drawing.Size(167, 38);
            this.lbElection.TabIndex = 0;
            this.lbElection.Text = "Election 2012";
            // 
            // grid
            // 
            this.grid.DataSource = this.listVoteResultsBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(2, 26);
            this.grid.MainView = this.gridView;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.demProgress,
            this.repProgress});
            this.grid.Size = new System.Drawing.Size(299, 691);
            this.grid.TabIndex = 3;
            this.grid.ToolTipController = this.gridTooltipController;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // listVoteResultsBindingSource
            // 
            this.listVoteResultsBindingSource.DataSource = typeof(DevExpress.VoteApp.ListVoteResults);
            // 
            // gridView
            // 
            this.gridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colArea,
            this.colGOP,
            this.colDem,
            this.colRepPercents,
            this.colDemPercents});
            this.gridView.GridControl = this.grid;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowBandMoving = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsDetail.EnableMasterViewMode = false;
            this.gridView.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView.OptionsView.ColumnAutoWidth = true;
            this.gridView.OptionsView.ShowBands = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_RowClick);
            this.gridView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView_CustomDrawCell);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colArea);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 88;
            // 
            // colArea
            // 
            this.colArea.AppearanceHeader.Options.UseTextOptions = true;
            this.colArea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArea.Caption = "Area";
            this.colArea.FieldName = "Name";
            this.colArea.Name = "colArea";
            this.colArea.RowCount = 2;
            this.colArea.Visible = true;
            this.colArea.Width = 88;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "gridBand2";
            this.gridBand2.Columns.Add(this.colDem);
            this.gridBand2.Columns.Add(this.colGOP);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 209;
            // 
            // gridTooltipController
            // 
            this.gridTooltipController.AutoPopDelay = 500;
            this.gridTooltipController.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.gridTooltipController_GetActiveObjectInfo);
            this.gridTooltipController.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.gridTooltipController_BeforeShow);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.votesPanelPeople);
            this.panelControl1.Controls.Add(this.votesPanelElectoral);
            this.panelControl1.Controls.Add(this.lbRep);
            this.panelControl1.Controls.Add(this.lbDem);
            this.panelControl1.Controls.Add(this.piRep);
            this.panelControl1.Controls.Add(this.piDem);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 43);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(931, 145);
            this.panelControl1.TabIndex = 4;
            // 
            // votesPanelPeople
            // 
            this.votesPanelPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.votesPanelPeople.BackColor = System.Drawing.Color.Silver;
            this.votesPanelPeople.ColorLeft = System.Drawing.Color.Empty;
            this.votesPanelPeople.ColorRight = System.Drawing.Color.Empty;
            this.votesPanelPeople.Location = new System.Drawing.Point(101, 81);
            this.votesPanelPeople.Name = "votesPanelPeople";
            this.votesPanelPeople.Size = new System.Drawing.Size(728, 22);
            this.votesPanelPeople.TabIndex = 8;
            this.votesPanelPeople.VotesTextLeft = "<b>50%</b> <i>Votes";
            this.votesPanelPeople.VotesTextRight = "Votes</size> <b>50%</b>";
            this.votesPanelPeople.VotesTextSize = 10F;
            // 
            // votesPanelElectoral
            // 
            this.votesPanelElectoral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.votesPanelElectoral.BackColor = System.Drawing.Color.Silver;
            this.votesPanelElectoral.ColorLeft = System.Drawing.Color.Empty;
            this.votesPanelElectoral.ColorRight = System.Drawing.Color.Empty;
            this.votesPanelElectoral.Location = new System.Drawing.Point(100, 16);
            this.votesPanelElectoral.Name = "votesPanelElectoral";
            this.votesPanelElectoral.Size = new System.Drawing.Size(728, 59);
            this.votesPanelElectoral.TabIndex = 7;
            this.votesPanelElectoral.VotesTextLeft = "<b>100</b> <size=-5><i>Electoral Votes";
            this.votesPanelElectoral.VotesTextRight = "<size=-5>Electoral Votes</size> <b>100</b>";
            this.votesPanelElectoral.VotesTextSize = 15.75F;
            // 
            // lbRep
            // 
            this.lbRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRep.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbRep.Appearance.Options.UseFont = true;
            this.lbRep.Appearance.Options.UseTextOptions = true;
            this.lbRep.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbRep.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lbRep.Location = new System.Drawing.Point(718, 126);
            this.lbRep.Name = "lbRep";
            this.lbRep.Size = new System.Drawing.Size(207, 13);
            this.lbRep.TabIndex = 5;
            this.lbRep.Text = "Candidate2";
            // 
            // lbDem
            // 
            this.lbDem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbDem.Appearance.Options.UseFont = true;
            this.lbDem.Location = new System.Drawing.Point(5, 126);
            this.lbDem.Name = "lbDem";
            this.lbDem.Size = new System.Drawing.Size(64, 13);
            this.lbDem.TabIndex = 4;
            this.lbDem.Text = "Candidate1";
            // 
            // piRep
            // 
            this.piRep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.piRep.Cursor = System.Windows.Forms.Cursors.Default;
            this.piRep.Location = new System.Drawing.Point(835, 4);
            this.piRep.Name = "piRep";
            this.piRep.Properties.ReadOnly = true;
            this.piRep.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piRep.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piRep.Properties.ZoomAccelerationFactor = 1D;
            this.piRep.Size = new System.Drawing.Size(90, 118);
            this.piRep.TabIndex = 1;
            // 
            // piDem
            // 
            this.piDem.Cursor = System.Windows.Forms.Cursors.Default;
            this.piDem.Location = new System.Drawing.Point(5, 4);
            this.piDem.Name = "piDem";
            this.piDem.Properties.ReadOnly = true;
            this.piDem.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.piDem.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.piDem.Properties.ZoomAccelerationFactor = 1D;
            this.piDem.Size = new System.Drawing.Size(90, 118);
            this.piDem.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(101, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(727, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Candidates need 270 electoral votes to win the presidency";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // btBackToStates
            // 
            this.btBackToStates.Location = new System.Drawing.Point(5, 194);
            this.btBackToStates.Name = "btBackToStates";
            this.btBackToStates.Size = new System.Drawing.Size(91, 30);
            this.btBackToStates.TabIndex = 5;
            this.btBackToStates.Text = "Back to States";
            this.btBackToStates.Visible = false;
            this.btBackToStates.Click += new System.EventHandler(this.btBackToStates_Click);
            // 
            // btCenter
            // 
            this.btCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCenter.Location = new System.Drawing.Point(816, 194);
            this.btCenter.Name = "btCenter";
            this.btCenter.Size = new System.Drawing.Size(91, 30);
            this.btCenter.TabIndex = 6;
            this.btCenter.Text = "Center Map";
            this.btCenter.Click += new System.EventHandler(this.btCenter_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grid);
            this.panelControl2.Controls.Add(this.btBackToStates2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(931, 43);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(303, 719);
            this.panelControl2.TabIndex = 7;
            // 
            // btBackToStates2
            // 
            this.btBackToStates2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btBackToStates2.Location = new System.Drawing.Point(2, 2);
            this.btBackToStates2.Name = "btBackToStates2";
            this.btBackToStates2.Size = new System.Drawing.Size(299, 24);
            this.btBackToStates2.TabIndex = 6;
            this.btBackToStates2.Text = "Back to States View";
            this.btBackToStates2.Visible = false;
            this.btBackToStates2.Click += new System.EventHandler(this.btBackToStates_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 762);
            this.Controls.Add(this.btCenter);
            this.Controls.Add(this.btBackToStates);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panel1);
            this.Name = "Map";
            this.Text = "DevExpress Election Viewer";
            this.Load += new System.EventHandler(this.Map_Load);
            this.SizeChanged += new System.EventHandler(this.Map_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.repProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsElectionSimilutor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVoteResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piRep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraMap.VectorItemsLayer stateLayer;
        private DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter1;
        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colArea;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGOP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDem;
        private System.Windows.Forms.BindingSource listVoteResultsBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRepPercents;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDemPercents;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbElection;
        private DevExpress.XtraEditors.LabelControl lbRep;
        private DevExpress.XtraEditors.LabelControl lbDem;
        private DevExpress.XtraEditors.PictureEdit piRep;
        private DevExpress.XtraEditors.PictureEdit piDem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btBackToStates;
        private DevExpress.XtraEditors.SimpleButton btCenter;
        private VotesPanel votesPanelElectoral;
        private VotesPanel votesPanelPeople;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar demProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repProgress;
        private DevExpress.Utils.ToolTipController mapTooltipController;
        private DevExpress.Utils.ToolTipController gridTooltipController;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btBackToStates2;
        private DevExpress.XtraEditors.SimpleButton switchResults;
        private XtraEditors.ToggleSwitch tsElectionSimilutor;
        private XtraEditors.PanelControl panelControl3;
        private XtraEditors.LabelControl labelControl2;
    }
}