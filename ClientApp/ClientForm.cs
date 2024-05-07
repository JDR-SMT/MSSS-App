using ClientApp.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace ClientApp
{
	public partial class ClientForm : Form
	{
		public ClientForm()
		{
			InitializeComponent();
		}

		#region Form Load and Closing
		private void ClientForm_Load(object sender, EventArgs e)
		{
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "ServerApp.exe";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
			}
			// if the ServerApp.exe file is missing
			catch (Win32Exception)
			{
				MessageBox.Show(strings.ServerMissing, strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// find the ServerApp.exe process
			foreach (var process in Process.GetProcessesByName("ServerApp"))
			{
				// close the server
				process.CloseMainWindow();
			}
		}
		#endregion

		#region KeyPress and KeyUp
		private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			// allow digits, decimals, negatives and backspaces
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}

			// allow a single decimal
			if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}

			// allow a single minus sign at the beginning
			if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
			{
				e.Handled = true;
			}
		}

		// press enter or return to go to next text box
		private void TextBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
			{
				SelectNextControl((Control)sender, true, true, true, true);
			}
		}
		#endregion

		#region Channel Method
		private IAstroContract CreateChannel()
		{
			// set base address
			string address = "net.pipe://localhost/pipeformulas";

			// create NetNamedPipeBinding instance
			NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

			// create EndpointAddress instance
			EndpointAddress ep = new EndpointAddress(address);

			// create a channel to the server
			return ChannelFactory<IAstroContract>.CreateChannel(binding, ep);
		}
		#endregion

		#region Calculate Methods
		private double StarVelocity(double observed, double rest)
		{
			IAstroContract channel = CreateChannel();

			// calculate star velocity
			double velocity = channel.StarVelocity(observed, rest);

			// round and return value
			return Math.Round(velocity, 0);
		}

		private double StarDistance(double parallax)
		{
			IAstroContract channel = CreateChannel();

			// calculate star distance
			double distance = channel.StarDistance(parallax);

			// round and return value
			return Math.Round(distance, 2);
		}

		private double Kelvin(double celsius)
		{
			IAstroContract channel = CreateChannel();

			// calculate Kelvin temperature
			double kelvin = channel.Kelvin(celsius);

			// return value
			return kelvin;
		}

		private double EventHorizon(double mass)
		{
			IAstroContract channel = CreateChannel();

			// calculate event horizon
			double radius = channel.EventHorizon(mass);

			// return value
			return radius;
		}
		#endregion

		#region Calculate Button
		private void ButtonCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				// add a new row
				int row = DataGridViewOutput.Rows.Add(1);

				// clear auto selection of first cell of new row
				DataGridViewOutput.ClearSelection();

				// input name
				if (!string.IsNullOrEmpty(TextBoxInputName.Text))
				{
					string name = TextBoxInputName.Text;
					DataGridViewOutput[ColumnName.Index, row].Value = name;
				}

				// input observed wavelength and wavelength at rest
				if (!string.IsNullOrEmpty(TextBoxInputWavelengthObserved.Text) && !string.IsNullOrEmpty(TextBoxInputWavelengthRest.Text))
				{
					double.TryParse(TextBoxInputWavelengthObserved.Text, out double observed);
					double.TryParse(TextBoxInputWavelengthRest.Text, out double rest);

					if (observed == 0 || rest == 0)
					{
						MessageBox.Show(strings.InvalidWavelength, strings.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						double velocity = StarVelocity(observed, rest);
						DataGridViewOutput[ColumnStarVelocity.Index, row].Value = $"{velocity} m/s";
					}
				}

				// input parallax angle
				if (!string.IsNullOrEmpty(TextBoxInputParallax.Text))
				{
					double.TryParse(TextBoxInputParallax.Text, out double parallax);

					if (parallax == 0)
					{
						MessageBox.Show(strings.InvalidParallax, strings.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						double distance = StarDistance(parallax);
						DataGridViewOutput[ColumnStarDistance.Index, row].Value = $"{distance} pc";
					}
				}

				// input temperature in degrees celsius
				if (!string.IsNullOrEmpty(TextBoxInputCelsius.Text))
				{
					double.TryParse(TextBoxInputCelsius.Text, out double celsius);

					if (celsius < -273.15)
					{
						MessageBox.Show(strings.InvalidCelsius, strings.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						double kelvin = Kelvin(celsius);
						DataGridViewOutput[ColumnKelvin.Index, row].Value = $"{kelvin} K";
					}
				}

				// input black hole mass
				if (!string.IsNullOrEmpty(TextBoxInputMass.Text))
				{
					double.TryParse(TextBoxInputMass.Text, out double mass);

					if (mass == 0)
					{
						MessageBox.Show(strings.InvalidMass, strings.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						mass *= Math.Pow(10, (double)NumericUpDownInputMass.Value);
						double radius = EventHorizon(mass);
						DataGridViewOutput[ColumnEventHorizon.Index, row].Value = $"{radius:E1} m";
					}
				}
			}
			// the server is not running
			catch (EndpointNotFoundException)
			{
				DataGridViewOutput.Rows.Clear();
				MessageBox.Show(strings.ServerNotRunning, strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Language Set
		private void SetLanguage(string language)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
			ComponentResourceManager manager = new ComponentResourceManager(typeof(ClientForm));

			// apply resources to form
			manager.ApplyResources(this, "$this");

			foreach (Control control in Controls)
			{
				// apply resources to all controls
				manager.ApplyResources(control, control.Name);

				if (control is DataGridView dataGridView)
				{
					// apply resources to DataGridView columns
					foreach (DataGridViewColumn column in dataGridView.Columns)
					{
						manager.ApplyResources(column, column.Name);
					}
				}

				if (control is MenuStrip)
				{
					// apply resources to tool strip items
					foreach (ToolStripItem toolStripItem in MenuStrip.Items)
					{
						manager.ApplyResources(toolStripItem, toolStripItem.Name);

						// apply resources to drop down items
						foreach (ToolStripDropDownItem dropDownItem in ((ToolStripDropDownItem)toolStripItem).DropDownItems)
						{
							manager.ApplyResources(dropDownItem, dropDownItem.Name);

							// apply resources to sub drop down items
							foreach (ToolStripDropDownItem subDropDownItem in dropDownItem.DropDownItems)
							{
								manager.ApplyResources(subDropDownItem, subDropDownItem.Name);
							}
						}
					}
				}
			}
		}
		#endregion

		#region Theme Get and Set
		private void GetForeColor()
		{
			if (ColorDialog.ShowDialog() == DialogResult.OK)
			{
				var foreColor = ColorDialog.Color;

				// set as the complementary colour
				var backColor = Color.FromArgb(foreColor.ToArgb() ^ 0xffffff);

				SetColor(foreColor, backColor);
			}
		}

		private void GetBackColor()
		{
			if (ColorDialog.ShowDialog() == DialogResult.OK)
			{
				var backColor = ColorDialog.Color;

				// set as the complementary colour
				var foreColor = Color.FromArgb(backColor.ToArgb() ^ 0xffffff);

				SetColor(foreColor, backColor);
			}
		}

		private void SetColor(Color foreColor, Color backColor)
		{
			// if the ForeColor or BackColor is gray, shift the RGB values by 128
			if (foreColor == Color.Gray)
			{
				foreColor = Color.FromArgb(Shift(foreColor.R), Shift(foreColor.G), Shift(foreColor.B));
			}
			else if (backColor == Color.Gray)
			{
				backColor = Color.FromArgb(Shift(backColor.R), Shift(backColor.G), Shift(backColor.B));
			}

			// set form BackColor
			BackColor = backColor;

			// set the ForeColor and BackColor of all controls
			foreach (Control control in Controls)
			{
				control.ForeColor = foreColor;
				control.BackColor = backColor;

				// set the ForeColor and BackColor of the DataGridView
				if (control is DataGridView dataGridView)
				{
					// if the ForeColor and BackColor is set to light mode, apply light mode colours
					if (foreColor == default && backColor == default)
					{
						dataGridView.BackgroundColor = Color.DarkGray;
						dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
						dataGridView.RowsDefaultCellStyle.BackColor = Color.White;
					}
					else
					{
						dataGridView.BackgroundColor = backColor;
						dataGridView.ColumnHeadersDefaultCellStyle.BackColor = backColor;
						dataGridView.RowsDefaultCellStyle.BackColor = backColor;
					}

					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = foreColor;
					dataGridView.RowsDefaultCellStyle.ForeColor = foreColor;
					dataGridView.DefaultCellStyle.ForeColor = foreColor;
					dataGridView.DefaultCellStyle.BackColor = backColor;
				}

				// if the ForeColor and BackColor is set to light mode, apply light mode colours
				if (control is Button && foreColor == default && backColor == default)
				{
					control.BackColor = Color.White;
				}
			}
		}

		// shift the RGB parameter value by 128
		private byte Shift(byte b)
		{
			return (byte)(b + 128);
		}
		#endregion

		#region Font Get and Set
		private void GetFont()
		{
			if (FontDialog.ShowDialog() == DialogResult.OK)
			{
				SetFont(FontDialog.Font);
			}
		}

		private void SetFont(Font font)
		{
			// set the font of all controls
			foreach (Control control in Controls)
			{
				// set the font of the DataGridView cells
				if (control is DataGridView dataGridView)
				{
					dataGridView.DefaultCellStyle.Font = null;
				}

				control.Font = font;
			}
		}
		#endregion

		#region Customisation ToolStripMenuItems
		// French
		private void ToolStripMenuItemFrench_Click(object sender, EventArgs e)
		{
			SetLanguage("fr-FR");
		}

		// German
		private void ToolStripMenuItemGerman_Click(object sender, EventArgs e)
		{
			SetLanguage("de-DE");
		}

		// English
		private void ToolStripMenuItemEnglish_Click(object sender, EventArgs e)
		{
			SetLanguage("en-GB");
		}

		// light theme
		private void ToolStripMenuItemLight_Click(object sender, EventArgs e)
		{
			SetColor(default, default);
		}

		// dark theme
		private void ToolStripMenuItemDark_Click(object sender, EventArgs e)
		{
			SetColor(Color.White, Color.Black);
		}

		// custom foreground colour
		private void ToolStripMenuItemForeColor_Click(object sender, EventArgs e)
		{
			GetForeColor();
		}

		// custom background colour
		private void ToolStripMenuItemBackColor_Click(object sender, EventArgs e)
		{
			GetBackColor();
		}

		// font
		private void ToolStripMenuItemFont_Click(object sender, EventArgs e)
		{
			GetFont();
		}
		#endregion

		#region Customisation Buttons
		// show or hide language buttons
		private void ButtonLanguage_Click(object sender, EventArgs e)
		{
			if (!ButtonFrench.Visible && !ButtonGerman.Visible && !ButtonEnglish.Visible)
			{
				// if ButtonFont is open without closing ButtonTheme first
				if (ButtonLight.Visible && ButtonDark.Visible && ButtonCustom.Visible)
				{
					ButtonTheme_Click(sender, e);
				}

				// if ButtonTheme is open without closing ButtonStyle first
				if (ButtonFont.Visible)
				{
					ButtonStyle_Click(sender, e);
				}

				ButtonFrench.Visible = true;
				ButtonGerman.Visible = true;
				ButtonEnglish.Visible = true;
			}
			else
			{
				ButtonFrench.Visible = false;
				ButtonGerman.Visible = false;
				ButtonEnglish.Visible = false;
			}
		}

		// French
		private void ButtonFrench_Click(object sender, EventArgs e)
		{
			SetLanguage("fr-FR");
		}

		// German
		private void ButtonGerman_Click(object sender, EventArgs e)
		{
			SetLanguage("de-DE");
		}

		// English
		private void ButtonEnglish_Click(object sender, EventArgs e)
		{
			SetLanguage("en-GB");
		}

		// show or hide theme buttons
		private void ButtonTheme_Click(object sender, EventArgs e)
		{
			if (!ButtonLight.Visible && !ButtonDark.Visible && !ButtonCustom.Visible)
			{
				// if ButtonTheme is open without closing ButtonStyle first
				if (ButtonFont.Visible)
				{
					ButtonStyle_Click(sender, e);
				}

				ButtonLight.Visible = true;
				ButtonDark.Visible = true;
				ButtonCustom.Visible = true;
			}
			else
			{
				// if ButtonTheme is open without closing ButtonFont first
				if (ButtonFont.Visible)
				{
					ButtonStyle_Click(sender, e);
				}

				// if ButtonTheme is closed without closing ButtonCustom first
				if (ButtonForeground.Visible && ButtonBackground.Visible)
				{
					ButtonCustom_Click(sender, e);
				}

				ButtonLight.Visible = false;
				ButtonDark.Visible = false;
				ButtonCustom.Visible = false;
			}
		}

		// light theme
		private void ButtonLight_Click(object sender, EventArgs e)
		{
			SetColor(default, default);
		}

		// dark theme
		private void ButtonDark_Click(object sender, EventArgs e)
		{
			SetColor(Color.White, Color.Black);
		}

		// show or hide custom colour buttons
		private void ButtonCustom_Click(object sender, EventArgs e)
		{
			if (!ButtonForeground.Visible && !ButtonBackground.Visible)
			{
				ButtonForeground.Visible = true;
				ButtonBackground.Visible = true;
			}
			else
			{
				ButtonForeground.Visible = false;
				ButtonBackground.Visible = false;
			}
		}

		// custom foreground colour
		private void ButtonForeground_Click(object sender, EventArgs e)
		{
			GetForeColor();
		}

		// custom background colour
		private void ButtonBackground_Click(object sender, EventArgs e)
		{
			GetBackColor();
		}

		// show or hide style button
		private void ButtonStyle_Click(object sender, EventArgs e)
		{
			if (!ButtonFont.Visible)
			{
				ButtonFont.Visible = true;
			}
			else
			{
				ButtonFont.Visible = false;
			}
		}

		//font 
		private void ButtonFont_Click(object sender, EventArgs e)
		{
			GetFont();
		}
		#endregion
	}
}
