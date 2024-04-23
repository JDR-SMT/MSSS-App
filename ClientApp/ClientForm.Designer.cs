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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.DataGridViewOutput = new System.Windows.Forms.DataGridView();
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
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInputMass)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLanguage,
            this.ToolStripMenuItemTheme,
            this.ToolStripMenuItemStyle});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(842, 28);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip";
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
			// 
			// ToolStripMenuItemGerman
			// 
			this.ToolStripMenuItemGerman.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemGerman.Image")));
			this.ToolStripMenuItemGerman.Name = "ToolStripMenuItemGerman";
			this.ToolStripMenuItemGerman.Size = new System.Drawing.Size(224, 26);
			this.ToolStripMenuItemGerman.Text = "German";
			// 
			// ToolStripMenuItemEnglish
			// 
			this.ToolStripMenuItemEnglish.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemEnglish.Image")));
			this.ToolStripMenuItemEnglish.Name = "ToolStripMenuItemEnglish";
			this.ToolStripMenuItemEnglish.Size = new System.Drawing.Size(224, 26);
			this.ToolStripMenuItemEnglish.Text = "English";
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
			this.ToolStripMenuItemLight.Size = new System.Drawing.Size(224, 26);
			this.ToolStripMenuItemLight.Text = "Light";
			this.ToolStripMenuItemLight.Click += new System.EventHandler(this.ToolStripMenuItemLight_Click);
			// 
			// ToolStripMenuItemDark
			// 
			this.ToolStripMenuItemDark.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemDark.Image")));
			this.ToolStripMenuItemDark.Name = "ToolStripMenuItemDark";
			this.ToolStripMenuItemDark.Size = new System.Drawing.Size(224, 26);
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
			this.ToolStripMenuItemCustom.Size = new System.Drawing.Size(224, 26);
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
			this.ToolStripMenuItemFont.Size = new System.Drawing.Size(224, 26);
			this.ToolStripMenuItemFont.Text = "Font";
			this.ToolStripMenuItemFont.Click += new System.EventHandler(this.ToolStripMenuItemFont_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Location = new System.Drawing.Point(0, 601);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(842, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// DataGridViewOutput
			// 
			this.DataGridViewOutput.AllowUserToAddRows = false;
			this.DataGridViewOutput.AllowUserToDeleteRows = false;
			this.DataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridViewOutput.Location = new System.Drawing.Point(290, 50);
			this.DataGridViewOutput.Name = "DataGridViewOutput";
			this.DataGridViewOutput.ReadOnly = true;
			this.DataGridViewOutput.RowHeadersVisible = false;
			this.DataGridViewOutput.RowHeadersWidth = 51;
			this.DataGridViewOutput.RowTemplate.Height = 24;
			this.DataGridViewOutput.Size = new System.Drawing.Size(530, 530);
			this.DataGridViewOutput.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "STAR VELOCITY";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(237, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Observed Wavelength (in nanometres)";
			// 
			// TextBoxInputWavelengthObserved
			// 
			this.TextBoxInputWavelengthObserved.Location = new System.Drawing.Point(20, 100);
			this.TextBoxInputWavelengthObserved.Name = "TextBoxInputWavelengthObserved";
			this.TextBoxInputWavelengthObserved.Size = new System.Drawing.Size(240, 22);
			this.TextBoxInputWavelengthObserved.TabIndex = 6;
			this.TextBoxInputWavelengthObserved.Text = "500.1";
			// 
			// TextBoxInputWavelengthRest
			// 
			this.TextBoxInputWavelengthRest.Location = new System.Drawing.Point(20, 160);
			this.TextBoxInputWavelengthRest.Name = "TextBoxInputWavelengthRest";
			this.TextBoxInputWavelengthRest.Size = new System.Drawing.Size(240, 22);
			this.TextBoxInputWavelengthRest.TabIndex = 8;
			this.TextBoxInputWavelengthRest.Text = "500.0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(220, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Wavelength At Rest (in nanometres)";
			// 
			// TextBoxInputParallax
			// 
			this.TextBoxInputParallax.Location = new System.Drawing.Point(20, 270);
			this.TextBoxInputParallax.Name = "TextBoxInputParallax";
			this.TextBoxInputParallax.Size = new System.Drawing.Size(240, 22);
			this.TextBoxInputParallax.TabIndex = 12;
			this.TextBoxInputParallax.Text = "0.547";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 250);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(192, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Parallax Angle (in arc seconds)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(155, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "STAR DISTANCE";
			// 
			// TextBoxInputCelsius
			// 
			this.TextBoxInputCelsius.Location = new System.Drawing.Point(20, 380);
			this.TextBoxInputCelsius.Name = "TextBoxInputCelsius";
			this.TextBoxInputCelsius.Size = new System.Drawing.Size(240, 22);
			this.TextBoxInputCelsius.TabIndex = 20;
			this.TextBoxInputCelsius.Text = "27";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 360);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 16);
			this.label6.TabIndex = 19;
			this.label6.Text = "Temperature (in Celsius)";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(20, 330);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 20);
			this.label7.TabIndex = 18;
			this.label7.Text = "KELVIN";
			// 
			// ButtonCalculate
			// 
			this.ButtonCalculate.Location = new System.Drawing.Point(170, 550);
			this.ButtonCalculate.Name = "ButtonCalculate";
			this.ButtonCalculate.Size = new System.Drawing.Size(90, 30);
			this.ButtonCalculate.TabIndex = 25;
			this.ButtonCalculate.Text = "Calculate";
			this.ButtonCalculate.UseVisualStyleBackColor = true;
			this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
			// 
			// TextBoxInputMass
			// 
			this.TextBoxInputMass.Location = new System.Drawing.Point(20, 490);
			this.TextBoxInputMass.Name = "TextBoxInputMass";
			this.TextBoxInputMass.Size = new System.Drawing.Size(140, 22);
			this.TextBoxInputMass.TabIndex = 24;
			this.TextBoxInputMass.Text = "8.2";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 470);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(192, 16);
			this.label8.TabIndex = 23;
			this.label8.Text = "Black Hole Mass (in kilograms)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(20, 440);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(158, 20);
			this.label9.TabIndex = 22;
			this.label9.Text = "EVENT HORIZON";
			// 
			// NumericUpDownInputMass
			// 
			this.NumericUpDownInputMass.Location = new System.Drawing.Point(210, 490);
			this.NumericUpDownInputMass.Name = "NumericUpDownInputMass";
			this.NumericUpDownInputMass.Size = new System.Drawing.Size(50, 22);
			this.NumericUpDownInputMass.TabIndex = 26;
			this.NumericUpDownInputMass.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(170, 500);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(30, 16);
			this.label10.TabIndex = 27;
			this.label10.Text = "x 10";
			// 
			// colorDialog
			// 
			this.colorDialog.AllowFullOpen = false;
			// 
			// fontDialog
			// 
			this.fontDialog.AllowVerticalFonts = false;
			this.fontDialog.MaxSize = 14;
			this.fontDialog.ShowEffects = false;
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 623);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.NumericUpDownInputMass);
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
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DataGridViewOutput);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ClientForm";
			this.Text = "Malin Space Science Systems Application";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInputMass)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip;
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
		private System.Windows.Forms.StatusStrip statusStrip1;
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
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.FontDialog fontDialog;
	}
}

