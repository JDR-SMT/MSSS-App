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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.MenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInputMass)).BeginInit();
			this.SuspendLayout();
			// 
			// MenuStrip
			// 
			resources.ApplyResources(this.MenuStrip, "MenuStrip");
			this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLanguage,
            this.ToolStripMenuItemTheme,
            this.ToolStripMenuItemStyle});
			this.MenuStrip.Name = "MenuStrip";
			// 
			// ToolStripMenuItemLanguage
			// 
			resources.ApplyResources(this.ToolStripMenuItemLanguage, "ToolStripMenuItemLanguage");
			this.ToolStripMenuItemLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFrench,
            this.ToolStripMenuItemGerman,
            this.ToolStripMenuItemEnglish});
			this.ToolStripMenuItemLanguage.Name = "ToolStripMenuItemLanguage";
			// 
			// ToolStripMenuItemFrench
			// 
			resources.ApplyResources(this.ToolStripMenuItemFrench, "ToolStripMenuItemFrench");
			this.ToolStripMenuItemFrench.Name = "ToolStripMenuItemFrench";
			this.ToolStripMenuItemFrench.Click += new System.EventHandler(this.ToolStripMenuItemFrench_Click);
			// 
			// ToolStripMenuItemGerman
			// 
			resources.ApplyResources(this.ToolStripMenuItemGerman, "ToolStripMenuItemGerman");
			this.ToolStripMenuItemGerman.Name = "ToolStripMenuItemGerman";
			this.ToolStripMenuItemGerman.Click += new System.EventHandler(this.ToolStripMenuItemGerman_Click);
			// 
			// ToolStripMenuItemEnglish
			// 
			resources.ApplyResources(this.ToolStripMenuItemEnglish, "ToolStripMenuItemEnglish");
			this.ToolStripMenuItemEnglish.Name = "ToolStripMenuItemEnglish";
			this.ToolStripMenuItemEnglish.Click += new System.EventHandler(this.ToolStripMenuItemEnglish_Click);
			// 
			// ToolStripMenuItemTheme
			// 
			resources.ApplyResources(this.ToolStripMenuItemTheme, "ToolStripMenuItemTheme");
			this.ToolStripMenuItemTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLight,
            this.ToolStripMenuItemDark,
            this.ToolStripMenuItemCustom});
			this.ToolStripMenuItemTheme.Name = "ToolStripMenuItemTheme";
			// 
			// ToolStripMenuItemLight
			// 
			resources.ApplyResources(this.ToolStripMenuItemLight, "ToolStripMenuItemLight");
			this.ToolStripMenuItemLight.Name = "ToolStripMenuItemLight";
			this.ToolStripMenuItemLight.Click += new System.EventHandler(this.ToolStripMenuItemLight_Click);
			// 
			// ToolStripMenuItemDark
			// 
			resources.ApplyResources(this.ToolStripMenuItemDark, "ToolStripMenuItemDark");
			this.ToolStripMenuItemDark.Name = "ToolStripMenuItemDark";
			this.ToolStripMenuItemDark.Click += new System.EventHandler(this.ToolStripMenuItemDark_Click);
			// 
			// ToolStripMenuItemCustom
			// 
			resources.ApplyResources(this.ToolStripMenuItemCustom, "ToolStripMenuItemCustom");
			this.ToolStripMenuItemCustom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemForeColor,
            this.ToolStripMenuItemBackColor});
			this.ToolStripMenuItemCustom.Name = "ToolStripMenuItemCustom";
			// 
			// ToolStripMenuItemForeColor
			// 
			resources.ApplyResources(this.ToolStripMenuItemForeColor, "ToolStripMenuItemForeColor");
			this.ToolStripMenuItemForeColor.Name = "ToolStripMenuItemForeColor";
			this.ToolStripMenuItemForeColor.Click += new System.EventHandler(this.ToolStripMenuItemForeColor_Click);
			// 
			// ToolStripMenuItemBackColor
			// 
			resources.ApplyResources(this.ToolStripMenuItemBackColor, "ToolStripMenuItemBackColor");
			this.ToolStripMenuItemBackColor.Name = "ToolStripMenuItemBackColor";
			this.ToolStripMenuItemBackColor.Click += new System.EventHandler(this.ToolStripMenuItemBackColor_Click);
			// 
			// ToolStripMenuItemStyle
			// 
			resources.ApplyResources(this.ToolStripMenuItemStyle, "ToolStripMenuItemStyle");
			this.ToolStripMenuItemStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFont});
			this.ToolStripMenuItemStyle.Name = "ToolStripMenuItemStyle";
			// 
			// ToolStripMenuItemFont
			// 
			resources.ApplyResources(this.ToolStripMenuItemFont, "ToolStripMenuItemFont");
			this.ToolStripMenuItemFont.Name = "ToolStripMenuItemFont";
			this.ToolStripMenuItemFont.Click += new System.EventHandler(this.ToolStripMenuItemFont_Click);
			// 
			// DataGridViewOutput
			// 
			resources.ApplyResources(this.DataGridViewOutput, "DataGridViewOutput");
			this.DataGridViewOutput.AllowUserToAddRows = false;
			this.DataGridViewOutput.AllowUserToDeleteRows = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridViewOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridViewOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnStarVelocity,
            this.ColumnStarDistance,
            this.ColumnKelvin,
            this.ColumnEventHorizon});
			this.DataGridViewOutput.EnableHeadersVisualStyles = false;
			this.DataGridViewOutput.Name = "DataGridViewOutput";
			this.DataGridViewOutput.ReadOnly = true;
			this.DataGridViewOutput.RowHeadersVisible = false;
			this.DataGridViewOutput.RowTemplate.Height = 24;
			this.DataGridViewOutput.TabStop = false;
			// 
			// ColumnName
			// 
			this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnName.FillWeight = 2F;
			resources.ApplyResources(this.ColumnName, "ColumnName");
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			// 
			// ColumnStarVelocity
			// 
			this.ColumnStarVelocity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnStarVelocity.FillWeight = 3F;
			resources.ApplyResources(this.ColumnStarVelocity, "ColumnStarVelocity");
			this.ColumnStarVelocity.Name = "ColumnStarVelocity";
			this.ColumnStarVelocity.ReadOnly = true;
			// 
			// ColumnStarDistance
			// 
			this.ColumnStarDistance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnStarDistance.FillWeight = 4F;
			resources.ApplyResources(this.ColumnStarDistance, "ColumnStarDistance");
			this.ColumnStarDistance.Name = "ColumnStarDistance";
			this.ColumnStarDistance.ReadOnly = true;
			// 
			// ColumnKelvin
			// 
			this.ColumnKelvin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnKelvin.FillWeight = 1F;
			resources.ApplyResources(this.ColumnKelvin, "ColumnKelvin");
			this.ColumnKelvin.Name = "ColumnKelvin";
			this.ColumnKelvin.ReadOnly = true;
			// 
			// ColumnEventHorizon
			// 
			this.ColumnEventHorizon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ColumnEventHorizon.FillWeight = 6F;
			resources.ApplyResources(this.ColumnEventHorizon, "ColumnEventHorizon");
			this.ColumnEventHorizon.Name = "ColumnEventHorizon";
			this.ColumnEventHorizon.ReadOnly = true;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// TextBoxInputWavelengthObserved
			// 
			resources.ApplyResources(this.TextBoxInputWavelengthObserved, "TextBoxInputWavelengthObserved");
			this.TextBoxInputWavelengthObserved.Name = "TextBoxInputWavelengthObserved";
			this.TextBoxInputWavelengthObserved.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// TextBoxInputWavelengthRest
			// 
			resources.ApplyResources(this.TextBoxInputWavelengthRest, "TextBoxInputWavelengthRest");
			this.TextBoxInputWavelengthRest.Name = "TextBoxInputWavelengthRest";
			this.TextBoxInputWavelengthRest.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// TextBoxInputParallax
			// 
			resources.ApplyResources(this.TextBoxInputParallax, "TextBoxInputParallax");
			this.TextBoxInputParallax.Name = "TextBoxInputParallax";
			this.TextBoxInputParallax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			this.TextBoxInputParallax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// TextBoxInputCelsius
			// 
			resources.ApplyResources(this.TextBoxInputCelsius, "TextBoxInputCelsius");
			this.TextBoxInputCelsius.Name = "TextBoxInputCelsius";
			this.TextBoxInputCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			this.TextBoxInputCelsius.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// label6
			// 
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			// 
			// label7
			// 
			resources.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			// 
			// ButtonCalculate
			// 
			resources.ApplyResources(this.ButtonCalculate, "ButtonCalculate");
			this.ButtonCalculate.Name = "ButtonCalculate";
			this.ButtonCalculate.UseVisualStyleBackColor = true;
			this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
			// 
			// TextBoxInputMass
			// 
			resources.ApplyResources(this.TextBoxInputMass, "TextBoxInputMass");
			this.TextBoxInputMass.Name = "TextBoxInputMass";
			this.TextBoxInputMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			this.TextBoxInputMass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// label8
			// 
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			// 
			// label9
			// 
			resources.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			// 
			// NumericUpDownInputMass
			// 
			resources.ApplyResources(this.NumericUpDownInputMass, "NumericUpDownInputMass");
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
			this.NumericUpDownInputMass.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
			// 
			// label10
			// 
			resources.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
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
			resources.ApplyResources(this.ButtonLanguage, "ButtonLanguage");
			this.ButtonLanguage.Name = "ButtonLanguage";
			this.ButtonLanguage.UseVisualStyleBackColor = true;
			this.ButtonLanguage.Click += new System.EventHandler(this.ButtonLanguage_Click);
			// 
			// ButtonTheme
			// 
			resources.ApplyResources(this.ButtonTheme, "ButtonTheme");
			this.ButtonTheme.Name = "ButtonTheme";
			this.ButtonTheme.UseVisualStyleBackColor = true;
			this.ButtonTheme.Click += new System.EventHandler(this.ButtonTheme_Click);
			// 
			// ButtonStyle
			// 
			resources.ApplyResources(this.ButtonStyle, "ButtonStyle");
			this.ButtonStyle.Name = "ButtonStyle";
			this.ButtonStyle.UseVisualStyleBackColor = true;
			this.ButtonStyle.Click += new System.EventHandler(this.ButtonStyle_Click);
			// 
			// ButtonFrench
			// 
			resources.ApplyResources(this.ButtonFrench, "ButtonFrench");
			this.ButtonFrench.Name = "ButtonFrench";
			this.ButtonFrench.UseVisualStyleBackColor = true;
			this.ButtonFrench.Click += new System.EventHandler(this.ButtonFrench_Click);
			// 
			// ButtonGerman
			// 
			resources.ApplyResources(this.ButtonGerman, "ButtonGerman");
			this.ButtonGerman.Name = "ButtonGerman";
			this.ButtonGerman.UseVisualStyleBackColor = true;
			this.ButtonGerman.Click += new System.EventHandler(this.ButtonGerman_Click);
			// 
			// ButtonEnglish
			// 
			resources.ApplyResources(this.ButtonEnglish, "ButtonEnglish");
			this.ButtonEnglish.Name = "ButtonEnglish";
			this.ButtonEnglish.UseVisualStyleBackColor = true;
			this.ButtonEnglish.Click += new System.EventHandler(this.ButtonEnglish_Click);
			// 
			// ButtonLight
			// 
			resources.ApplyResources(this.ButtonLight, "ButtonLight");
			this.ButtonLight.Name = "ButtonLight";
			this.ButtonLight.UseVisualStyleBackColor = true;
			this.ButtonLight.Click += new System.EventHandler(this.ButtonLight_Click);
			// 
			// ButtonDark
			// 
			resources.ApplyResources(this.ButtonDark, "ButtonDark");
			this.ButtonDark.Name = "ButtonDark";
			this.ButtonDark.UseVisualStyleBackColor = true;
			this.ButtonDark.Click += new System.EventHandler(this.ButtonDark_Click);
			// 
			// ButtonCustom
			// 
			resources.ApplyResources(this.ButtonCustom, "ButtonCustom");
			this.ButtonCustom.Name = "ButtonCustom";
			this.ButtonCustom.UseVisualStyleBackColor = true;
			this.ButtonCustom.Click += new System.EventHandler(this.ButtonCustom_Click);
			// 
			// ButtonForeground
			// 
			resources.ApplyResources(this.ButtonForeground, "ButtonForeground");
			this.ButtonForeground.Name = "ButtonForeground";
			this.ButtonForeground.UseVisualStyleBackColor = true;
			this.ButtonForeground.Click += new System.EventHandler(this.ButtonForeground_Click);
			// 
			// ButtonBackground
			// 
			resources.ApplyResources(this.ButtonBackground, "ButtonBackground");
			this.ButtonBackground.Name = "ButtonBackground";
			this.ButtonBackground.UseVisualStyleBackColor = true;
			this.ButtonBackground.Click += new System.EventHandler(this.ButtonBackground_Click);
			// 
			// ButtonFont
			// 
			resources.ApplyResources(this.ButtonFont, "ButtonFont");
			this.ButtonFont.Name = "ButtonFont";
			this.ButtonFont.UseVisualStyleBackColor = true;
			this.ButtonFont.Click += new System.EventHandler(this.ButtonFont_Click);
			// 
			// TextBoxInputName
			// 
			resources.ApplyResources(this.TextBoxInputName, "TextBoxInputName");
			this.TextBoxInputName.Name = "TextBoxInputName";
			this.TextBoxInputName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// label11
			// 
			resources.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			// 
			// label12
			// 
			resources.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			// 
			// label13
			// 
			resources.ApplyResources(this.label13, "label13");
			this.label13.Name = "label13";
			// 
			// label14
			// 
			resources.ApplyResources(this.label14, "label14");
			this.label14.Name = "label14";
			// 
			// label15
			// 
			resources.ApplyResources(this.label15, "label15");
			this.label15.Name = "label15";
			// 
			// label16
			// 
			resources.ApplyResources(this.label16, "label16");
			this.label16.Name = "label16";
			// 
			// label17
			// 
			resources.ApplyResources(this.label17, "label17");
			this.label17.Name = "label17";
			// 
			// label18
			// 
			resources.ApplyResources(this.label18, "label18");
			this.label18.Name = "label18";
			// 
			// label19
			// 
			resources.ApplyResources(this.label19, "label19");
			this.label19.Name = "label19";
			// 
			// label20
			// 
			resources.ApplyResources(this.label20, "label20");
			this.label20.Name = "label20";
			// 
			// label21
			// 
			resources.ApplyResources(this.label21, "label21");
			this.label21.Name = "label21";
			// 
			// label22
			// 
			resources.ApplyResources(this.label22, "label22");
			this.label22.Name = "label22";
			// 
			// label23
			// 
			resources.ApplyResources(this.label23, "label23");
			this.label23.Name = "label23";
			// 
			// label24
			// 
			resources.ApplyResources(this.label24, "label24");
			this.label24.Name = "label24";
			// 
			// label25
			// 
			resources.ApplyResources(this.label25, "label25");
			this.label25.Name = "label25";
			// 
			// label26
			// 
			resources.ApplyResources(this.label26, "label26");
			this.label26.Name = "label26";
			// 
			// label27
			// 
			resources.ApplyResources(this.label27, "label27");
			this.label27.Name = "label27";
			// 
			// label28
			// 
			resources.ApplyResources(this.label28, "label28");
			this.label28.Name = "label28";
			// 
			// label29
			// 
			resources.ApplyResources(this.label29, "label29");
			this.label29.Name = "label29";
			// 
			// label30
			// 
			resources.ApplyResources(this.label30, "label30");
			this.label30.Name = "label30";
			// 
			// label31
			// 
			resources.ApplyResources(this.label31, "label31");
			this.label31.Name = "label31";
			// 
			// label32
			// 
			resources.ApplyResources(this.label32, "label32");
			this.label32.Name = "label32";
			// 
			// label33
			// 
			resources.ApplyResources(this.label33, "label33");
			this.label33.Name = "label33";
			// 
			// ClientForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label33);
			this.Controls.Add(this.label32);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.label30);
			this.Controls.Add(this.label29);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
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
			this.Controls.Add(this.MenuStrip);
			this.Controls.Add(this.ButtonFont);
			this.Controls.Add(this.DataGridViewOutput);
			this.MaximizeBox = false;
			this.Name = "ClientForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
			this.Load += new System.EventHandler(this.ClientForm_Load);
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
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
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStarVelocity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStarDistance;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKelvin;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEventHorizon;
	}
}

