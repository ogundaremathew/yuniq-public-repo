namespace JmTech_Link_Gen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.fileType = new DevExpress.XtraEditors.RadioGroup();
            this.providerLabel = new DevExpress.XtraEditors.LabelControl();
            this.hostProvider = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.browseButton = new DevExpress.XtraEditors.SimpleButton();
            this.filename = new DevExpress.XtraEditors.TextEdit();
            this.ZipOrFolder = new DevExpress.XtraEditors.LabelControl();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderDialog = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.BottomLine = new System.Windows.Forms.Label();
            this.statusName = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostProvider.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filename.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AllowFocus = false;
            this.startButton.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.startButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.startButton.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.startButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.startButton.Appearance.Options.UseBackColor = true;
            this.startButton.Appearance.Options.UseBorderColor = true;
            this.startButton.Appearance.Options.UseFont = true;
            this.startButton.Appearance.Options.UseForeColor = true;
            this.startButton.Appearance.Options.UseTextOptions = true;
            this.startButton.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.startButton.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.startButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.startButton.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.startButton.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.startButton.AppearanceHovered.Options.UseBackColor = true;
            this.startButton.AppearanceHovered.Options.UseBorderColor = true;
            this.startButton.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.startButton.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.startButton.AppearancePressed.Options.UseBackColor = true;
            this.startButton.AppearancePressed.Options.UseBorderColor = true;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Location = new System.Drawing.Point(169, 58);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startButton.Name = "startButton";
            this.startButton.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.startButton.Size = new System.Drawing.Size(245, 80);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Generate";
            this.startButton.ToolTip = "Click here to generate link for your page";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Controls.Add(this.fileType);
            this.panel1.Controls.Add(this.providerLabel);
            this.panel1.Controls.Add(this.hostProvider);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1676, 189);
            this.panel1.TabIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.startButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(1163, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(513, 189);
            this.panelControl1.TabIndex = 5;
            // 
            // simpleButton3
            // 
            this.simpleButton3.AllowFocus = false;
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 5F);
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.simpleButton3.Location = new System.Drawing.Point(60, 69);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton3.Size = new System.Drawing.Size(60, 60);
            this.simpleButton3.TabIndex = 4;
            // 
            // fileType
            // 
            this.fileType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileType.EditValue = "file";
            this.fileType.Location = new System.Drawing.Point(665, 86);
            this.fileType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileType.Name = "fileType";
            this.fileType.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.fileType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fileType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.1F, System.Drawing.FontStyle.Italic);
            this.fileType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.fileType.Properties.Appearance.Options.UseBackColor = true;
            this.fileType.Properties.Appearance.Options.UseFont = true;
            this.fileType.Properties.Appearance.Options.UseForeColor = true;
            this.fileType.Properties.Appearance.Options.UseTextOptions = true;
            this.fileType.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.fileType.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.fileType.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.fileType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.fileType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("file", "Zip or html file"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("folder", "Root Folder")});
            this.fileType.Size = new System.Drawing.Size(583, 64);
            this.fileType.TabIndex = 3;
            this.fileType.SelectedIndexChanged += new System.EventHandler(this.FileType_SelectedIndexChanged);
            // 
            // providerLabel
            // 
            this.providerLabel.AllowHtmlString = true;
            this.providerLabel.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.providerLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.providerLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.providerLabel.Appearance.Options.UseFont = true;
            this.providerLabel.Appearance.Options.UseForeColor = true;
            this.providerLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.providerLabel.Location = new System.Drawing.Point(88, 33);
            this.providerLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(294, 37);
            this.providerLabel.TabIndex = 2;
            this.providerLabel.Text = "Select  preferred Provider";
            // 
            // hostProvider
            // 
            this.hostProvider.Location = new System.Drawing.Point(75, 82);
            this.hostProvider.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hostProvider.Name = "hostProvider";
            this.hostProvider.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.hostProvider.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.hostProvider.Properties.Appearance.Options.UseBackColor = true;
            this.hostProvider.Properties.Appearance.Options.UseFont = true;
            this.hostProvider.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hostProvider.Properties.NullText = "Please select one";
            this.hostProvider.Size = new System.Drawing.Size(470, 80);
            this.hostProvider.TabIndex = 0;
            this.hostProvider.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Blockinput_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 189);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1676, 536);
            this.panel2.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.AllowHtmlString = true;
            this.labelControl2.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Italic);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(165)))), ((int)(((byte)(53)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl2.Location = new System.Drawing.Point(0, 374);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Padding = new System.Windows.Forms.Padding(90, 20, 90, 10);
            this.labelControl2.Size = new System.Drawing.Size(1676, 154);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = resources.GetString("labelControl2.Text");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkEdit1);
            this.panel4.Controls.Add(this.labelControl1);
            this.panel4.Controls.Add(this.textEdit1);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1676, 184);
            this.panel4.TabIndex = 12;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkEdit1.Location = new System.Drawing.Point(1037, 110);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.checkEdit1.Properties.Caption = "Update previous link";
            this.checkEdit1.Size = new System.Drawing.Size(350, 48);
            this.checkEdit1.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.4F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(99, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(558, 35);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Project name (without space or special characters)";
            // 
            // textEdit1
            // 
            this.textEdit1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(88, 90);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.textEdit1.Properties.NullText = "Link name (without space)";
            this.textEdit1.Properties.NullValuePrompt = "Link name (without space)";
            this.textEdit1.Properties.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.textEdit1.Size = new System.Drawing.Size(824, 84);
            this.textEdit1.TabIndex = 2;
            this.textEdit1.ToolTip = resources.GetString("textEdit1.ToolTip");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sidePanel1);
            this.panel3.Controls.Add(this.ZipOrFolder);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 90, 0);
            this.panel3.Size = new System.Drawing.Size(1676, 190);
            this.panel3.TabIndex = 11;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel1.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Appearance.Options.UseBorderColor = true;
            this.sidePanel1.Controls.Add(this.browseButton);
            this.sidePanel1.Controls.Add(this.filename);
            this.sidePanel1.Location = new System.Drawing.Point(88, 96);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1501, 84);
            this.sidePanel1.TabIndex = 9;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // browseButton
            // 
            this.browseButton.AllowFocus = false;
            this.browseButton.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.browseButton.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.browseButton.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.browseButton.Appearance.Options.UseBackColor = true;
            this.browseButton.Appearance.Options.UseBorderColor = true;
            this.browseButton.Appearance.Options.UseFont = true;
            this.browseButton.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.browseButton.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.browseButton.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.browseButton.AppearanceHovered.Options.UseBackColor = true;
            this.browseButton.AppearanceHovered.Options.UseBorderColor = true;
            this.browseButton.AppearanceHovered.Options.UseFont = true;
            this.browseButton.AppearanceHovered.Options.UseForeColor = true;
            this.browseButton.AppearanceHovered.Options.UseTextOptions = true;
            this.browseButton.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.browseButton.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.browseButton.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.browseButton.AppearancePressed.Options.UseBackColor = true;
            this.browseButton.AppearancePressed.Options.UseBorderColor = true;
            this.browseButton.AppearancePressed.Options.UseFont = true;
            this.browseButton.AppearancePressed.Options.UseForeColor = true;
            this.browseButton.AppearancePressed.Options.UseTextOptions = true;
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.browseButton.Location = new System.Drawing.Point(934, 0);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(567, 84);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.Click += new System.EventHandler(this.BrowseFileAndFolder_click);
            // 
            // filename
            // 
            this.filename.Cursor = System.Windows.Forms.Cursors.Default;
            this.filename.Dock = System.Windows.Forms.DockStyle.Left;
            this.filename.EditValue = "";
            this.filename.Location = new System.Drawing.Point(0, 0);
            this.filename.Margin = new System.Windows.Forms.Padding(0);
            this.filename.Name = "filename";
            this.filename.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.filename.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.filename.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.filename.Properties.Appearance.Options.UseFont = true;
            this.filename.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.filename.Properties.NullText = "Pick file from your computer...";
            this.filename.Properties.NullValuePrompt = "Pick file from your computer...";
            this.filename.Properties.Padding = new System.Windows.Forms.Padding(10, 2, 450, 2);
            this.filename.Size = new System.Drawing.Size(1498, 84);
            this.filename.TabIndex = 0;
            this.filename.EditValueChanged += new System.EventHandler(this.filename_EditValueChanged);
            this.filename.Click += new System.EventHandler(this.BrowseFileAndFolder_click);
            this.filename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Blockinput_KeyPress);
            // 
            // ZipOrFolder
            // 
            this.ZipOrFolder.AllowHtmlString = true;
            this.ZipOrFolder.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.ZipOrFolder.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.4F);
            this.ZipOrFolder.Appearance.Options.UseFont = true;
            this.ZipOrFolder.Cursor = System.Windows.Forms.Cursors.Default;
            this.ZipOrFolder.Location = new System.Drawing.Point(99, 63);
            this.ZipOrFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZipOrFolder.Name = "ZipOrFolder";
            this.ZipOrFolder.Size = new System.Drawing.Size(504, 35);
            this.ZipOrFolder.TabIndex = 8;
            this.ZipOrFolder.Text = "Please select your page file (zip, html or htm).";
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "JmTech Page Files (*.zip;*.html;*.htm)|*.zip;*.html;*.htm|ZIP Files (*.zip)|*.zip" +
    "|HTML Files (*.html;*.htm)|*.html;*.htm";
            this.fileDialog.RestoreDirectory = true;
            this.fileDialog.ShowHelp = true;
            this.fileDialog.Title = "Please select your page file (zip, html or htm).";
            // 
            // folderDialog
            // 
            this.folderDialog.DialogStyle = DevExpress.Utils.CommonDialogs.FolderBrowserDialogStyle.Wide;
            this.folderDialog.SelectedPath = "xtraFolderBrowserDialog1";
            this.folderDialog.ShowNewFolderButton = false;
            this.folderDialog.Title = "Select folder where you have your html page";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.statusName);
            this.panel5.Controls.Add(this.BottomLine);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 873);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1676, 69);
            this.panel5.TabIndex = 9;
            // 
            // BottomLine
            // 
            this.BottomLine.BackColor = System.Drawing.Color.DarkGray;
            this.BottomLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.BottomLine.Location = new System.Drawing.Point(0, 0);
            this.BottomLine.Name = "BottomLine";
            this.BottomLine.Size = new System.Drawing.Size(1676, 2);
            this.BottomLine.TabIndex = 0;
            // 
            // statusName
            // 
            this.statusName.AutoEllipsis = true;
            this.statusName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusName.Location = new System.Drawing.Point(0, 2);
            this.statusName.Name = "statusName";
            this.statusName.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.statusName.Size = new System.Drawing.Size(1676, 67);
            this.statusName.TabIndex = 1;
            this.statusName.Text = "Ready";
            this.statusName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Appearance.Options.UseForeColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 723);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1676, 150);
            this.panelControl2.TabIndex = 10;
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 942);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1771, 1226);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Link Generator (Normal)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostProvider.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filename.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton startButton;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit hostProvider;
        private DevExpress.XtraEditors.LabelControl providerLabel;
        private DevExpress.XtraEditors.RadioGroup fileType;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton browseButton;
        private DevExpress.XtraEditors.TextEdit filename;
        private DevExpress.XtraEditors.LabelControl ZipOrFolder;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog folderDialog;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label BottomLine;
        private System.Windows.Forms.Label statusName;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}

