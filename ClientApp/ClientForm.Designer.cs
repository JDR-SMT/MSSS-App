namespace ClientApp
{
	partial class ClientForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItemLanguage = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemFrench = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemGerman = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemEnglish = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemTheme = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemLight = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemDark = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemCustom = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemForeColor = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemBackColor = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemStyle = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.DataGridViewOutput = new System.Windows.Forms.DataGridView();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStarVelocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStarDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnKelvin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnEventHorizon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TextBoxInputWavelengthObserved = new System.Windows.Forms.TextBox();
			this.TextBoxInputWavelengthRest = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TextBoxInputParallax = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TextBoxInputCelsius = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ButtonCalculate = new System.Windows.Forms.Button();
			this.TextBoxInputMass = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.NumericUpDownInputMass = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.ColorDialog = new System.Windows.Forms.ColorDialog();
			this.FontDialog = new System.Windows.Forms.FontDialog();
			this.ButtonLanguage = new System.Windows.Forms.Button();
			this.ButtonTheme = new System.Windows.Forms.Button();
			this.ButtonStyle = new System.Windows.Forms.Button();
			this.ButtonFrench = new System.Windows.Forms.Button();
			this.ButtonGerman = new System.Windows.Forms.Button();
			this.ButtonEnglish = new System.Windows.Forms.Button();
			this.ButtonLight = new System.Windows.Forms.Button();
			this.ButtonDark = new System.Windows.Forms.Button();
			this.ButtonCustom = new System.Windows.Forms.Button();
			this.ButtonForeground = new System.Windows.Forms.Button();
			this.ButtonBackground = new System.Windows.Forms.Button();
			this.ButtonFont = new System.Windows.Forms.Button();
			this.TextBoxInputName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.ToolTipNanometres = new System.Windows.Forms.ToolTip(this.components);
			this.ToolTipArcseconds = new System.Windows.Forms.ToolTip(this.components);
			this.ToolTipCelsius = new System.Windows.Forms.ToolTip(this.components);
			this.ToolTipKilograms = new System.Windows.Forms.ToolTip(this.components);
			this.MenuStrip.SuspendLayout();
			this.StatusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInputMass)).BeginInit();
			this.SuspendLayout();
			// 
			// MenuStrip
			// 
			this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLanguage,
            this.ToolStripMenuItemTheme,
            this.ToolStripMenuItemStyle});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(972, 28);
			this.MenuStrip.TabIndex = 12;
			this.MenuStrip.Text = "menuStrip";
			// 
			// ToolStripMenuItemLanguage
			// 
			this.ToolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFrench,
            this.ToolStripMenuItemGerman,
            this.ToolStripMenuItemEnglish});
			this.ToolStripMenuItemLanguage.Name = "ToolStripMenuItemLanguage";
			this.ToolStripMenuItemLanguage.Size = new System.Drawing.Size(88, 24);
			this.ToolStripMenuItemLanguage.Text = "Language";
			// 
			// ToolStripMenuItemFrench
			// 
			this.ToolStripMenuItemFrench.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemFrench.Image")));
			this.ToolStripMenuItemFrench.Name = "ToolStripMenuItemFrench";
			this.ToolStripMenuItemFrench.Size = new System.Drawing.Size(224, 26);
			this.ToolStripMenuItemFrench.Text = "French";
			this.ToolStripMenuItemFrench.Click += new System.EventHandler(this.ToolStripMenuItemFrench_Click);
			// 
			// ToolStripMenuItemGerman
			// 
			this.ToolStripMenuItemGerman.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemGerman.Image")));
			this.ToolStripMenuItemGerman.Name = "ToolStripMenuItemGerman";
			this.ToolStripMenuItemGerman.Size = new System.Drawing.Size(224, 26);
			this.ToolStripMenuItemGerman.Text = "German";
			this.ToolStripMenuItemGerman.Click += new System.EventHandler(this.ToolStripMenuItemGerman_Click);
			// 
			// ToolStripMenuItemEnglish
			// 
			this.ToolStripMenuItemEnglish.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemEnglish.Image")));
			this.ToolStripMenuItemEnglish.Name = "ToolStripMenuItemEnglish";
			this.ToolStripMenuItemEnglish.Size = new System.Drawing.Size(224, 26);
			this.ToolStripMenuItemEnglish.Text = "English";
			this.ToolStripMenuItemEnglish.Click += new System.EventHandler(this.ToolStripMenuItemEnglish_Click);
			// 
			// ToolStripMenuItemTheme
			// 
			this.ToolStripMenuItemTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLight,
            this.ToolStripMenuItemDark,
            this.ToolStripMenuItemCustom});
			this.ToolStripMenuItemTheme.Name = "ToolStripMenuItemTheme";
			this.ToolStripMenuItemTheme.Size = new System.Drawing.Size(68, 24);
			this.ToolStripMenuItemTheme.Text = "Theme";
			// 
			// ToolStripMenuItemLight
			// 
			this.ToolStripMenuItemLight.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemLight.Image")));
			this.ToolStripMenuItemLight.Name = "ToolStripMenuItemLight";
			this.ToolStripMenuItemLight.Size = new System.Drawing.Size(142, 26);
			this.ToolStripMenuItemLight.Text = "Light";
			this.ToolStripMenuItemLight.Click += new System.EventHandler(this.ToolStripMenuItemLight_Click);
			// 
			// ToolStripMenuItemDark
			// 
			this.ToolStripMenuItemDark.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemDark.Image")));
			this.ToolStripMenuItemDark.Name = "ToolStripMenuItemDark";
			this.ToolStripMenuItemDark.Size = new System.Drawing.Size(142, 26);
			this.ToolStripMenuItemDark.Text = "Dark";
			this.ToolStripMenuItemDark.Click += new System.EventHandler(this.ToolStripMenuItemDark_Click);
			// 
			// ToolStripMenuItemCustom
			// 
			this.ToolStripMenuItemCustom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemForeColor,
            this.ToolStripMenuItemBackColor});
			this.ToolStripMenuItemCustom.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemCustom.Image")));
			this.ToolStripMenuItemCustom.Name = "ToolStripMenuItemCustom";
			this.ToolStripMenuItemCustom.Size = new System.Drawing.Size(142, 26);
			this.ToolStripMenuItemCustom.Text = "Custom";
			// 
			// ToolStripMenuItemForeColor
			// 
			this.ToolStripMenuItemForeColor.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemForeColor.Image")));
			this.ToolStripMenuItemForeColor.Name = "ToolStripMenuItemForeColor";
			this.ToolStripMenuItemForeColor.Size = new System.Drawing.Size(219, 26);
			this.ToolStripMenuItemForeColor.Text = "Foreground Colour";
			this.ToolStripMenuItemForeColor.Click += new System.EventHandler(this.ToolStripMenuItemForeColor_Click);
			// 
			// ToolStripMenuItemBackColor
			// 
			this.ToolStripMenuItemBackColor.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemBackColor.Image")));
			this.ToolStripMenuItemBackColor.Name = "ToolStripMenuItemBackColor";
			this.ToolStripMenuItemBackColor.Size = new System.Drawing.Size(219, 26);
			this.ToolStripMenuItemBackColor.Text = "Background Colour";
			this.ToolStripMenuItemBackColor.Click += new System.EventHandler(this.ToolStripMenuItemBackColor_Click);
			// 
			// ToolStripMenuItemStyle
			// 
			this.ToolStripMenuItemStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFont});
			this.ToolStripMenuItemStyle.Name = "ToolStripMenuItemStyle";
			this.ToolStripMenuItemStyle.Size = new System.Drawing.Size(55, 24);
			this.ToolStripMenuItemStyle.Text = "Style";
			// 
			// ToolStripMenuItemFont
			// 
			this.ToolStripMenuItemFont.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemFont.Image")));
			this.ToolStripMenuItemFont.Name = "ToolStripMenuItemFont";
			this.ToolStripMenuItemFont.Size = new System.Drawing.Size(121, 26);
			this.ToolStripMenuItemFont.Text = "Font";
			this.ToolStripMenuItemFont.Click += new System.EventHandler(this.ToolStripMenuItemFont_Click);
			// 
			// StatusStrip
			// 
			this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
			this.StatusStrip.Location = new System.Drawing.Point(0, 662);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(972, 22);
			this.StatusStrip.TabIndex = 2;
			this.StatusStrip.Text = "statusStrip1";
			// 
			// ToolStripStatusLabel
			// 
			this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
			this.ToolStripStatusLabel.Size = new System.Drawing.Size(0, 16);
			// 
			// DataGridViewOutput
			// 
			this.DataGridViewOutput.AllowUserToAddRows = false;
			this.DataGridViewOutput.AllowUserToDeleteRows = false;
			this.DataGridViewOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridViewOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.DataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridViewOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnStarVelocity,
            this.ColumnStarDistance,
            this.ColumnKelvin,
            this.ColumnEventHorizon});
			this.DataGridViewOutput.EnableHeadersVisualStyles = false;
			this.DataGridViewOutput.Location = new System.Drawing.Point(250, 50);
			this.DataGridViewOutput.Name = "DataGridViewOutput";
			this.DataGridViewOutput.ReadOnly = true;
			this.DataGridViewOutput.RowHeadersVisible = false;
			this.DataGridViewOutput.RowHeadersWidth = 51;
			this.DataGridViewOutput.RowTemplate.Height = 24;
			this.DataGridViewOutput.Size = new System.Drawing.Size(700, 540);
			this.DataGridViewOutput.TabIndex = 11;
			this.DataGridViewOutput.TabStop = false;
			// 
			// ColumnName
			// 
			this.ColumnName.HeaderText = "Name";
			this.ColumnName.MinimumWidth = 6;
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			// 
			// ColumnStarVelocity
			// 
			this.ColumnStarVelocity.HeaderText = "Star Velocity";
			this.ColumnStarVelocity.MinimumWidth = 6;
			this.ColumnStarVelocity.Name = "ColumnStarVelocity";
			this.ColumnStarVelocity.ReadOnly = true;
			// 
			// ColumnStarDistance
			// 
			this.ColumnStarDistance.HeaderText = "Star Distance";
			this.ColumnStarDistance.MinimumWidth = 6;
			this.ColumnStarDistance.Name = "ColumnStarDistance";
			this.ColumnStarDistance.ReadOnly = true;
			// 
			// ColumnKelvin
			// 
			this.ColumnKelvin.HeaderText = "Kelvin";
			this.ColumnKelvin.MinimumWidth = 6;
			this.ColumnKelvin.Name = "ColumnKelvin";
			this.ColumnKelvin.ReadOnly = true;
			// 
			// ColumnEventHorizon
			// 
			this.ColumnEventHorizon.HeaderText = "Event Horizon";
			this.ColumnEventHorizon.MinimumWidth = 6;
			this.ColumnEventHorizon.Name = "ColumnEventHorizon";
			this.ColumnEventHorizon.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 150);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "STAR VELOCITY";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Observed Wavelength";
			// 
			// TextBoxInputWavelengthObserved
			// 
			this.TextBoxInputWavelengthObserved.Location = new System.Drawing.Point(20, 200);
			this.TextBoxInputWavelengthObserved.Name = "TextBoxInputWavelengthObserved";
			this.TextBoxInputWavelengthObserved.Size = new System.Drawing.Size(150, 22);
			this.TextBoxInputWavelengthObserved.TabIndex = 1;
			this.TextBoxInputWavelengthObserved.Text = "500.1";
			this.TextBoxInputWavelengthObserved.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// TextBoxInputWavelengthRest
			// 
			this.TextBoxInputWavelengthRest.Location = new System.Drawing.Point(20, 260);
			this.TextBoxInputWavelengthRest.Name = "TextBoxInputWavelengthRest";
			this.TextBoxInputWavelengthRest.Size = new System.Drawing.Size(150, 22);
			this.TextBoxInputWavelengthRest.TabIndex = 2;
			this.TextBoxInputWavelengthRest.Text = "500.0";
			this.TextBoxInputWavelengthRest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Wavelength At Rest";
			// 
			// TextBoxInputParallax
			// 
			this.TextBoxInputParallax.Location = new System.Drawing.Point(20, 360);
			this.TextBoxInputParallax.Name = "TextBoxInputParallax";
			this.TextBoxInputParallax.Size = new System.Drawing.Size(150, 22);
			this.TextBoxInputParallax.TabIndex = 3;
			this.TextBoxInputParallax.Text = "0.547";
			this.TextBoxInputParallax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			this.TextBoxInputParallax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 340);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Parallax Angle";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 310);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(155, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "STAR DISTANCE";
			// 
			// TextBoxInputCelsius
			// 
			this.TextBoxInputCelsius.Location = new System.Drawing.Point(20, 460);
			this.TextBoxInputCelsius.Name = "TextBoxInputCelsius";
			this.TextBoxInputCelsius.Size = new System.Drawing.Size(150, 22);
			this.TextBoxInputCelsius.TabIndex = 4;
			this.TextBoxInputCelsius.Text = "27";
			this.TextBoxInputCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			this.TextBoxInputCelsius.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 440);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 16);
			this.label6.TabIndex = 19;
			this.label6.Text = "Temperature";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(20, 410);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 20);
			this.label7.TabIndex = 18;
			this.label7.Text = "KELVIN";
			// 
			// ButtonCalculate
			// 
			this.ButtonCalculate.Location = new System.Drawing.Point(140, 610);
			this.ButtonCalculate.Name = "ButtonCalculate";
			this.ButtonCalculate.Size = new System.Drawing.Size(90, 30);
			this.ButtonCalculate.TabIndex = 7;
			this.ButtonCalculate.Text = "Calculate";
			this.ButtonCalculate.UseVisualStyleBackColor = true;
			this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
			// 
			// TextBoxInputMass
			// 
			this.TextBoxInputMass.Location = new System.Drawing.Point(20, 560);
			this.TextBoxInputMass.Name = "TextBoxInputMass";
			this.TextBoxInputMass.Size = new System.Drawing.Size(80, 22);
			this.TextBoxInputMass.TabIndex = 5;
			this.TextBoxInputMass.Text = "8.2";
			this.TextBoxInputMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			this.TextBoxInputMass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 540);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(109, 16);
			this.label8.TabIndex = 23;
			this.label8.Text = "Black Hole Mass";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(20, 510);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(158, 20);
			this.label9.TabIndex = 22;
			this.label9.Text = "EVENT HORIZON";
			// 
			// NumericUpDownInputMass
			// 
			this.NumericUpDownInputMass.Location = new System.Drawing.Point(150, 550);
			this.NumericUpDownInputMass.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.NumericUpDownInputMass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumericUpDownInputMass.Name = "NumericUpDownInputMass";
			this.NumericUpDownInputMass.Size = new System.Drawing.Size(40, 22);
			this.NumericUpDownInputMass.TabIndex = 6;
			this.NumericUpDownInputMass.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(110, 560);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(30, 16);
			this.label10.TabIndex = 27;
			this.label10.Text = "x 10";
			// 
			// ColorDialog
			// 
			this.ColorDialog.AllowFullOpen = false;
			// 
			// FontDialog
			// 
			this.FontDialog.AllowVerticalFonts = false;
			this.FontDialog.MaxSize = 12;
			this.FontDialog.ShowEffects = false;
			// 
			// ButtonLanguage
			// 
			this.ButtonLanguage.Location = new System.Drawing.Point(690, 610);
			this.ButtonLanguage.Name = "ButtonLanguage";
			this.ButtonLanguage.Size = new System.Drawing.Size(90, 30);
			this.ButtonLanguage.TabIndex = 8;
			this.ButtonLanguage.Text = "Language";
			this.ButtonLanguage.UseVisualStyleBackColor = true;
			this.ButtonLanguage.Click += new System.EventHandler(this.ButtonLanguage_Click);
			// 
			// ButtonTheme
			// 
			this.ButtonTheme.Location = new System.Drawing.Point(790, 610);
			this.ButtonTheme.Name = "ButtonTheme";
			this.ButtonTheme.Size = new System.Drawing.Size(80, 30);
			this.ButtonTheme.TabIndex = 9;
			this.ButtonTheme.Text = "Theme";
			this.ButtonTheme.UseVisualStyleBackColor = true;
			this.ButtonTheme.Click += new System.EventHandler(this.ButtonTheme_Click);
			// 
			// ButtonStyle
			// 
			this.ButtonStyle.Location = new System.Drawing.Point(880, 610);
			this.ButtonStyle.Name = "ButtonStyle";
			this.ButtonStyle.Size = new System.Drawing.Size(70, 30);
			this.ButtonStyle.TabIndex = 10;
			this.ButtonStyle.Text = "Style";
			this.ButtonStyle.UseVisualStyleBackColor = true;
			this.ButtonStyle.Click += new System.EventHandler(this.ButtonStyle_Click);
			// 
			// ButtonFrench
			// 
			this.ButtonFrench.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFrench.Image")));
			this.ButtonFrench.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonFrench.Location = new System.Drawing.Point(590, 610);
			this.ButtonFrench.Name = "ButtonFrench";
			this.ButtonFrench.Size = new System.Drawing.Size(90, 30);
			this.ButtonFrench.TabIndex = 31;
			this.ButtonFrench.Text = "French";
			this.ButtonFrench.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonFrench.UseVisualStyleBackColor = true;
			this.ButtonFrench.Visible = false;
			this.ButtonFrench.Click += new System.EventHandler(this.ButtonFrench_Click);
			// 
			// ButtonGerman
			// 
			this.ButtonGerman.Image = ((System.Drawing.Image)(resources.GetObject("ButtonGerman.Image")));
			this.ButtonGerman.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonGerman.Location = new System.Drawing.Point(490, 610);
			this.ButtonGerman.Name = "ButtonGerman";
			this.ButtonGerman.Size = new System.Drawing.Size(90, 30);
			this.ButtonGerman.TabIndex = 32;
			this.ButtonGerman.Text = "German";
			this.ButtonGerman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonGerman.UseVisualStyleBackColor = true;
			this.ButtonGerman.Visible = false;
			this.ButtonGerman.Click += new System.EventHandler(this.ButtonGerman_Click);
			// 
			// ButtonEnglish
			// 
			this.ButtonEnglish.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEnglish.Image")));
			this.ButtonEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonEnglish.Location = new System.Drawing.Point(390, 610);
			this.ButtonEnglish.Name = "ButtonEnglish";
			this.ButtonEnglish.Size = new System.Drawing.Size(90, 30);
			this.ButtonEnglish.TabIndex = 33;
			this.ButtonEnglish.Text = "English";
			this.ButtonEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonEnglish.UseVisualStyleBackColor = true;
			this.ButtonEnglish.Visible = false;
			this.ButtonEnglish.Click += new System.EventHandler(this.ButtonEnglish_Click);
			// 
			// ButtonLight
			// 
			this.ButtonLight.Image = ((System.Drawing.Image)(resources.GetObject("ButtonLight.Image")));
			this.ButtonLight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonLight.Location = new System.Drawing.Point(700, 610);
			this.ButtonLight.Name = "ButtonLight";
			this.ButtonLight.Size = new System.Drawing.Size(80, 30);
			this.ButtonLight.TabIndex = 34;
			this.ButtonLight.Text = "Light";
			this.ButtonLight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonLight.UseVisualStyleBackColor = true;
			this.ButtonLight.Visible = false;
			this.ButtonLight.Click += new System.EventHandler(this.ButtonLight_Click);
			// 
			// ButtonDark
			// 
			this.ButtonDark.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDark.Image")));
			this.ButtonDark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonDark.Location = new System.Drawing.Point(610, 610);
			this.ButtonDark.Name = "ButtonDark";
			this.ButtonDark.Size = new System.Drawing.Size(80, 30);
			this.ButtonDark.TabIndex = 35;
			this.ButtonDark.Text = "Dark";
			this.ButtonDark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonDark.UseVisualStyleBackColor = true;
			this.ButtonDark.Visible = false;
			this.ButtonDark.Click += new System.EventHandler(this.ButtonDark_Click);
			// 
			// ButtonCustom
			// 
			this.ButtonCustom.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCustom.Image")));
			this.ButtonCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonCustom.Location = new System.Drawing.Point(510, 610);
			this.ButtonCustom.Name = "ButtonCustom";
			this.ButtonCustom.Size = new System.Drawing.Size(90, 30);
			this.ButtonCustom.TabIndex = 36;
			this.ButtonCustom.Text = "Custom";
			this.ButtonCustom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonCustom.UseVisualStyleBackColor = true;
			this.ButtonCustom.Visible = false;
			this.ButtonCustom.Click += new System.EventHandler(this.ButtonCustom_Click);
			// 
			// ButtonForeground
			// 
			this.ButtonForeground.Image = ((System.Drawing.Image)(resources.GetObject("ButtonForeground.Image")));
			this.ButtonForeground.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonForeground.Location = new System.Drawing.Point(380, 610);
			this.ButtonForeground.Name = "ButtonForeground";
			this.ButtonForeground.Size = new System.Drawing.Size(120, 30);
			this.ButtonForeground.TabIndex = 37;
			this.ButtonForeground.Text = "Foreground";
			this.ButtonForeground.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonForeground.UseVisualStyleBackColor = true;
			this.ButtonForeground.Visible = false;
			this.ButtonForeground.Click += new System.EventHandler(this.ButtonForeground_Click);
			// 
			// ButtonBackground
			// 
			this.ButtonBackground.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBackground.Image")));
			this.ButtonBackground.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonBackground.Location = new System.Drawing.Point(250, 610);
			this.ButtonBackground.Name = "ButtonBackground";
			this.ButtonBackground.Size = new System.Drawing.Size(120, 30);
			this.ButtonBackground.TabIndex = 38;
			this.ButtonBackground.Text = "Background";
			this.ButtonBackground.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonBackground.UseVisualStyleBackColor = true;
			this.ButtonBackground.Visible = false;
			this.ButtonBackground.Click += new System.EventHandler(this.ButtonBackground_Click);
			// 
			// ButtonFont
			// 
			this.ButtonFont.Image = ((System.Drawing.Image)(resources.GetObject("ButtonFont.Image")));
			this.ButtonFont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonFont.Location = new System.Drawing.Point(800, 610);
			this.ButtonFont.Name = "ButtonFont";
			this.ButtonFont.Size = new System.Drawing.Size(70, 30);
			this.ButtonFont.TabIndex = 39;
			this.ButtonFont.Text = "Font";
			this.ButtonFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonFont.UseVisualStyleBackColor = true;
			this.ButtonFont.Visible = false;
			this.ButtonFont.Click += new System.EventHandler(this.ButtonFont_Click);
			// 
			// TextBoxInputName
			// 
			this.TextBoxInputName.Location = new System.Drawing.Point(20, 100);
			this.TextBoxInputName.Name = "TextBoxInputName";
			this.TextBoxInputName.Size = new System.Drawing.Size(150, 22);
			this.TextBoxInputName.TabIndex = 0;
			this.TextBoxInputName.Text = "Unknown";
			this.TextBoxInputName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(20, 80);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(127, 16);
			this.label11.TabIndex = 41;
			this.label11.Text = "Astronomical Object";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(20, 50);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(61, 20);
			this.label12.TabIndex = 40;
			this.label12.Text = "NAME";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(170, 200);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(25, 16);
			this.label13.TabIndex = 43;
			this.label13.Text = "nm";
			this.ToolTipNanometres.SetToolTip(this.label13, "Nanometres");
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(170, 260);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(25, 16);
			this.label14.TabIndex = 44;
			this.label14.Text = "nm";
			this.ToolTipNanometres.SetToolTip(this.label14, "Nanometres");
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(170, 360);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(12, 16);
			this.label15.TabIndex = 45;
			this.label15.Text = "\"";
			this.ToolTipArcseconds.SetToolTip(this.label15, "Arcseconds");
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(170, 460);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(20, 16);
			this.label16.TabIndex = 46;
			this.label16.Text = "°C";
			this.ToolTipCelsius.SetToolTip(this.label16, "Degrees Celsius");
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(200, 560);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(22, 16);
			this.label17.TabIndex = 47;
			this.label17.Text = "kg";
			this.ToolTipKilograms.SetToolTip(this.label17, "Kilograms");
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(972, 684);
			this.Controls.Add(this.NumericUpDownInputMass);
			this.Controls.Add(this.ButtonEnglish);
			this.Controls.Add(this.ButtonGerman);
			this.Controls.Add(this.ButtonFrench);
			this.Controls.Add(this.ButtonLanguage);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.TextBoxInputName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.ButtonBackground);
			this.Controls.Add(this.ButtonForeground);
			this.Controls.Add(this.ButtonCustom);
			this.Controls.Add(this.ButtonDark);
			this.Controls.Add(this.ButtonLight);
			this.Controls.Add(this.ButtonStyle);
			this.Controls.Add(this.ButtonTheme);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.ButtonCalculate);
			this.Controls.Add(this.TextBoxInputMass);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.TextBoxInputCelsius);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.TextBoxInputParallax);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TextBoxInputWavelengthRest);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TextBoxInputWavelengthObserved);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DataGridViewOutput);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.MenuStrip);
			this.Controls.Add(this.ButtonFont);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ClientForm";
			this.Text = "Malin Space Science Systems Application";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
			this.Load += new System.EventHandler(this.ClientForm_Load);
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInputMass)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLanguage;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEnglish;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFrench;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGerman;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTheme;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStyle;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLight;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDark;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCustom;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFont;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemForeColor;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBackColor;
		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.DataGridView DataGridViewOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TextBoxInputWavelengthObserved;
		private System.Windows.Forms.TextBox TextBoxInputWavelengthRest;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TextBoxInputParallax;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TextBoxInputCelsius;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button ButtonCalculate;
		private System.Windows.Forms.TextBox TextBoxInputMass;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown NumericUpDownInputMass;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ColorDialog ColorDialog;
		private System.Windows.Forms.FontDialog FontDialog;
		private System.Windows.Forms.Button ButtonLanguage;
		private System.Windows.Forms.Button ButtonTheme;
		private System.Windows.Forms.Button ButtonStyle;
		private System.Windows.Forms.Button ButtonFrench;
		private System.Windows.Forms.Button ButtonGerman;
		private System.Windows.Forms.Button ButtonEnglish;
		private System.Windows.Forms.Button ButtonLight;
		private System.Windows.Forms.Button ButtonDark;
		private System.Windows.Forms.Button ButtonCustom;
		private System.Windows.Forms.Button ButtonForeground;
		private System.Windows.Forms.Button ButtonBackground;
		private System.Windows.Forms.Button ButtonFont;
		private System.Windows.Forms.TextBox TextBoxInputName;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStarVelocity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStarDistance;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKelvin;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEventHorizon;
		private System.Windows.Forms.ToolTip ToolTipNanometres;
		private System.Windows.Forms.ToolTip ToolTipArcseconds;
		private System.Windows.Forms.ToolTip ToolTipCelsius;
		private System.Windows.Forms.ToolTip ToolTipKilograms;
		private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
	}
}

