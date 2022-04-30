
namespace ProfitChartBotMLBased
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNeedToConfigure = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLastClose = new System.Windows.Forms.Label();
            this.lblLastHigh = new System.Windows.Forms.Label();
            this.lblLastLow = new System.Windows.Forms.Label();
            this.lblLastOpen = new System.Windows.Forms.Label();
            this.lblLastVolume = new System.Windows.Forms.Label();
            this.lblShortPredicted = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtShortPredicted = new System.Windows.Forms.TextBox();
            this.txtOrderStatus = new System.Windows.Forms.TextBox();
            this.txtLastVolume = new System.Windows.Forms.TextBox();
            this.txtLastOpen = new System.Windows.Forms.TextBox();
            this.txtLastLow = new System.Windows.Forms.TextBox();
            this.txtLastHigh = new System.Windows.Forms.TextBox();
            this.txtLastClose = new System.Windows.Forms.TextBox();
            this.timerObservations = new System.Windows.Forms.Timer(this.components);
            this.txtLow = new System.Windows.Forms.TextBox();
            this.lblLow = new System.Windows.Forms.Label();
            this.txtScanTime = new System.Windows.Forms.TextBox();
            this.lblScanTime = new System.Windows.Forms.Label();
            this.txtLongPredicted = new System.Windows.Forms.TextBox();
            this.longPredicted = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.smartStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.sistemaToolStripMenuItem.Text = "ProfitChartBot";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.terminateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.smartStopToolStripMenuItem});
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.executeToolStripMenuItem.Text = "Execute";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            // 
            // terminateToolStripMenuItem
            // 
            this.terminateToolStripMenuItem.Name = "terminateToolStripMenuItem";
            this.terminateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.terminateToolStripMenuItem.Text = "Terminate";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 308);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(661, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNeedToConfigure
            // 
            this.lblNeedToConfigure.AutoSize = true;
            this.lblNeedToConfigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeedToConfigure.ForeColor = System.Drawing.Color.Red;
            this.lblNeedToConfigure.Location = new System.Drawing.Point(10, 271);
            this.lblNeedToConfigure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNeedToConfigure.Name = "lblNeedToConfigure";
            this.lblNeedToConfigure.Size = new System.Drawing.Size(409, 16);
            this.lblNeedToConfigure.TabIndex = 2;
            this.lblNeedToConfigure.Text = "This Bot has no current Configuration, please configure it...";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Blue;
            this.lblTime.Location = new System.Drawing.Point(13, 31);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(143, 16);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time (Last Candle):";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Blue;
            this.lblDate.Location = new System.Drawing.Point(13, 65);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.ForeColor = System.Drawing.Color.Blue;
            this.lblHigh.Location = new System.Drawing.Point(13, 100);
            this.lblHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(44, 16);
            this.lblHigh.TabIndex = 5;
            this.lblHigh.Text = "High:";
            // 
            // lblLastClose
            // 
            this.lblLastClose.AutoSize = true;
            this.lblLastClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastClose.ForeColor = System.Drawing.Color.Blue;
            this.lblLastClose.Location = new System.Drawing.Point(378, 31);
            this.lblLastClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastClose.Name = "lblLastClose";
            this.lblLastClose.Size = new System.Drawing.Size(85, 16);
            this.lblLastClose.TabIndex = 6;
            this.lblLastClose.Text = "Last Close:";
            // 
            // lblLastHigh
            // 
            this.lblLastHigh.AutoSize = true;
            this.lblLastHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastHigh.ForeColor = System.Drawing.Color.Blue;
            this.lblLastHigh.Location = new System.Drawing.Point(378, 65);
            this.lblLastHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastHigh.Name = "lblLastHigh";
            this.lblLastHigh.Size = new System.Drawing.Size(77, 16);
            this.lblLastHigh.TabIndex = 7;
            this.lblLastHigh.Text = "Last High:";
            // 
            // lblLastLow
            // 
            this.lblLastLow.AutoSize = true;
            this.lblLastLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLow.ForeColor = System.Drawing.Color.Blue;
            this.lblLastLow.Location = new System.Drawing.Point(378, 100);
            this.lblLastLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastLow.Name = "lblLastLow";
            this.lblLastLow.Size = new System.Drawing.Size(72, 16);
            this.lblLastLow.TabIndex = 8;
            this.lblLastLow.Text = "Last Low:";
            // 
            // lblLastOpen
            // 
            this.lblLastOpen.AutoSize = true;
            this.lblLastOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastOpen.ForeColor = System.Drawing.Color.Blue;
            this.lblLastOpen.Location = new System.Drawing.Point(378, 134);
            this.lblLastOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastOpen.Name = "lblLastOpen";
            this.lblLastOpen.Size = new System.Drawing.Size(82, 16);
            this.lblLastOpen.TabIndex = 9;
            this.lblLastOpen.Text = "Last Open:";
            // 
            // lblLastVolume
            // 
            this.lblLastVolume.AutoSize = true;
            this.lblLastVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastVolume.ForeColor = System.Drawing.Color.Blue;
            this.lblLastVolume.Location = new System.Drawing.Point(378, 169);
            this.lblLastVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastVolume.Name = "lblLastVolume";
            this.lblLastVolume.Size = new System.Drawing.Size(97, 16);
            this.lblLastVolume.TabIndex = 10;
            this.lblLastVolume.Text = "Last Volume:";
            // 
            // lblShortPredicted
            // 
            this.lblShortPredicted.AutoSize = true;
            this.lblShortPredicted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortPredicted.ForeColor = System.Drawing.Color.Blue;
            this.lblShortPredicted.Location = new System.Drawing.Point(13, 166);
            this.lblShortPredicted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShortPredicted.Name = "lblShortPredicted";
            this.lblShortPredicted.Size = new System.Drawing.Size(119, 16);
            this.lblShortPredicted.TabIndex = 11;
            this.lblShortPredicted.Text = "Short Predicted:";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblOrderStatus.Location = new System.Drawing.Point(13, 234);
            this.lblOrderStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(98, 16);
            this.lblOrderStatus.TabIndex = 12;
            this.lblOrderStatus.Text = "Order Status:";
            // 
            // txtTime
            // 
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(199, 34);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(143, 15);
            this.txtTime.TabIndex = 13;
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(199, 67);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(143, 15);
            this.txtDate.TabIndex = 14;
            // 
            // txtHigh
            // 
            this.txtHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHigh.Location = new System.Drawing.Point(199, 100);
            this.txtHigh.Margin = new System.Windows.Forms.Padding(4);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.ReadOnly = true;
            this.txtHigh.Size = new System.Drawing.Size(143, 15);
            this.txtHigh.TabIndex = 15;
            // 
            // txtShortPredicted
            // 
            this.txtShortPredicted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShortPredicted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortPredicted.Location = new System.Drawing.Point(199, 167);
            this.txtShortPredicted.Margin = new System.Windows.Forms.Padding(4);
            this.txtShortPredicted.Name = "txtShortPredicted";
            this.txtShortPredicted.ReadOnly = true;
            this.txtShortPredicted.Size = new System.Drawing.Size(143, 15);
            this.txtShortPredicted.TabIndex = 16;
            // 
            // txtOrderStatus
            // 
            this.txtOrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderStatus.Location = new System.Drawing.Point(200, 233);
            this.txtOrderStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrderStatus.Name = "txtOrderStatus";
            this.txtOrderStatus.ReadOnly = true;
            this.txtOrderStatus.Size = new System.Drawing.Size(143, 15);
            this.txtOrderStatus.TabIndex = 17;
            // 
            // txtLastVolume
            // 
            this.txtLastVolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastVolume.Location = new System.Drawing.Point(495, 167);
            this.txtLastVolume.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastVolume.Name = "txtLastVolume";
            this.txtLastVolume.ReadOnly = true;
            this.txtLastVolume.Size = new System.Drawing.Size(143, 15);
            this.txtLastVolume.TabIndex = 22;
            // 
            // txtLastOpen
            // 
            this.txtLastOpen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastOpen.Location = new System.Drawing.Point(495, 134);
            this.txtLastOpen.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastOpen.Name = "txtLastOpen";
            this.txtLastOpen.ReadOnly = true;
            this.txtLastOpen.Size = new System.Drawing.Size(143, 15);
            this.txtLastOpen.TabIndex = 21;
            // 
            // txtLastLow
            // 
            this.txtLastLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastLow.Location = new System.Drawing.Point(495, 100);
            this.txtLastLow.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastLow.Name = "txtLastLow";
            this.txtLastLow.ReadOnly = true;
            this.txtLastLow.Size = new System.Drawing.Size(143, 15);
            this.txtLastLow.TabIndex = 20;
            // 
            // txtLastHigh
            // 
            this.txtLastHigh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastHigh.Location = new System.Drawing.Point(495, 67);
            this.txtLastHigh.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastHigh.Name = "txtLastHigh";
            this.txtLastHigh.ReadOnly = true;
            this.txtLastHigh.Size = new System.Drawing.Size(143, 15);
            this.txtLastHigh.TabIndex = 19;
            // 
            // txtLastClose
            // 
            this.txtLastClose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastClose.Location = new System.Drawing.Point(495, 34);
            this.txtLastClose.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastClose.Name = "txtLastClose";
            this.txtLastClose.ReadOnly = true;
            this.txtLastClose.Size = new System.Drawing.Size(143, 15);
            this.txtLastClose.TabIndex = 18;
            // 
            // timerObservations
            // 
            this.timerObservations.Interval = 10;
            this.timerObservations.Tick += new System.EventHandler(this.timerObservations_Tick);
            // 
            // txtLow
            // 
            this.txtLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLow.Location = new System.Drawing.Point(199, 134);
            this.txtLow.Margin = new System.Windows.Forms.Padding(4);
            this.txtLow.Name = "txtLow";
            this.txtLow.ReadOnly = true;
            this.txtLow.Size = new System.Drawing.Size(143, 15);
            this.txtLow.TabIndex = 24;
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.ForeColor = System.Drawing.Color.Blue;
            this.lblLow.Location = new System.Drawing.Point(13, 134);
            this.lblLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(39, 16);
            this.lblLow.TabIndex = 23;
            this.lblLow.Text = "Low:";
            // 
            // txtScanTime
            // 
            this.txtScanTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScanTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanTime.Location = new System.Drawing.Point(495, 201);
            this.txtScanTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtScanTime.Name = "txtScanTime";
            this.txtScanTime.ReadOnly = true;
            this.txtScanTime.Size = new System.Drawing.Size(143, 15);
            this.txtScanTime.TabIndex = 26;
            // 
            // lblScanTime
            // 
            this.lblScanTime.AutoSize = true;
            this.lblScanTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanTime.ForeColor = System.Drawing.Color.Blue;
            this.lblScanTime.Location = new System.Drawing.Point(378, 201);
            this.lblScanTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanTime.Name = "lblScanTime";
            this.lblScanTime.Size = new System.Drawing.Size(80, 16);
            this.lblScanTime.TabIndex = 25;
            this.lblScanTime.Text = "Last Scan:";
            // 
            // txtLongPredicted
            // 
            this.txtLongPredicted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLongPredicted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongPredicted.Location = new System.Drawing.Point(199, 201);
            this.txtLongPredicted.Margin = new System.Windows.Forms.Padding(4);
            this.txtLongPredicted.Name = "txtLongPredicted";
            this.txtLongPredicted.ReadOnly = true;
            this.txtLongPredicted.Size = new System.Drawing.Size(143, 15);
            this.txtLongPredicted.TabIndex = 28;
            // 
            // longPredicted
            // 
            this.longPredicted.AutoSize = true;
            this.longPredicted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longPredicted.ForeColor = System.Drawing.Color.Blue;
            this.longPredicted.Location = new System.Drawing.Point(13, 200);
            this.longPredicted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longPredicted.Name = "longPredicted";
            this.longPredicted.Size = new System.Drawing.Size(117, 16);
            this.longPredicted.TabIndex = 27;
            this.longPredicted.Text = "Long Predicted:";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // smartStopToolStripMenuItem
            // 
            this.smartStopToolStripMenuItem.CheckOnClick = true;
            this.smartStopToolStripMenuItem.Name = "smartStopToolStripMenuItem";
            this.smartStopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.smartStopToolStripMenuItem.Text = "Smart Stop?";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 330);
            this.Controls.Add(this.txtLongPredicted);
            this.Controls.Add(this.longPredicted);
            this.Controls.Add(this.txtScanTime);
            this.Controls.Add(this.lblScanTime);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.txtLastVolume);
            this.Controls.Add(this.txtLastOpen);
            this.Controls.Add(this.txtLastLow);
            this.Controls.Add(this.txtLastHigh);
            this.Controls.Add(this.txtLastClose);
            this.Controls.Add(this.txtOrderStatus);
            this.Controls.Add(this.txtShortPredicted);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblShortPredicted);
            this.Controls.Add(this.lblLastVolume);
            this.Controls.Add(this.lblLastOpen);
            this.Controls.Add(this.lblLastLow);
            this.Controls.Add(this.lblLastHigh);
            this.Controls.Add(this.lblLastClose);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNeedToConfigure);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "ProfitChartBot - Machine Learning Based";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblNeedToConfigure;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLastClose;
        private System.Windows.Forms.Label lblLastHigh;
        private System.Windows.Forms.Label lblLastLow;
        private System.Windows.Forms.Label lblLastOpen;
        private System.Windows.Forms.Label lblLastVolume;
        private System.Windows.Forms.Label lblShortPredicted;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtShortPredicted;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.TextBox txtLastVolume;
        private System.Windows.Forms.TextBox txtLastOpen;
        private System.Windows.Forms.TextBox txtLastLow;
        private System.Windows.Forms.TextBox txtLastHigh;
        private System.Windows.Forms.TextBox txtLastClose;
        private System.Windows.Forms.Timer timerObservations;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.TextBox txtScanTime;
        private System.Windows.Forms.Label lblScanTime;
        private System.Windows.Forms.TextBox txtLongPredicted;
        private System.Windows.Forms.Label longPredicted;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smartStopToolStripMenuItem;
    }
}

